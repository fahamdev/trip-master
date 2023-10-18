using MediatR;

namespace Application.Features.Categories.Commands.DeleteCategory
{
    internal class DeleteCategoryCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
