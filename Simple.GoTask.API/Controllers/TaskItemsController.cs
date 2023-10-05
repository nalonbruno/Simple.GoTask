using MediatR;
using Microsoft.AspNetCore.Mvc;
using Simple.GoTask.Application.UseCases.CreateTaskItem;
using Simple.GoTask.Application.UseCases.DeleteTaskItem;
using Simple.GoTask.Application.UseCases.GetAllTaskItem;
using Simple.GoTask.Application.UseCases.UpdateTaskItem;

namespace Simple.GoTask.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskItemsController : ControllerBase
{
    private readonly IMediator _mediator;

	public TaskItemsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async Task<ActionResult<List<GetAllTaskItemResponse>>>
		GetAll(CancellationToken cancellationToken)
	{
		var response = await _mediator.Send(new GetAllTaskItemRequest(), cancellationToken);
		return Ok(response);
	}

	[HttpPost]
	public async Task<ActionResult<CreateTaskItemResponse>> 
		Create(CreateTaskItemRequest request, CancellationToken cancellationToken)
	{
		var response = await _mediator.Send(request, cancellationToken);
		return Ok(response);
	}

	[HttpPut("{id}")]
	public async Task<ActionResult<UpdateTaskItemResponse>> 
		Update(Guid id, UpdateTaskItemRequest request, CancellationToken cancellationToken)
	{
		if (id != request.Id)
			return BadRequest();

		var response = await _mediator.Send(request, cancellationToken);
		return Ok(response);
	}

	[HttpDelete("{id}")]
	public async Task<ActionResult<DeleteTaskItemResponse>>
		Delete(Guid? id, CancellationToken cancellationToken)
	{
		if (id is null)
			return BadRequest();

		var deleteTaskItemRequest = new DeleteTaskItemRequest(id.Value);

		var response = await _mediator.Send(deleteTaskItemRequest, cancellationToken);
		return Ok(response);
	}
}
