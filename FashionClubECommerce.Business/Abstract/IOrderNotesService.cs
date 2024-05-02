using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoOrderNote;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IOrderNotesService
    {
        // OrderNote Listelene Bilmesi için, Bağlı olduğu Sipariş Gösterilmek zorunda.


        // B tablosu listeneceği zaman A tablosuda  gösterilmek zorundaysa böyle bir durum kullanırız.

        IDataResult<IList<OrderNotesDto>> GetAll(int id);
        IDataResult<OrderNotesDto> GetById(int Id);
        IResult Add(OrderNotesDto data);
        IResult Update(OrderNotesDto data);
        IResult Delete(int Id);
    }
}
