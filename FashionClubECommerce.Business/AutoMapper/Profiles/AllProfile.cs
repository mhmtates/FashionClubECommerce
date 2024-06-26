﻿using AutoMapper;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.Entities.Dto.DtoAutoBasket;
using FashionClubECommerce.Entities.Dto.DtoCategory;
using FashionClubECommerce.Entities.Dto.DtoCustomer;
using FashionClubECommerce.Entities.Dto.DtoOrder;
using FashionClubECommerce.Entities.Dto.DtoOrderDetail;
using FashionClubECommerce.Entities.Dto.DtoOrderInformation;
using FashionClubECommerce.Entities.Dto.DtoOrderNote;
using FashionClubECommerce.Entities.Dto.DtoProduct;
using FashionClubECommerce.Entities.Dto.DtoProductImage;
using FashionClubECommerce.Entities.Dto.DtoSlide;
using FashionClubECommerce.Entities.Dto.DtoTemporaryBasket;
using FashionClubECommerce.Entities.Dto.DtoUserAdmin;
using FashionClubECommerce.Entities.Dto.DtoVariant;

namespace FashionClubECommerce.Business.AutoMapper.Profiles
{
    public class AllProfile : Profile
    {
        public AllProfile()
        {
            CreateMap<ProductsUpdateDto, Products>(); 
            CreateMap<Products, ProductsUpdateDto>(); 
            CreateMap<Products, ProductsDto>(); 
            CreateMap<ProductImagesDto, ProductImages>(); 
            CreateMap<ProductImages, ProductImagesDto>(); 
            CreateMap<VariantsDto, Variants>(); 
            CreateMap<Variants, VariantsDto>(); 
            CreateMap<CategoriesDto, Categories>(); 
            CreateMap<Categories, CategoriesDto>(); 
            CreateMap<CustomersUpdateDto, Customers>(); 
            CreateMap<Customers, CustomersUpdateDto>(); 
            CreateMap<Customers, CustomersDto>(); 
            CreateMap<OrdersUpdateDto, Orders>(); 
            CreateMap<Orders, OrdersUpdateDto>(); 
            CreateMap<Orders, OrdersDto>(); 
            CreateMap<OrderDetailsDto, OrderDetails>(); 
            CreateMap<OrderDetails, OrderDetailsDto>(); 
            CreateMap<OrderInformationsDto, OrderInformations>(); 
            CreateMap<OrderInformations, OrderInformationsDto>(); 
            CreateMap<OrderNotesDto, OrderNotes>(); 
            CreateMap<OrderNotes, OrderNotesDto>(); 
            CreateMap<TemporaryBasketsDto, TemporaryBaskets>(); 
            CreateMap<TemporaryBaskets, TemporaryBasketsDto>(); 
            CreateMap<UsersAdminDto, UsersAdmin>(); 
            CreateMap<UsersAdmin, UsersAdminDto>(); 
            CreateMap<Orders, OrdersUpdateListDto>(); 
            CreateMap<OrdersUpdateListDto, Orders>(); 
            CreateMap<AutoBaskets, AutoBasketsDto>(); 
            CreateMap<AutoBasketsDto, AutoBaskets>();
            CreateMap<SlidesDto, Slides>();
            CreateMap<Slides, SlidesDto>();
        }
    }
}
