using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class OrderDetailsRepository : EfEntityRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(DbContext context) : base(context)
        {

        }
    }
}