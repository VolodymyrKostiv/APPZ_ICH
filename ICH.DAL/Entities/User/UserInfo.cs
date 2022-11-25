using ICH.DAL.Entities.General;
using ICH.DAL.Entities.Vacancy;

namespace ICH.DAL.Entities.User
{
    public class UserInfo
    {
        public int UserInfoId { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }    
        public Location? Location { get; set; }
        public EmploymentType? EmploymentType { get; set; }
        public WorkType? WorkType { get; set; }
        public Category? Category { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<SpecialCategory>? SpecialCategories { get; set; }
    }
}
