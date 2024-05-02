using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    class OrderInformationsRepository : EfEntityRepository<OrderInformations>, IOrderInformationsRepository
    {
        public OrderInformationsRepository(DbContext context) : base(context)
        {

        }
    }
}