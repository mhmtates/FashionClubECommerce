using FashionClubECommerce.Core.Entitiess.Abstract;


namespace FashionClubECommerce.Entities.Concrete
{
    public class ProductImages:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsId { get; set; }
        public virtual Products Products { get; set; }
    }
}
