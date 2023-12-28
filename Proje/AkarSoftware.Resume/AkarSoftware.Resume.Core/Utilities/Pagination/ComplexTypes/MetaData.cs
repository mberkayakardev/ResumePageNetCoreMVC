namespace AkarSoftware.Resume.Core.Utilities.Pagination.ComplexTypes
{
    public class MetaData
    {
        public int CurrentPage { get; set; } // Şuanki sayfamızı belirtecektir. 
        public int TotalPage { get; set; } // Toplamdaki sayfa sayısı belirtilecektir. 
        public int Pagesize { get; set; } // Sayfa item miktarı
        public int TotalCount { get; set; } // Toplam Kayıt Sayısı 
        public bool HasPrevious => CurrentPage > 1; // öncesinde bir sayfa var demektir. 
        public bool HasNextPage => CurrentPage < TotalPage; //son sayfaya eşit değilse sonrasında sayfa vardır . 

    }
}
