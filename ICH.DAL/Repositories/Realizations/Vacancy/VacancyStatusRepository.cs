using ICH.DAL.Entities.Vacancy;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class VacancyStatusRepository : RepositoryBase<VacancyStatus>, IVacancyStatusRepository
    {
        public VacancyStatusRepository(ICHDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
