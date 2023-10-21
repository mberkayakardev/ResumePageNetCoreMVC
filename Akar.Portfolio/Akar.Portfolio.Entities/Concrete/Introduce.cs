using Akar.Portfolio.Entities.Abstract.Base;

namespace Akar.Portfolio.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Introduces")]
    public class Introduce : BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public int ProjectCount { get; set; }

    }
}
