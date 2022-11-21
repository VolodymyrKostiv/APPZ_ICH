namespace ICH.CommonModels.Filters.Vacancy
{
    public class VacancyFilters
    {
        public string? SearchName { get; set; }
        public string? Location { get; set; }
        public List<string>? Categories { get; set; }    
        public List<string>? EmploymentType { get; set; }    
        public string? SortType { get; set; } 
        public string? SortOrder { get; set; }
    }
}
