using Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.DeleteCategory
{
    internal class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToDelete = await _categoryRepository.GetByIdAsync(request.Id);

            if (categoryToDelete == null)
                throw new Exceptions.NotFoundException(typeof(Category).Name, request.Id);

            await _categoryRepository.DeleteAsync(categoryToDelete);

            return Unit.Value;
        }
    }
}
