namespace ICH.Client.API
{
    internal static class Globals
    {
        public static string ApiUri { get; set; }
        = "api";
    }

    internal static class VacancyGlobals
    {
        private static string VacanciesUri { get; } = Globals.ApiUri + "/Vacancy";
        public static string AllVacanciesUri { get; } = VacanciesUri + "/AllVacancies";
        public static string CategoriesUri { get; } = VacanciesUri + "/Categories";
        public static string SpecialCategoriesUri { get; } = VacanciesUri + "/SpecialCategories";
        public static string LocationsUri { get; } = VacanciesUri + "/Locations";
        public static string WorkTypesUri { get; } = VacanciesUri + "/WorkTypes";
        public static string EmploymentTypesUri { get; } = VacanciesUri + "/EmploymentTypes";
    }

    internal static class UserGlobals
    {
        private static string UsersUri { get; } = Globals.ApiUri + "/User";

    }
}
