using AutoMapper;
using ICH.BLL.DTOs.Vacancy;

namespace ICH.BLL.Mapping.Vacancy
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<ICH.DAL.Entities.Vacancy.Vacancy, VacancyDTO> ().ReverseMap();
        }
    }
}
