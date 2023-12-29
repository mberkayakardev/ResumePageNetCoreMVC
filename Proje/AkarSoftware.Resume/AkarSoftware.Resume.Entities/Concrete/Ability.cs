using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
    public class Ability: BaseEntity
    {
        public string Description { get; set; }
        public int OrderNumber { get; set; }

    }
}
