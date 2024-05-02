using FashionClubECommerce.Core.Entitiess.Abstract;

namespace FashionClubECommerce.Entities.Dto.DtoSlide
{
    public class SlidesDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

    }
}
