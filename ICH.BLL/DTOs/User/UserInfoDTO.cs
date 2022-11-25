using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.DTOs.User
{
    public class UserInfoDTO
    {
        public int UserInfoId { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
        public LocationDTO? Location { get; set; }
        public EmploymentTypeDTO? EmploymentType { get; set; }
        public WorkTypeDTO? WorkType { get; set; }
        public CategoryDTO? Category { get; set; }
        public ICollection<UserDTO> Users { get; set; }
        public ICollection<SpecialCategoryDTO>? SpecialCategories { get; set; }
    }
}
