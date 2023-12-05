using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.User
{
    public class UserVacancyStatus
    {
        [Key]
        public int UserVacancyStatusId { get; set; }

        public string Title { get; set; }
        public ICollection<UserVacancies> Vacancies { get; set; }
    }
}
