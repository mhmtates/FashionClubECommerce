using FashionClubECommerce.Entities.Dto;
using FashionClubECommerce.Entities.Dto.DtoCategory;
using FashionClubECommerce.Entities.Dto.DtoProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionClubECommerce.WebUI.Models
{
    public class ProductCategoryViewModel
    {
        public int Type { get; set; }
        public ProductsDto Product { get; set; }
        public CategoriesDto Category { get; set; }
    }
}
