using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoCategory;

namespace FashionClubECommerce.Business.Abstract
{
    public interface ICategoriesService
    {
        IDataResult<IList<CategoriesDto>> GetAll(int Id);
        IDataResult<CategoriesDto> GetById(int Id);
        IResult Add(CategoriesDto data);
        IResult Update(CategoriesDto data);
        IResult Delete(int Id);
        IDataResult<IList<CategoriesDto>> Search(string term);
    }
}
