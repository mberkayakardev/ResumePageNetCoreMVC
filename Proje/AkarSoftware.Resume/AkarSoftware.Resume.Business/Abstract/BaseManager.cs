using AkarSoftware.Resume.DataAccess.Abstract;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Abstract
{
    public class BaseManager
    {
        protected readonly IMapper _Mapper;
        protected readonly IUnitOfWork _UnitOfWork;
        public BaseManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _Mapper = mapper;
            _UnitOfWork = unitOfWork;
        }
    }
}
