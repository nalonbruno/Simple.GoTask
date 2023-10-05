using AutoMapper;
using Simple.GoTask.Domain.Entities;

namespace Simple.GoTask.Application.UseCases.GetAllTaskItem;
public sealed class GetAllTaskItemMapper : Profile
{
    public GetAllTaskItemMapper()
    {
        CreateMap<TaskItem, GetAllTaskItemResponse>();
    }
}
