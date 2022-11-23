using ICH.BLL.DTOs.User;

namespace ICH.BLL.DTOs.Vacancy
{
    public class VacancyDTO
    {
        public int VacancyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public LocationDTO? Location { get; set; }
        public DateTime CreationTime { get; set; }
        public int? Salary { get; set; }
        public string? Company { get; set; }
        public EmploymentTypeDTO? EmploymentType { get; set; }
        public WorkTypeDTO? WorkType { get; set; }
        public CategoryDTO? Category { get; set; }
        public UserDTO User { get; set; }
        public ICollection<SpecialCategoryDTO>? SpecialCategories { get; set; }
    }
}
