using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.Dtos.ProjectDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface IProjectService 
	{

        public Task<IDataResult<List<ProjectListDto>>> GetActiveProjects();
        public Task<IDataResult<ProjectListDto>> GetActiveProjectById(int id);
        public Task<IResult> CreateNewProject(ProjectCreateDto dto);
	}
}
