using ICH.Client.Enums;
using ICH.Shared.ViewModels.Vacancy;

namespace ICH.Client.API
{
    public class VacancyService : ApiService
    {
        public async Task<IEnumerable<VacancyViewModel>> GetAllVacancies()
        { 
            var items = await GetItems<IEnumerable<VacancyViewModel>>(VacancyGlobals.AllVacanciesUri);

            return items;
        }

        public async Task<IEnumerable<WorkTypeViewModel>> GetAllWorkTypes()
        {
            var items = await GetItems<IEnumerable<WorkTypeViewModel>>(VacancyGlobals.WorkTypesUri);

            return items;
        }

        public async Task<IEnumerable<EmploymentTypeViewModel>> GetAllEmploymentTypes()
        {
            var items = await GetItems<IEnumerable<EmploymentTypeViewModel>>(VacancyGlobals.EmploymentTypesUri);

            return items;
        }

        public async Task<IEnumerable<LocationViewModel>> GetAllLocations()
        {
            var items = await GetItems<IEnumerable<LocationViewModel>>(VacancyGlobals.LocationsUri);

            return items;
        }

        public async Task<IEnumerable<SpecialCategoryViewModel>> GetAllSpecialCategories()
        {
            var items = await GetItems<IEnumerable<SpecialCategoryViewModel>>(VacancyGlobals.SpecialCategoriesUri);

            return items;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
        {
            var items = await GetItems<IEnumerable<CategoryViewModel>>(VacancyGlobals.CategoriesUri);

            return items;
        }

        public async Task<IEnumerable<VacancyViewModel>> GetFilteredVacancies(VacancySearchFiltersViewModel filters)
        {
            var items = await GetItemsViaPost<IEnumerable<VacancyViewModel>>(VacancyGlobals.FilteredVacanciesUri, filters);

            return items;
        }

        public async Task<VacancyViewModel> GetVacancyDetails(int id)
        {
            var items = await GetItems<VacancyViewModel>(VacancyGlobals.VacanyByIdUri + '/' + id);

            return items;
        }

        public async Task AddVacancy(VacancyViewModel vacancy)
        {
            //await Add
        }
    }
}
