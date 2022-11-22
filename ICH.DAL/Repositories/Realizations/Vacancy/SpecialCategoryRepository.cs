using ICH.DAL.Entities.Vacancy;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class SpecialCategoryRepository : RepositoryBase<SpecialCategory>, ISpecialCategoryRepository
    {
        public SpecialCategoryRepository(ICHDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
