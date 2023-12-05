using System.ComponentModel;

namespace ICH.Client.Enums
{
    public enum UserType
    {
        [Description("Адмін")]
        Admin = 1,
        [Description("Роботодавець")]
        Employer = 2,
        [Description("Кандидат")]
        Candidate = 3
    }
}
