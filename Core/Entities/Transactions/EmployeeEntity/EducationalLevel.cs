using System.Runtime.Serialization;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public enum EducationalLevel
    {
        [EnumMember(Value = "Elementary")]
        Elementary,
        [EnumMember(Value = "Secondary")]
        Secondary,
        [EnumMember(Value = "Vocational/Trade Course")]
        Vocational,
        [EnumMember(Value = "College")]
        College,
        [EnumMember(Value = "Graduate Studies")]
        GraduateStudies
    }
}