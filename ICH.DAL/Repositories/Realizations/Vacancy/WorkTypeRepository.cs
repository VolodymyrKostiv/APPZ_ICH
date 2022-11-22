using ICH.DAL.Entities.Vacancy;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class WorkTypeRepository : RepositoryBase<WorkType>, IWorkTypeRepository
    {
        public WorkTypeRepository(ICHDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
