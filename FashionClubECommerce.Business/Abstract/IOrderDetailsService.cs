using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoOrderDetail;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IOrderDetailsService
    {

        // Orders => detail,Note,info
        IDataResult<IList<OrderDetailsDto>> GetAll(int id);
        OrderDetailsDto GetById(int Id);
        IResult Add(OrderDetailsDto data);
        IResult Update(OrderDetailsDto data);
        IResult Delete(int Id);
    }
}
