using Simple.GoTask.Domain.Enumerators;

namespace Simple.GoTask.Application.UseCases.CreateTaskItem;

public sealed record CreateTaskItemResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public DateTime? Date { get; set; }
    public TaskItemStatus Status { get; set; }
}
