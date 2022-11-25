using ICH.BLL.DTOs.User;

namespace ICH.BLL.DTOs.Vacancy
{
    public class UserInfoSpecialCategoriesDTO
    {
        public int UserInfoId { get; set; }
        public UserInfoDTO UserInfo { get; set; }

        public int SpecialCategoryId { get; set; }
        public SpecialCategoryDTO SpecialCategory { get; set; }
    }
}
