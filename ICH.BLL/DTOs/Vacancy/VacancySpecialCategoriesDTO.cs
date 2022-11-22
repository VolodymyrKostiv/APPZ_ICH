namespace ICH.BLL.DTOs.Vacancy
{
    public class VacancySpecialCategoriesDTO
    {
        public int VacancyId { get; set; }
        public VacancyDTO Vacancy { get; set; }

        public int SpecialCategoryId { get; set; }
        public SpecialCategoryDTO SpecialCategory { get; set; }
    }
}
