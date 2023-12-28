namespace Akar.Portfolio.Shared.Utilities.Messages
{
    public static class Messages
    {
        public static class StatusResult
        {
            public const string ValidationError = "ilgili veri validasyon kurallarına uygun değil.";
            public const string DtoEntityConver = "ilgili veri validasyon kurallarına uygun değil.";
            public const string NotFoundMessage = "Herhangi bir kayıt bulunamadı .";

        }
    }

    public static class CRUD
    {
        public const string Added = "Ekleme işlemi başarılı bir şekilde gerçekleştirildi. ";
        public const string Deleted = "Silme işlemi başarılı bir şekilde gerçekleştirildi";
        public const string Updated = "Güncelleme işlemi başarılı bir şekilde gerçekleştirildi";
    }
}
