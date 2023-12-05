using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.User
{
    public class UserVacanciesRepository : RepositoryBase<Entities.User.UserVacancies>, IUserVacanciesRepository
    {
        public UserVacanciesRepository(ICHDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
