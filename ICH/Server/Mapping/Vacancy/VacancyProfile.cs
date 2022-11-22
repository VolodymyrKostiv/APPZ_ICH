using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Server.Mapping.Vacancy
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<VacancyViewModel, VacancyDTO>().ReverseMap();
            CreateMap<EmploymentTypeViewModel, EmploymentTypeDTO>().ReverseMap();
            CreateMap<LocationViewModel, LocationDTO>().ReverseMap();
            CreateMap<SpecialCategoryViewModel, SpecialCategoryDTO>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryDTO>().ReverseMap();
            CreateMap<WorkTypeViewModel, WorkTypeDTO>().ReverseMap();
        }
    }
}
