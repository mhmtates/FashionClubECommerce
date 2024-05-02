using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class UsersAdminRepository : EfEntityRepository<UsersAdmin>, IUsersAdminRepository
    {
        public UsersAdminRepository(DbContext context) : base(context)
        {

        }
    }
}

