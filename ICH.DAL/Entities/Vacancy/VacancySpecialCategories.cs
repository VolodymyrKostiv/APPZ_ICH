namespace ICH.DAL.Entities.Vacancy
{
    public class VacancySpecialCategories
    {
        public int VacancyId { get; set; }  
        public Vacancy Vacancy { get; set; }

        public int SpecialCategoryId { get; set; }
        public SpecialCategory SpecialCategory { get; set; }
    }
}
