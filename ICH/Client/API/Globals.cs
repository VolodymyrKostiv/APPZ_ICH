namespace ICH.Client.API
{
    internal static class Globals
    {
        public static string ApiUri { get; set; }
        = "https://localhost:7040/api";
    }

    internal static class VacancyGlobals
    {
        private static string VacanciesUri { get; } = Globals.ApiUri + "/Vacancy";
        public static string AllVacanciesUri { get; } = VacanciesUri + "/AllVacancies";
        public static string FilteredVacanciesUri { get; } = VacanciesUri + "/FilteredVacancies";
        public static string CategoriesUri { get; } = VacanciesUri + "/Categories";
        public static string SpecialCategoriesUri { get; } = VacanciesUri + "/SpecialCategories";
        public static string LocationsUri { get; } = VacanciesUri + "/Locations";
        public static string WorkTypesUri { get; } = VacanciesUri + "/WorkTypes";
        public static string EmploymentTypesUri { get; } = VacanciesUri + "/EmploymentTypes";
        public static string VacanyByIdUri { get; } = VacanciesUri;
    }

    internal static class TRPGlobals
    {
        private static string TRPsUri { get; } = Globals.ApiUri + "/User";
        public static string AllTRPsUri { get; } = TRPsUri + "/AllTRPs";
        public static string FilteredTRPsUri { get; } = TRPsUri + "/FilteredTRPs";
        public static string CandidateUri { get; } = TRPsUri;
    }
}
