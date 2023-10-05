using AutoMapper;
using MediatR;
using Simple.GoTask.Domain.Interfaces;

namespace Simple.GoTask.Application.UseCases.UpdateTaskItem;

public class UpdateTaskItemHandler : IRequestHandler<UpdateTaskItemRequest, UpdateTaskItemResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskItemRepository _taskItemRepository;
    private readonly IMapper _mapper;

    public UpdateTaskItemHandler(IUnitOfWork unitOfWork, ITaskItemRepository taskItemRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _taskItemRepository = taskItemRepository;
        _mapper = mapper;
    }
    public async Task<UpdateTaskItemResponse> Handle(UpdateTaskItemRequest command, CancellationToken cancellationToken)
    {
        var taskItem = await _taskItemRepository.Get(command.Id, cancellationToken);

        if (taskItem is null) return default;

        taskItem.Description = command.Description;
        taskItem.Status = command.Status;
        taskItem.Date = command.Date;

        _taskItemRepository.Update(taskItem);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateTaskItemResponse>(taskItem);
    }
}
