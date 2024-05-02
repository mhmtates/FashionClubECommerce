using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class TemporaryBasketsRepository : EfEntityRepository<TemporaryBaskets>, ITemporaryBasketsRepository
    {
        public TemporaryBasketsRepository(DbContext context) : base(context)
        {

        }
    }
}
