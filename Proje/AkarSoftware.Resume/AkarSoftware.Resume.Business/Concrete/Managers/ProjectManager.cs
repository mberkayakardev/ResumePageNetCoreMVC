using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.ProjectDtos;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ProjectManager : IProjectService
    {
        public Task<IResult> CreateNewProject(ProjectCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
