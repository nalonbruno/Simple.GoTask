using FluentValidation;

namespace Simple.GoTask.Application.UseCases.UpdateTaskItem;

public sealed class UpdateTaskItemValidator : AbstractValidator<UpdateTaskItemRequest>
{
    public UpdateTaskItemValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Description).NotEmpty().MaximumLength(255);
    }
}
