using System.ComponentModel;

namespace ICH.Client.Enums
{
    public enum VacancyStatus
    {
        [Description("Відкрита")]
        Opened = 1,
        [Description("Закрита")]
        Closed = 2,
    }
}
