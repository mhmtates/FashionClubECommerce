using FashionClubECommerce.Core.Entitiess.Abstract;

namespace FashionClubECommerce.Entities.Dto.DtoCategory
{
    public class CategoriesDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool Status { get; set; }

    }
}
