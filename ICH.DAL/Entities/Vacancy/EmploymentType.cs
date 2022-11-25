using ICH.DAL.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public ICollection<UserInfo> UserInfos { get; set; }
    }
}
