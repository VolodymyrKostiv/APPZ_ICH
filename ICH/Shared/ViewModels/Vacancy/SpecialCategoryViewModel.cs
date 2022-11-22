namespace ICH.Shared.ViewModels.Vacancy
{
    public class SpecialCategoryViewModel
    {
        public int SpecialCategoryId { get; set; }
        public string Title { get; set; }
        public ICollection<VacancyViewModel> Vacancies { get; set; }
    }
}
