using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Realizations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Repositories.Realizations.User
{
    public class UserRepository : RepositoryBase<Entities.User.User>, IUserRepository
    {
        public UserRepository(ICHDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
