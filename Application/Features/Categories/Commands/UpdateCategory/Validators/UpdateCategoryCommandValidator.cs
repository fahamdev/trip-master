using FluentValidation;

namespace Application.Features.Categories.Commands.UpdateCategory.Validators
{
    internal class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(3).WithMessage("{PropertyName} must be atleast 3 characters.")
                .MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters.");
        }
    }
}
