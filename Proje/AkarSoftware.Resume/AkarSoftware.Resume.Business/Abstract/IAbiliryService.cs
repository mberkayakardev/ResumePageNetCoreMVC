using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.AbilityDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface IAbiliryService
	{
		public Task<IDataResult<List<AbilityListDto>>> GetAbilitiesForPersonelCard();
        public Task<IDataResult<AbilityUpdateDto>> GetAbilitiesForId(int id);
        public Task<IDataResult<List<AbilityListDto>>> GetAllAbilitiesWithDeleted();

    }
}
