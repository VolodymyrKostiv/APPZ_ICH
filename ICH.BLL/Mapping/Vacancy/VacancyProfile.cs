using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.DAL.Entities.General;
using ICH.DAL.Entities.Vacancy;

namespace ICH.BLL.Mapping.Vacancy
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<ICH.DAL.Entities.Vacancy.Vacancy, VacancyDTO>().ReverseMap();
            CreateMap<EmploymentType, EmploymentTypeDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();    
            CreateMap<Location, LocationDTO>().ReverseMap();
            CreateMap<SpecialCategory, SpecialCategoryDTO>().ReverseMap();
            CreateMap<VacancySpecialCategories, VacancySpecialCategoriesDTO>().ReverseMap();
            CreateMap<WorkType, WorkTypeDTO>().ReverseMap();
        }
    }
}
