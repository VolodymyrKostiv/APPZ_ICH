using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.DTOs.User
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserTypeDTO UserType { get; set; }
        public UserInfoDTO? UserInfo { get; set; }
        public ICollection<VacancyDTO> Vacancies { get; set; }
    }
}
