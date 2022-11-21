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
    }
}
