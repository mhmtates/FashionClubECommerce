using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    class OrdersRepository : EfEntityRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        {

        }
    }
}