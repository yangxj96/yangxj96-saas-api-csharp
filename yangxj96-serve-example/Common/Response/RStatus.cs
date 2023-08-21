using System.ComponentModel;

namespace yangxj96_serve_example.Common.Response;

public enum RStatus
{
    [Description("success")] Success = 0,

    [Description("failure")] Failure = -1
}