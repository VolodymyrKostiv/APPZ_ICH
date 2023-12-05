using ICH.DAL.Entities.User;
using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.User
{
    public class UserVacanciesStatusRepository : RepositoryBase<UserVacancyStatus>, IUserVacanciesStatusRepository
    {
        public UserVacanciesStatusRepository(ICHDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
