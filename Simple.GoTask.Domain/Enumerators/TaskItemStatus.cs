using System.ComponentModel;

namespace Simple.GoTask.Domain.Enumerators;

public enum TaskItemStatus
{
    [Description("Pending")]
    Pending = 1,
    [Description("Doing")]
    Doing = 2,
    [Description("Completed")]
    Completed = 3,
    [Description("Cancelled")]
    Cancelled = 4
}
