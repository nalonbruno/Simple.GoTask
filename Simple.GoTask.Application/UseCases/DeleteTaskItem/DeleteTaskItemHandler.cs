using AutoMapper;
using MediatR;
using Simple.GoTask.Domain.Interfaces;

namespace Simple.GoTask.Application.UseCases.DeleteTaskItem;
public class DeleteTaskItemHandler : IRequestHandler<DeleteTaskItemRequest, DeleteTaskItemResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskItemRepository _taskItemRepository;
    private readonly IMapper _mapper;

    public DeleteTaskItemHandler(IUnitOfWork unitOfWork, ITaskItemRepository taskItemRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _taskItemRepository = taskItemRepository;
        _mapper = mapper;
    }
    public async Task<DeleteTaskItemResponse> Handle(DeleteTaskItemRequest command, CancellationToken cancellationToken)
    {
        var taskItem = await _taskItemRepository.Get(command.Id, cancellationToken);

        if (taskItem is null) return default;

        _taskItemRepository.Delete(taskItem);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteTaskItemResponse>(taskItem);
    }
}

