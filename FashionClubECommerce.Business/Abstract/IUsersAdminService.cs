using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoUserAdmin;

namespace FashionClubECommerce.Business.Abstract
{
    public interface IUsersAdminService
    {
        IDataResult<IList<UsersAdminDto>> GetAll();
        IDataResult<UsersAdminDto> GetById(int Id);
        IResult Add(UsersAdminDto data);
        IResult Update(UsersAdminDto data);
        IResult Delete(int Id);
        IDataResult<UsersAdminDto> Login(string Email,string Password);
    }
}
