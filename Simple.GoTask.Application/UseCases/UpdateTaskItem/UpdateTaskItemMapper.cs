using AutoMapper;
using Simple.GoTask.Domain.Entities;

namespace Simple.GoTask.Application.UseCases.UpdateTaskItem;

public sealed class UpdateTaskItemMapper : Profile
{
    public UpdateTaskItemMapper()
    {
        CreateMap<UpdateTaskItemRequest, TaskItem>();
        CreateMap<TaskItem, UpdateTaskItemResponse>();
    }
}
