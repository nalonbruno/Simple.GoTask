using AutoMapper;
using Simple.GoTask.Domain.Entities;

namespace Simple.GoTask.Application.UseCases.DeleteTaskItem;
public sealed class DeleteTaskItemMapper : Profile
{
    public DeleteTaskItemMapper()
    {
        CreateMap<DeleteTaskItemRequest, TaskItem>();
        CreateMap<TaskItem, DeleteTaskItemResponse>();
    }
}