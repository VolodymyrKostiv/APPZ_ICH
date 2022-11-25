using ICH.DAL.Entities.User;

namespace ICH.DAL.Entities.Vacancy
{
    public class UserInfoSpecialCategories
    {
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }

        public int SpecialCategoryId { get; set; }
        public SpecialCategory SpecialCategory { get; set; }
    }
}
