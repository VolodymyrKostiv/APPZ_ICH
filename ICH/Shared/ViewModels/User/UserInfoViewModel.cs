using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Shared.ViewModels.User
{
    public class UserInfoViewModel
    {
        public int UserInfoId { get; set; }
        public string? UserName { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
        public LocationViewModel? Location { get; set; }
        public EmploymentTypeViewModel? EmploymentType { get; set; }
        public WorkTypeViewModel? WorkType { get; set; }
        public CategoryViewModel? Category { get; set; }
        public DateTime? CreationTime { get; set; }
        //public ICollection<UserViewModel> Users { get; set; }
        public ICollection<SpecialCategoryViewModel>? SpecialCategories { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserInfoViewModel model &&
                   UserInfoId == model.UserInfoId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserInfoId);
        }
    }
}
