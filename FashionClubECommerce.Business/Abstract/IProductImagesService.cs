using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoProductImage;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IProductImagesService
    {
        IDataResult<IList<ProductImagesDto>> GetAll(int id);
        ProductImagesDto GetByIdFirst(int id);
        IResult Add(ProductImagesDto data);
        IResult Update(ProductImagesDto data);
        IResult Delete(int Id);
    }
}
