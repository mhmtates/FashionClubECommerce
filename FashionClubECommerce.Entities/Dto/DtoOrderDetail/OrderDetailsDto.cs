﻿using FashionClubECommerce.Core.Entitiess.Abstract;

namespace FashionClubECommerce.Entities.Dto.DtoOrderDetail
{
    public class OrderDetailsDto : IDto
    {
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string VariantName { get; set; }
        public int OrdersId { get; set; }
    }
}
