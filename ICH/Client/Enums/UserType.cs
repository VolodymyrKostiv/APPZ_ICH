using System.ComponentModel;

namespace ICH.Client.Enums
{
    public enum UserType
    {
        [Description("Admin")]
        Admin = 1,
        [Description("Employer")]
        Employer = 2,
        [Description("Candidate")]
        Candidate = 3
    }
}
