using ICH.DAL.Entities.User;
using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.Vacancy
{
    public class SpecialCategory
    {
        [Key]
        public int SpecialCategoryId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public ICollection<UserInfo> UserInfos { get; set; }
    }
}
