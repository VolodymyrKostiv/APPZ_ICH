using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.Server.ViewModels.Vacancy;

namespace ICH.Server.Mapping.Vacancy
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<VacancyViewModel, VacancyDTO>().ReverseMap();
            CreateMap<EmploymentTypeViewModel, EmploymentTypeDTO>().ReverseMap();
        }
    }
}
