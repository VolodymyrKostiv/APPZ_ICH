using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;

namespace ICH.DAL.Repositories.Interfaces.Base
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        IVacancyRepository VacancyRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ISpecialCategoryRepository SpecialCategoryRepository { get; }
        IEmploymentTypeRepository EmploymentTypeRepository { get; }
        ILocationRepository LocationRepository { get; } 
        IWorkTypeRepository WorkTypeRepository { get; }

        void Save();
        Task SaveAsync();
    }
}
