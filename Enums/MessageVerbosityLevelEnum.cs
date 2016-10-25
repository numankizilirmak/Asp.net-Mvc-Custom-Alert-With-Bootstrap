using System.ComponentModel;

namespace MvcCustomAlertWithBootstrap.Enums
{
    public enum MessageVerbosityLevelEnum
    {
        [Description("alert alert-success")]
        Success,
        [Description("alert alert-danger")]
        Error,
        [Description("alert alert-warning")]
        Warning,
        [Description("alert alert-info")]
        Info
    }
}