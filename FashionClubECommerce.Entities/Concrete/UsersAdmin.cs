﻿using FashionClubECommerce.Core.Entitiess.Abstract;

namespace FashionClubECommerce.Entities.Concrete
{
    public class UsersAdmin:IEntity
    {
        public int Id { get; set; }
        public string NameSurName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Roles { get; set; }
    }
}
