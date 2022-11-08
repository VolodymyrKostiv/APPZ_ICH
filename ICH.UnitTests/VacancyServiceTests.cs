using AutoMapper;
using ICH.BLL.DTOs.Vacancy;
using ICH.BLL.Interfaces.Vacancy;
using ICH.BLL.Services.Vacancy;
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

        public VacancyServiceTests()
        {
            _mapperMock = new Mock<IMapper>();
            _repoWrapperMock = new Mock<IRepositoryWrapper>();

            _vacancyService = new VacancyService(_repoWrapperMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task GetAllVacanciesAsync_ReturnsEmptyList()
        {
            //Arrange
            IEnumerable<Vacancy> vacancies = Enumerable.Empty<Vacancy>();
            IEnumerable<VacancyDTO> vacancyDTOs = Enumerable.Empty<VacancyDTO>();

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
        }

        [TestMethod]
        public async Task GetAllVacanciesAsync_ReturnsFilledList()
        {
            //Arrange
            IEnumerable<Vacancy> vacancies = _testVacancies;
            IEnumerable<VacancyDTO> vacancyDTOs = _testVacancyDTOs;

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancies);
            _mapperMock.Setup(m => m.Map<IEnumerable<Vacancy>, IEnumerable<VacancyDTO>>(It.IsAny<IEnumerable<Vacancy>>()))
                .Returns(vacancyDTOs);

            //Act
            var result = await _vacancyService.GetAllVacanciesAsync();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<VacancyDTO>));
            Assert.IsNotNull(result);
            Assert.IsTrue(Enumerable.SequenceEqual<VacancyDTO>(vacancyDTOs, result));
        }

        [TestMethod]
        [DataRow(1)]
        public async Task GetVacancyByIdAsync_Found(int value)
        {
            //Arrange
            Vacancy vacancy = _testVacancy;
            VacancyDTO vacancyDTO = _testVacancyDTO;

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetFirstOrDefaultAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancy);
            _mapperMock.Setup(m => m.Map<Vacancy, VacancyDTO>(It.IsAny<Vacancy>()))
                .Returns(vacancyDTO);

            //Act
            var result = await _vacancyService.GetVacancyByIdAsync(value);

            //Assert
            Assert.IsInstanceOfType(result, typeof(VacancyDTO));
            Assert.IsNotNull(result);
            Assert.AreEqual(vacancyDTO, result);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-10)]
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
            Assert.IsInstanceOfType(result, typeof(VacancyDTO));
            Assert.IsNull(result);
        }

        [DataRow("Programmer", "Full time", "Date ascending")]
        [TestMethod]
        public async Task GetFilteredVacanciesAsync_ValidParameters_ReturnsFilledList(string searchName, string filter, string sort)
        {
            //Arrange
            IEnumerable<Vacancy> vacancies = _testVacancies;
            IEnumerable<VacancyDTO> vacancyDTOs = _testVacancyDTOs;

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancies);
            _mapperMock.Setup(m => m.Map<IEnumerable<Vacancy>, IEnumerable<VacancyDTO>>(It.IsAny<IEnumerable<Vacancy>>()))
                .Returns(vacancyDTOs);

            //Act
            var result = await _vacancyService.GetFilteredVacanciesAsync(searchName, filter, sort);

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<VacancyDTO>));
            Assert.IsNotNull(result);
            Assert.IsTrue(Enumerable.SequenceEqual<VacancyDTO>(vacancyDTOs, result));
        }

        [DataRow("Hello Biden", "we need 5 billion rockets", "to bomb Donetsk children")]
        [TestMethod]
        public async Task GetFilteredVacanciesAsync_ValidParameters_ReturnsEmptyList(string searchName, string filter, string sort)
        {
            //Arrange
            IEnumerable<Vacancy> vacancies = Enumerable.Empty<Vacancy>();
            IEnumerable<VacancyDTO> vacancyDTOs = Enumerable.Empty<VacancyDTO>();

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(vacancies);
            _mapperMock.Setup(m => m.Map<IEnumerable<Vacancy>, IEnumerable<VacancyDTO>>(It.IsAny<IEnumerable<Vacancy>>()))
                .Returns(vacancyDTOs);

            //Act
            var result = await _vacancyService.GetFilteredVacanciesAsync(searchName, filter, sort);

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<VacancyDTO>));
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [DataRow(null, null, null)]
        [TestMethod]
        public async Task GetFilteredVacanciesAsync_InvalidParameters_ThrowsArgumentNullException(string searchName, string filter, string sort)
        {
            //Arrange
            IEnumerable<Vacancy> vacancies = Enumerable.Empty<Vacancy>();
            IEnumerable<VacancyDTO> vacancyDTOs = Enumerable.Empty<VacancyDTO>();

            _repoWrapperMock
                .Setup(r => r.VacancyRepository.GetAllAsync(It.IsAny<Expression<Func<Vacancy, bool>>>(),
                It.IsAny<Func<IQueryable<Vacancy>, IIncludableQueryable<Vacancy, object>>>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Vacancy>>);
            _mapperMock.Setup(m => m.Map<IEnumerable<Vacancy>, IEnumerable<VacancyDTO>>(It.IsAny<IEnumerable<Vacancy>>()))
                .Returns(It.IsAny<IEnumerable<VacancyDTO>>);

            //Assert
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(() => _vacancyService.GetFilteredVacanciesAsync(searchName, filter, sort));
        }

        private readonly Vacancy _testVacancy = new Vacancy
        {
            VacancyId = 1,
            Title = "Programmer",
            Company = "Abto",
        };

        private readonly VacancyDTO _testVacancyDTO = new VacancyDTO
        {
            VacancyId = 1,
            Title = "Programmer",
            Company = "Abto",
        };

        private readonly IEnumerable<Vacancy> _testVacancies = new List<Vacancy>
        {
            new Vacancy
            {
                VacancyId = 1,
                Title = "Programmer",
                Company = "Abto",
            },
            new Vacancy
            {
                VacancyId = 2,
                Title = "Tester",
                Company = "Abto",
            },
            new Vacancy
            {
                VacancyId = 3,
                Title = "Project manager",
                Company = "Abto",
            },
        };

        private readonly IEnumerable<VacancyDTO> _testVacancyDTOs = new List<VacancyDTO>
        {
            new VacancyDTO
            {
                VacancyId = 1,
                Title = "Programmer",
                Company = "Abto",
            },
            new VacancyDTO
            {
                VacancyId = 2,
                Title = "Tester",
                Company = "Abto",
            },
            new VacancyDTO
            {
                VacancyId = 3,
                Title = "Project manager",
                Company = "Abto",
            },
        };
    }
}

