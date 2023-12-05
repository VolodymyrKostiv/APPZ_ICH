using System.ComponentModel;

namespace ICH.Client.Enums
{
    public enum UserVacancyStatus
    {
        [Description("Заявку подано")]
        Applied = 1,
        [Description("Відхилено")]
        Proposed = 2,
        [Description("Роботодавець відхилив")]
        EmployeeRejected = 3,
        [Description("Кандидат відхилив")]
        CandidateRejected = 4,
        [Description("Прийнято")]
        Recruited = 5,
        [Description("Скасовано")]
        Cancelled = 6,
        [Description("Ніяка")]
        None = 7,
    }
}
