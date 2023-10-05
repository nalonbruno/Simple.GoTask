using MediatR;

namespace Simple.GoTask.Application.UseCases.DeleteTaskItem;

public sealed record DeleteTaskItemRequest(Guid Id)
    : IRequest<DeleteTaskItemResponse>
{
}
