using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.DataAccess.Abstract;

namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    class OrderNotesRepository : EfEntityRepository<OrderNotes>, IOrderNotesRepository
    {
        public OrderNotesRepository(DbContext context) : base(context)
        {

        }
    }
}
