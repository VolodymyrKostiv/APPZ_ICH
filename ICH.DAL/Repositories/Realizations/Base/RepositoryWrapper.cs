using ICH.DAL.Repositories.Interfaces.Base;
using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.User;
using ICH.DAL.Repositories.Realizations.Vacancy;

namespace ICH.DAL.Repositories.Realizations.Base
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ICHDBContext _dbContext;

        private IUserRepository _user;
        private IUserVacanciesRepository _userVacancies;
        private IUserVacanciesStatusRepository _userVacanciesStatus;
        private IVacancyRepository _vacancy;
        private ICategoryRepository _category;
        private IEmploymentTypeRepository _employmentType;
        private ILocationRepository _location;
        private ISpecialCategoryRepository _specialCategory;
        private IWorkTypeRepository _workType;
        private IVacancyStatusRepository _vacancyStatus;

        public IUserRepository UserRepository
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_dbContext);
                }

                return _user;
            }
        }

        public IUserVacanciesRepository UserVacanciesRepository
        {
            get
            {
                if (_userVacancies == null)
                {
                    _userVacancies = new UserVacanciesRepository(_dbContext);
                }

                return _userVacancies;
            }
        }

        public IUserVacanciesStatusRepository UserVacanciesStatusRepository
        {
            get
            {
                if (_userVacanciesStatus == null)
                {
                    _userVacanciesStatus = new UserVacanciesStatusRepository(_dbContext);
                }

                return _userVacanciesStatus;
            }
        }

        public IVacancyRepository VacancyRepository
        {
            get
            {
                if (_vacancy == null)
                {
                    _vacancy = new VacancyRepository(_dbContext);
                }

                return _vacancy;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_dbContext);
                }

                return _category;
            }
        }
        public ISpecialCategoryRepository SpecialCategoryRepository
        {
            get
            {
                if (_specialCategory == null)
                {
                    _specialCategory = new SpecialCategoryRepository(_dbContext);
                }

                return _specialCategory;
            }
        }

        public IEmploymentTypeRepository EmploymentTypeRepository
        {
            get
            {
                if (_employmentType == null)
                {
                    _employmentType = new EmploymentTypeRepository(_dbContext);
                }

                return _employmentType;
            }
        }

        public ILocationRepository LocationRepository
        {
            get
            {
                if (_location == null)
                {
                    _location = new LocationRepository(_dbContext);
                }

                return _location;
            }
        }

        public IWorkTypeRepository WorkTypeRepository
        {
            get
            {
                if (_workType == null)
                {
                    _workType = new WorkTypeRepository(_dbContext);
                }

                return _workType;
            }
        }

        public IVacancyStatusRepository VacancyStatusRepository
        {
            get
            {
                if (_vacancyStatus == null)
                {
                    _vacancyStatus = new VacancyStatusRepository(_dbContext);
                }

                return _vacancyStatus;
            }
        }


        public RepositoryWrapper(ICHDBContext ICHDBContext)
        {
            _dbContext = ICHDBContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
