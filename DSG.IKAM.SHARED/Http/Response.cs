using DSG.IKAM.SHARED.Enums;

namespace DSG.IKAM.SHARED.Http
{
    public class Response
    {
        public bool Success { get; set; } = false;
        public MessageType MessageType { get; set; } = MessageType.ERROR;
    }
}
