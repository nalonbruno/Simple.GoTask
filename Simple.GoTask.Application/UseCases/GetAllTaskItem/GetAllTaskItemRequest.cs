using MediatR;

namespace Simple.GoTask.Application.UseCases.GetAllTaskItem;

public sealed record GetAllTaskItemRequest:
    IRequest<List<GetAllTaskItemResponse>>
{
}