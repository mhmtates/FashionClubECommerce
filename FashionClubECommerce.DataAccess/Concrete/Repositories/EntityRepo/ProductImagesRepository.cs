using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.DataAccess.Abstract;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class ProductImagesRepository : EfEntityRepository<ProductImages>, IProductImagesRepository
    {
        public ProductImagesRepository(DbContext context) : base(context)
        {

        }
    }
}
