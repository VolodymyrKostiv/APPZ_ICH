using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.DAL.Entities.User;

namespace ICH.BLL.Mapping.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ICH.DAL.Entities.User.User, UserDTO>().ReverseMap();
            CreateMap<UserInfo, UserInfoDTO>().ReverseMap();
            CreateMap<UserType, UserTypeDTO>().ReverseMap();
        }
    }
}
