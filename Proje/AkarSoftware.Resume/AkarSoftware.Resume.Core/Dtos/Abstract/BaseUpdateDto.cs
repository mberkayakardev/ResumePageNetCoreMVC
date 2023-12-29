namespace AkarSoftware.Resume.Core.Dtos.Abstract
{
    public class BaseUpdateDto : BaseDto, IUpdateDto
    {
        public int Id { get ; set ; }
    }
}
