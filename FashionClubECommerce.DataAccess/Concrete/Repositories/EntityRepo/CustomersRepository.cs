using FashionClubECommerce.Core.DataRepository.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.DataAccess.Abstract;


namespace FashionClubECommerce.DataAccess.Concrete.Repositories.EntityRepo
{
    public class CustomersRepository : EfEntityRepository<Customers>, ICustomersRepository
    {
        // Bu kısımda Repository Sınıfımın Yapıcı Metot'una Parametre gönderiyoruz, yani veri tabanı Bağlantısını gönderiyoruz.
        public CustomersRepository(DbContext context) : base(context)
        {

        }
    }
}