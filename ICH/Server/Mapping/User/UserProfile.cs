using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.Server.ViewModels.User;

namespace ICH.Server.Mapping.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserDTO>().ReverseMap();
            CreateMap<CVViewModel, CVDTO>().ReverseMap();
            CreateMap<UserInfoViewModel, UserInfoDTO>().ReverseMap();
            CreateMap<UserTypeViewModel, UserTypeDTO>().ReverseMap();
        }
    }
}
