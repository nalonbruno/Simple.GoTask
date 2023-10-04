using AutoMapper;
using Simple.GoTask.Domain.Entities;

namespace Simple.GoTask.Application.UseCases.CreateTaskItem;

public sealed class CreateTaskItemMapper : Profile
{
	public CreateTaskItemMapper()
	{
		CreateMap<CreateTaskItemRequest, TaskItem>();
		CreateMap<TaskItem, CreateTaskItemResponse>();
	}
}
