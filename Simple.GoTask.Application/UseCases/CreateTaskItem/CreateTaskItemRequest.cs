using MediatR;
using Simple.GoTask.Domain.Enumerators;

namespace Simple.GoTask.Application.UseCases.CreateTaskItem;

public sealed record CreateTaskItemRequest(string Description, DateTime? Date, TaskItemStatus? Status) : 
    IRequest<CreateTaskItemResponse>
{
}
