using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime BornDate { get; set; }
        public string Location { get; set; }
        public string PhoneNumber1 { get ; set; }
        public string PhoneNumber2 { get ; set;}
        public string CvPath { get; set; }
        public string ProfilePhotos { get; set; }
        public string Email { get; set; }
    }
}
