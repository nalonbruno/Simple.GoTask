using FluentValidation;

namespace Simple.GoTask.Application.UseCases.DeleteTaskItem;

public sealed class DeleteTaskItemValidator : AbstractValidator<DeleteTaskItemRequest>
{
    public DeleteTaskItemValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}

