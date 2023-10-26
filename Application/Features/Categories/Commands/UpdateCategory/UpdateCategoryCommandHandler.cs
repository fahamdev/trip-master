using Application.Contracts.Persistence;
using Application.Features.Categories.Commands.UpdateCategory.Validators;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var categoryToUpdate = await _categoryRepository.GetByIdAsync(request.Id);
            if (categoryToUpdate == null)
                throw new Exceptions.NotFoundException(typeof(Category).Name, request.Id);

            categoryToUpdate.Name = request.Name;

            await _categoryRepository.UpdateAsync(categoryToUpdate);
            return Unit.Value;
        }
    }
}
