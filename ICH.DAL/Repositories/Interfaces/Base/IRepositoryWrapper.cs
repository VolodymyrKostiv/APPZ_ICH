using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;

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
