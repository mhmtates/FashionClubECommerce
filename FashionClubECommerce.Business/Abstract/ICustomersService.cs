using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoCustomer;

namespace FashionClubECommerce.Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<IList<CustomersDto>> GetAll();
        IDataResult<CustomersUpdateDto> GetById(int Id);
        IDataResult<CustomersDto> Login(string EMail,string Telefon,string Sifre);
        IResult Add(CustomersUpdateDto data);
        IResult Update(CustomersUpdateDto data);
        IResult Delete(int Id);
    }
}
