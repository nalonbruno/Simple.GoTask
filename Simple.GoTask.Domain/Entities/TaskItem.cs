using Simple.GoTask.Domain.Enumerators;

namespace Simple.GoTask.Domain.Entities;

public sealed class TaskItem : BaseEntity
{
    public string Description { get; set; }
    public DateTime? Date { get; set; }
    public TaskItemStatus? Status { get; set; }
}
