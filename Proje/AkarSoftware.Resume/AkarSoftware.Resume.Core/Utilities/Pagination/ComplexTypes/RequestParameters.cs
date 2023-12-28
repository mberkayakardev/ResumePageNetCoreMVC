namespace AkarSoftware.Resume.Core.Utilities.Pagination.ComplexTypes
{
    public abstract class RequestParameters
    {
        const int MaxPageSize = 6;
        public int PageNumber { get { return (_pageNumber == 0 ? 1 : _pageNumber); } set { _pageNumber = (value <= 0 ? 1 : value); } } // Atılan Sayfa numarası
        public int _pageNumber { get; set; }

        private int _pageSize; // sayfa içerisinde maksimum item sayısı yani bir sayfada 1000 tane gözüksün istemiyorum örneğin
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (MaxPageSize < value ? MaxPageSize : value); }
        }
    }
}
