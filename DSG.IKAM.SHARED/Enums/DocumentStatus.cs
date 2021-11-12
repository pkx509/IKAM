using System.Runtime.Serialization;

namespace DSG.IKAM.SHARED.Enums
{
    [DataContract(Name = "DocumentStatus")]
    public enum DocumentStatus
    {
        [EnumMember(Value = "NONE")] NONE = 0,
        [EnumMember(Value = "DRAFT")] DRAFT = 1,
        [EnumMember(Value = "APPROVAL")] APPROVAL = 2,
        [EnumMember(Value = "REVIEW")] REVIEW = 3,
        [EnumMember(Value = "COMPLETED")] COMPLETED = 4,
        [EnumMember(Value = "REVISED")] REVISED = 5,
        [EnumMember(Value = "CANCELLED")] CANCELLED = -1,
    }
}
