﻿using FashionClubECommerce.Business.Abstract;
using FashionClubECommerce.Entities.Dto;
using FashionClubECommerce.Entities.Dto.DtoProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FashionClubECommerce.WebAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService db;
        public ProductsController(IProductsService _db)
        {
            db = _db;
        }
        [HttpGet]
        public IList<ProductsDto> Get()
        {
            return db.GetAll().Data;
        }
        [HttpGet("GetyById/{Id}")]
        public ProductsUpdateDto GetyById(int Id)
        {
            return db.GetById(Id).Data;
        }
        [HttpGet("FiyatinaGore/{Sart}")]
        public IList<ProductsDto> FiyatinaGore(bool Sart)
        {
            if (Sart) // true yada false
            {
                return db.GetAll().Data.OrderBy(x => x.Price).ToList();
            }
            else
            {
                return db.GetAll().Data.OrderByDescending(x => x.Price).ToList();
            }
        }
    }
}
