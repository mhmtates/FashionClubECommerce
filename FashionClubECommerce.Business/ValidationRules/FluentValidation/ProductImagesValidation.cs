using FashionClubECommerce.Entities.Dto.DtoProductImage;
using FluentValidation;

namespace FashionClubECommerce.Business.ValidationRules.FluentValidation
{
    public class ProductImagesValidation : AbstractValidator<ProductImagesDto>
    {
        public ProductImagesValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.ProductsId).NotEmpty().WithMessage("Boş Bırakılamaz.");

            RuleFor(x => x.Name).MaximumLength(50).WithMessage("50 Karakterden Fazla Olamaz.");
        }
    }
}
