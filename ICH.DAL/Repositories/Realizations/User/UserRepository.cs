using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Realizations.Base;

namespace ICH.DAL.Repositories.Realizations.User
{
    public class UserRepository : RepositoryBase<Entities.User.User>, IUserRepository
    {
        public UserRepository(ICHDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
