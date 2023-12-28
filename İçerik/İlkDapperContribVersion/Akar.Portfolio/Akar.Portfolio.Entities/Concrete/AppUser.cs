using Akar.Portfolio.Entities.Abstract;
using Akar.Portfolio.Entities.Abstract.Base;

namespace Akar.Portfolio.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Users")]
    public class AppUser : BaseEntity
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        //public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PositionTitle { get; set; }
        public string DownloadCv { get; set; }
        public string ProfilePhoto { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
