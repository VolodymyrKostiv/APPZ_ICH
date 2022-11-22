using ICH.DAL.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.General
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public ICollection<ICH.DAL.Entities.Vacancy.Vacancy> Vacancies { get; set; }
        public ICollection<UserInfo> UserInfos { get; set; }
    }
}
