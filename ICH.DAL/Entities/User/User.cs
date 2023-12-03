using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.User
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }

        public UserType UserType { get; set; }
        public UserInfo? UserInfo { get; set; }
        public ICollection<Vacancy.Vacancy> Vacancies { get; set; }

        public IList<UserVacancies> UserVacancies { get; set; }
    }
}
