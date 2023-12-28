using Akar.Portfolio.Shared.Entities.Abstract;

namespace Akar.Portfolio.Dtos.Concrete.IntroduceDtos
{
    public class UpdateIntroduceDto : IDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public int ProjectCount { get; set; }
        public bool IsActive { get; set; }
    
    }
}
