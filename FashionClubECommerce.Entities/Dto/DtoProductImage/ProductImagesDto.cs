using FashionClubECommerce.Core.Entitiess.Abstract;


namespace FashionClubECommerce.Entities.Dto.DtoProductImage
{
    public class ProductImagesDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsId { get; set; }
    }
}
