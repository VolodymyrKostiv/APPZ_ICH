using ICH.DAL.Repositories.Interfaces.Base;
using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.User;
using ICH.DAL.Repositories.Realizations.Vacancy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Repositories.Realizations.Base
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ICHDBContext _dbContext;

        private IUserRepository _user;
        private IVacancyRepository _vacancy;

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
