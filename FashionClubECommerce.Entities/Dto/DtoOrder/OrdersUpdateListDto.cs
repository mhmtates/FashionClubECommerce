﻿using FashionClubECommerce.Core.Entitiess.Abstract;
using FashionClubECommerce.Entities.Dto.DtoCustomer;
using FashionClubECommerce.Entities.Dto.DtoOrderDetail;
using FashionClubECommerce.Entities.Dto.DtoOrderInformation;
using FashionClubECommerce.Entities.Dto.DtoOrderNote;
using System;
using System.Collections.Generic;


namespace FashionClubECommerce.Entities.Dto.DtoOrder
{
    public class OrdersUpdateListDto : IDto
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentType { get; set; }
        public string CargoNumber { get; set; }
        public int BasketId { get; set; }
        public decimal CargoPrice { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Kdv { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal CouponPrice { get; set; }
        public ICollection<OrderDetailsDto> OrderDetailsDto { get; set; }
        public ICollection<OrderNotesDto> OrderNotesDto { get; set; }
        public ICollection<OrderInformationsDto> OrderInformationsDto { get; set; }
        public CustomersUpdateDto CustomersUpdateDto { get; set; }
    }
}
