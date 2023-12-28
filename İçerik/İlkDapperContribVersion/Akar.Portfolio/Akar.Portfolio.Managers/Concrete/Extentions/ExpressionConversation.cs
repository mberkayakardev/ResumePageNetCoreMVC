using Akar.Portfolio.Entities.Abstract;
using Akar.Portfolio.Shared.Entities.Abstract;
using System.Linq.Expressions;

namespace Akar.Portfolio.Managers.Concrete.Extentions
{
    public static class ExpressionConversation
    {
        public static Expression<Func<TEntity, bool>> ConvertExpression <TEntity, TDto>(Expression<Func<TDto, bool>> originalExpression) where TEntity : class , IEntity, new() where TDto : class , IDto, new()
        {
            var parameter = Expression.Parameter(typeof(IDto), "dto");
            var visitor = new ParameterUpdateVisitor(parameter);
            var newBody = visitor.Visit(originalExpression.Body);
            var newLambda = Expression.Lambda<Func<TEntity, bool>>(Expression.Convert(newBody, typeof(bool)), parameter);
            return newLambda;
        }


        public class ParameterUpdateVisitor : ExpressionVisitor
        {
            private readonly ParameterExpression _newParameter;
            public ParameterUpdateVisitor(ParameterExpression newParameter)
            {
                _newParameter = newParameter;
            }
            protected override Expression VisitParameter(ParameterExpression node)
            {
                return _newParameter;
            }
        }

    }
}
