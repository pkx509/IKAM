using System.Runtime.Serialization;

namespace DSG.IKAM.SHARED.Enums
{
    [DataContract(Name = "MessageType")]
    public enum MessageType
    {
        [EnumMember(Value = "error")] ERROR = -1,
        [EnumMember(Value = "info")] INFORMATION = 0,
        [EnumMember(Value = "success")] SUCCESS = 1,
        [EnumMember(Value = "warning")] WARNING = 2,
    }
}
