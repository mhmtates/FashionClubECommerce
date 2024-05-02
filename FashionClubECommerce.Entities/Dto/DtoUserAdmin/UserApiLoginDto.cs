using FashionClubECommerce.Core.Entitiess.Abstract;

namespace FashionClubECommerce.Entities.Dto.DtoUserAdmin
{
    public class UserApiLoginDto : IDto
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
