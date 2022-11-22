using ICH.DAL.Entities.Vacancy;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class EmploymentTypeRepository : RepositoryBase<EmploymentType>, IEmploymentTypeRepository
    {
        public EmploymentTypeRepository(ICHDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
