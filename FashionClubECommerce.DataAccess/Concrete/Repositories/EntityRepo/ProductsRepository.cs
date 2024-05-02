using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class ProductsRepository : EfEntityRepository<Products>, IProductsRepository
    {
        public ProductsRepository(DbContext context) : base(context)
        {

        }

    }
}
