using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.ProjectDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface IProjectService 
	{
		public Task<IResult> CreateNewProject(ProjectCreateDto dto);
	}
}
