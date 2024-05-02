using FashionClubECommerce.Core.Entitiess.Abstract;
using System;

namespace FashionClubECommerce.Entities.Concrete
{
    public class OrderInformations:IEntity
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public bool Sms { get; set; }
        public bool Email { get; set; }
        public string Message { get; set; }
        public DateTime InfoDate { get; set; }
        public int OrdersId { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
