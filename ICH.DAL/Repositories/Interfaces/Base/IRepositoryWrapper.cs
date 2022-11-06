using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Repositories.Interfaces.Base
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        IVacancyRepository VacancyRepository { get; }

        void Save();
        Task SaveAsync();
    }
}
