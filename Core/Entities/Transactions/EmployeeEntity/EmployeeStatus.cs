using System.Runtime.Serialization;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public enum EmployeeStatus
    {
        [EnumMember(Value ="Applicant")]
        Applicant,
        [EnumMember(Value ="Employed")]
        Employed,
        [EnumMember(Value ="Re-Entry")]
        ReEntry,
        [EnumMember(Value ="Not Employed")]
        NotEmployed
    }
}