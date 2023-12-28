using Akar.Portfolio.Shared.Entities.Abstract;

namespace Akar.Portfolio.Dtos.Concrete.AppUser
{
    public class AddAppUserDto : IDto
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PositionTitle { get; set; }
        public string DownloadCv { get; set; }
        public string ProfilePhoto { get; set; }
        public bool IsActived { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
