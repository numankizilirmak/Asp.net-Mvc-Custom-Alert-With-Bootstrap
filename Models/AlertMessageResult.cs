using MvcCustomAlertWithBootstrap.Enums;

namespace MvcCustomAlertWithBootstrap.Models
{
    public class AlertMessageResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public MessageVerbosityLevelEnum Verbosity { get; set; }
    }
}