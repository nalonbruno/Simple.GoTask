using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple.GoTask.Application.UseCases.CreateTaskItem;

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

	[HttpPost]
	public async Task<ActionResult<CreateTaskItemResponse>> Create(CreateTaskItemRequest request, CancellationToken cancellationToken)
	{
		var response = await _mediator.Send(request, cancellationToken);
		return Ok(response);
	}
}
