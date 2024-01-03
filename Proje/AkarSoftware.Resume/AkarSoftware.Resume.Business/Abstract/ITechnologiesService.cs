using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.TechnologiesDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface ITechnologiesService
	{
		public Task<IDataResult<List<TechnologiesListDto>>> GetTechnologiesForPersonelCard();
        public Task<IDataResult<List<TechnologiesListDto>>> GetAllTechnologiesWithDeleted();

    }
}
