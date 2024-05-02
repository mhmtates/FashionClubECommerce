using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoVariant;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IVariantsService
    {
        IDataResult<IList<VariantsDto>> GetAll(int id);
        VariantsDto GetById(int Id);
        IResult Add(VariantsDto data);
        IResult Update(VariantsDto data);
        IResult Delete(int Id);
    }
}
