using MediatR;
using Simple.GoTask.Domain.Enumerators;

namespace Simple.GoTask.Application.UseCases.UpdateTaskItem;

public sealed record UpdateTaskItemRequest(Guid Id, 
    string Description, 
    DateTime? Date, 
    TaskItemStatus? Status) 
    : IRequest<UpdateTaskItemResponse>
{
}
