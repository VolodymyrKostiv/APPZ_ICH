using ICH.Shared.ViewModels.User;

namespace ICH.Shared.ViewModels.Vacancy
{
    public class UserInfoSpecialCategoriesViewModel
    {
        public int UserInfoId { get; set; }
        public UserInfoViewModel UserInfo { get; set; }

        public int SpecialCategoryId { get; set; }
        public SpecialCategoryViewModel SpecialCategory { get; set; }
    }
}
