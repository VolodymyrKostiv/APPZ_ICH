using ICH.BLL.DTOs.User;

namespace ICH.BLL.DTOs.Vacancy
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyDTO> Vacancies { get; set; }
        public ICollection<UserInfoDTO> UserInfos { get; set; }

    }
}
