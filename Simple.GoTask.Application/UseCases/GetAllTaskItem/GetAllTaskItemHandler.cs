using AutoMapper;
using MediatR;
using Simple.GoTask.Domain.Interfaces;

namespace Simple.GoTask.Application.UseCases.GetAllTaskItem;

public sealed class GetAllTaskItemHandler : IRequestHandler<GetAllTaskItemRequest, List<GetAllTaskItemResponse>>
{
    private readonly ITaskItemRepository _taskItemRepository;
    private readonly IMapper _mapper;

    public GetAllTaskItemHandler(ITaskItemRepository taskItemRepository, IMapper mapper)
    {
        _taskItemRepository = taskItemRepository;
        _mapper = mapper;
    }
    public async Task<List<GetAllTaskItemResponse>> Handle(GetAllTaskItemRequest request, CancellationToken cancellationToken)
    {
        var tasks = await _taskItemRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllTaskItemResponse>>(tasks);
    }
}
