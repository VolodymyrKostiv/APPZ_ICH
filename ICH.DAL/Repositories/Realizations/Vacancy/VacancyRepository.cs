using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class VacancyRepository : RepositoryBase<Entities.Vacancy.Vacancy>, IVacancyRepository
    {
        public VacancyRepository(ICHDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
