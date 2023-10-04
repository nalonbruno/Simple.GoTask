using Simple.GoTask.Domain.Entities;
using Simple.GoTask.Domain.Interfaces;
using Simple.GoTask.Persistence.Context;

namespace Simple.GoTask.Persistence.Repositories;

public class TaskItemRepository : BaseRepository<TaskItem>, ITaskItemRepository
{
	public TaskItemRepository(AppDbContext context) : base(context)
	{

	}


}
