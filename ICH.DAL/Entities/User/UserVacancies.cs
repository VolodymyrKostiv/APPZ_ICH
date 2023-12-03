using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.User
{
    public class UserVacancies
    {
        [Key]
        public int UserVacanaId { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public int? VacancyId {  get; set; }
        public Vacancy.Vacancy? Vacancy { get; set; }

        public UserVacancyStatus UserVacancyStatus { get; set; }
    }
}
