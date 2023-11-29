using AutoMapper;
using ICH.BLL.DTOs.User;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.User;
using ICH.BLL.Interfaces.Vacancy;
using ICH.BLL.Services.User;
using ICH.BLL.Services.Vacancy;
using ICH.DAL;
using ICH.DAL.Entities.User;
using ICH.DAL.Entities.Vacancy;
using ICH.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System.Linq.Expressions;

namespace ICH.UnitTests
{
    [TestClass]
    public class VacancyServiceTests
    {
        private readonly IVacancyService _vacancyService;
        private readonly Mock<IRepositoryWrapper> _repoWrapperMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ICHDBContext> _dbContextMock;


        public VacancyServiceTests()
        {
            _mapperMock = new Mock<IMapper>();
            _repoWrapperMock = new Mock<IRepositoryWrapper>();
            _dbContextMock = new Mock<ICHDBContext>();

            _vacancyService = new VacancyService(_repoWrapperMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task GetAllVacanciesAsync_ReturnsEmptyList()
        {
            //Arrange
            var vacancies = Enumerable.Empty<Vacancy>();
            var vacancyDTOs = Enumerable.Empty<VacancyDTO>();

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancies);
            _mapperMock.Setup(m => m.Map<IEnumerable<Vacancy>,
                IEnumerable<VacancyDTO>>(It.IsAny<IEnumerable<Vacancy>>()))
                .Returns(vacancyDTOs);

            //Act
            var result = await _vacancyService.GetAllVacanciesAsync();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<VacancyDTO>));
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());


            _repoWrapperMock.Verify(repo => repo.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
              It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()),
            Times.Once);

            _mapperMock.Verify(mapper => mapper.Map<IEnumerable<VacancyDTO>>(vacancies), Times.Once);
        }

        [TestMethod]
        public async Task GetAllVacanciesAsync_ReturnsFilledList()
        {
            //Arrange
            var vacancies = _testVacancies;
            var vacancyDTOs = _testVacancyDTOs;
            var vacancyService = _vacancyService;

            _repoWrapperMock.Setup(repo => repo.VacancyRepository.GetAllAsync(
                        It.IsAny<Expression<Func<Vacancy, bool>>>(),
                        It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                        .ReturnsAsync(vacancies);

            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<VacancyDTO>>(vacancies))
                .Returns(vacancyDTOs);

            // Act
            var result = await vacancyService.GetAllVacanciesAsync();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<VacancyDTO>));
            Assert.AreEqual(vacancyDTOs.Count(), result.Count());

            _repoWrapperMock.Verify(repo => repo.VacancyRepository.GetAllAsync(
            It.IsAny<Expression<Func<Vacancy, bool>>>(),
            It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()),
            Times.Once);

            _mapperMock.Verify(mapper => mapper.Map<IEnumerable<VacancyDTO>>(vacancies), Times.Once);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(11111)]
        public async Task GetVacancyByIdAsync_Found(int id)
        {
            //Arrange
            var vacancies = _testVacancy;
            var vacancyDTOs = _testVacancyDTO;
            var vacancyService = _vacancyService;

            _repoWrapperMock
                .Setup(repo => repo.VacancyRepository.GetFirstOrDefaultAsync(
                    It.IsAny<Expression<Func<Vacancy, bool>>>(),
                    It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancies);

            _mapperMock
                .Setup(mapper => mapper.Map<VacancyDTO>(vacancies))
                .Returns(vacancyDTOs);

            //Act
            var result = await vacancyService.GetVacancyByIdAsync(id);

            //Assert
            Assert.IsInstanceOfType(result, typeof(VacancyDTO));
            Assert.IsNotNull(result);
            Assert.AreEqual(vacancyDTOs, result);

            _mapperMock.Verify(mapper => mapper.Map<VacancyDTO>(vacancies), Times.Once);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-1111111)]
        public async Task GetVacancyByIdAsync_NotFound(int value)
        {
            //Arrange
            Vacancy vacancy = null;
            VacancyDTO vacancyDTO = null;

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetFirstOrDefaultAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancy);
            _mapperMock.Setup(m => m.Map<Vacancy, VacancyDTO>(It.IsAny<Vacancy>()))
                .Returns(vacancyDTO);

            //Act
            var result = await _vacancyService.GetVacancyByIdAsync(value);

            //Assert
            Assert.IsNull(result);
        }

        private readonly Vacancy _testVacancy = new Vacancy { VacancyId = 1, Title = "Programmer", Company = "Abto", };

        private readonly VacancyDTO _testVacancyDTO = new VacancyDTO { VacancyId = 1, Title = "Programmer", Company = "Abto", };

        private readonly IEnumerable<Vacancy> _testVacancies = new List<Vacancy>
        { 
            new Vacancy { VacancyId = 1, Title = "Programmer", Company = "Abto", },
            new Vacancy { VacancyId = 2, Title = "Tester", Company = "Abto", },
            new Vacancy { VacancyId = 3, Title = "Project manager", Company = "Abto", },
        };

        private readonly IEnumerable<VacancyDTO> _testVacancyDTOs = new List<VacancyDTO>
        {
            new VacancyDTO { VacancyId = 1, Title = "Programmer", Company = "Abto", },
            new VacancyDTO { VacancyId = 2, Title = "Tester", Company = "Abto", },
            new VacancyDTO { VacancyId = 3, Title = "Project manager", Company = "Abto", },
        };
    }
}

