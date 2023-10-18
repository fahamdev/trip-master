namespace Application.Features.Categories.Queries.GetCategoriesList.DTOs
{
    public class CategoryListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
