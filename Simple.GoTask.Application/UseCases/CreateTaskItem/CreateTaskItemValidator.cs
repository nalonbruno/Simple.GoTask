using FluentValidation;

namespace Simple.GoTask.Application.UseCases.CreateTaskItem;

public sealed class CreateTaskItemValidator : AbstractValidator<CreateTaskItemRequest>
{
	public CreateTaskItemValidator()
	{
		RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
	}
}
