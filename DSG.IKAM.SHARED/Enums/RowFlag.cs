using System.Runtime.Serialization;

namespace DSG.IKAM.SHARED.Enums
{
    [DataContract(Name = "RowFlag")]
    public enum RowFlag
    {
        [EnumMember(Value = "I")] INACTIVE = 0,
        [EnumMember(Value = "A")] ACTIVE = 1,
        [EnumMember(Value = "S")] MANUAL = 3,
    }
}
