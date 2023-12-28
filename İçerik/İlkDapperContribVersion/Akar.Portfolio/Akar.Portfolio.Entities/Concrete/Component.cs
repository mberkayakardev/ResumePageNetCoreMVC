using Akar.Portfolio.Entities.Abstract.Base;

namespace Akar.Portfolio.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Components")]
    public class Component : BaseEntity
    {
        public int OrderNumber { get; set; }
        public string ComponentName { get; set; }
        public string ComponentProjectName { get; set; }
        public string ComponentDivId { get; set; }

    }
}
