using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoOrderInformation;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IOrderInformationsService
    {
        IDataResult<IList<OrderInformationsDto>> GetAll();
        IDataResult<OrderInformationsDto> GetById(int Id);
        IResult Add(OrderInformationsDto data);
        IResult Update(OrderInformationsDto data);
        IResult Delete(int Id);
    }
}
