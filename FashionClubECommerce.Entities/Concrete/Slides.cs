using FashionClubECommerce.Core.Entitiess.Abstract;


namespace FashionClubECommerce.Entities.Concrete
{
  public class Slides:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        public string Image { get; set; }



    }
}
