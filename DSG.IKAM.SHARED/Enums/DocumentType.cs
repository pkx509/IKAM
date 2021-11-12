using System.Runtime.Serialization;

namespace DSG.IKAM.SHARED.Enums
{
    [DataContract(Name = "DocumentType")]
    public enum DocumentType
    {
        [EnumMember(Value = "NONE")] None = 0,
        [EnumMember(Value = "FC")] FIXED_CONTRACT = 1,
        [EnumMember(Value = "BP")] BUDGET_PLANNING = 2,
        [EnumMember(Value = "SF")] SALE_FORECAST = 3,
        [EnumMember(Value = "CM")] CLAIM = 4,
    }
}
