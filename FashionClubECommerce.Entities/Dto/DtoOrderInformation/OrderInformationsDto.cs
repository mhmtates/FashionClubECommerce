﻿using FashionClubECommerce.Core.Entitiess.Abstract;
using System;

namespace FashionClubECommerce.Entities.Dto.DtoOrderInformation
{
    public class OrderInformationsDto : IDto
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public bool Sms { get; set; }
        public bool Email { get; set; }
        public string Message { get; set; }
        public DateTime InfoDate { get; set; }
        public int OrdersId { get; set; }
    }
}
