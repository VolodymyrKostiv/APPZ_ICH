using ICH.DAL.Entities.General;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.Vacancy
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(ICHDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
