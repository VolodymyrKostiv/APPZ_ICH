﻿using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.Shared.ViewModels.User;

namespace ICH.Server.Mapping.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserDTO>().ReverseMap();
            CreateMap<UserInfoViewModel, UserInfoDTO>().ReverseMap();
            CreateMap<UserTypeViewModel, UserTypeDTO>().ReverseMap();
            CreateMap<UserSearchFiltersViewModel, UserSearchFiltersDTO>().ReverseMap();
            CreateMap<UserLoginCredentialsViewModel, UserLoginCredentialsDTO>().ReverseMap();
        }
    }
}
