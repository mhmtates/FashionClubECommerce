using FashionClubECommerce.Core.Entitiess.Abstract;
using System;

namespace FashionClubECommerce.Entities.Dto.DtoOrder
{
    public class OrdersDto : IDto
    {
        public int Id { get; set; } // Primary
        public int BasketId { get; set; } // Sipariş No
        public DateTime OrderDate { get; set; } // Sipariş Tarihi
        public string OrderStatus { get; set; } // Sipariş Durumu
        public decimal TotalPrice { get; set; } // Toplam Ücret
    }
}
