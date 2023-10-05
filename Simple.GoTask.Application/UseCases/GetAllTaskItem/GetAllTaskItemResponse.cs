using Simple.GoTask.Domain.Enumerators;

namespace Simple.GoTask.Application.UseCases.GetAllTaskItem;

public sealed record GetAllTaskItemResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public DateTime? Date { get; set; }
    public TaskItemStatus Status { get; set; }
}
