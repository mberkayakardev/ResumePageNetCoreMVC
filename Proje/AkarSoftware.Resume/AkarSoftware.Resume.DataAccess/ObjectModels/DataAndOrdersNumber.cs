using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.DataAccess.ObjectModels
{
    public class DataAndOrdersNumber<T> where T : class , IEntity, new()
    {
        public T Data { get; set; }
        public List<int> OrdersNumbers { get; set; }
    }
}
