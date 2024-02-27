using System.Runtime.Serialization;

namespace Core.Entities.Settings
{
    public enum AttendanceSetupCategory
    {
        [EnumMember(Value = "Teaching")]
        Teaching,
        [EnumMember(Value = "Non Teaching")]
        NonTeaching
    }
}