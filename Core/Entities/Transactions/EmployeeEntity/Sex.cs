using System.Runtime.Serialization;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public enum Sex
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female
    }
}