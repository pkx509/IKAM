using System.Runtime.Serialization;

namespace DSG.IKAM.SHARED.Enums
{
    [DataContract(Name = "ConditionType")]
    public enum ConditionType
    {
        [EnumMember(Value = "NONE")] NONE = 0,
        [EnumMember(Value = "PLANNING")] PLANNING = 1,
        [EnumMember(Value = "ACTUAL")] ACTUAL = 2,
    }
}
