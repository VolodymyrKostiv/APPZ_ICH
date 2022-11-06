using AutoMapper;
using ICH.BLL.DTOs.User;

namespace ICH.BLL.Mapping.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ICH.DAL.Entities.User.User, UserDTO>().ReverseMap();
        }
    }
}
