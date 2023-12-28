namespace AkarSoftware.Resume.Core.Utilities.Results.BaseResults
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
