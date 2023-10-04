using AutoMapper;
using MediatR;
using Simple.GoTask.Domain.Entities;
using Simple.GoTask.Domain.Interfaces;

namespace Simple.GoTask.Application.UseCases.CreateTaskItem;

public class CreateTaskItemHandler : IRequestHandler<CreateTaskItemRequest, CreateTaskItemResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITaskItemRepository _taskItemRepository;
    private readonly IMapper _mapper;

    public CreateTaskItemHandler(IUnitOfWork unitOfWork, ITaskItemRepository taskItemRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _taskItemRepository = taskItemRepository;
        _mapper = mapper;
    }
    public async Task<CreateTaskItemResponse> Handle(CreateTaskItemRequest request, CancellationToken cancellationToken)
    {
        var taskItem = _mapper.Map<TaskItem>(request);
        _taskItemRepository.Create(taskItem);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateTaskItemResponse>(taskItem);
    }
}
