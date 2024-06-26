﻿using AutoMapper;
using FashionClubECommerce.Business.Abstract;
using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Core.Results.ComplexTypes;
using FashionClubECommerce.Core.Results.Concrete;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.Entities.Dto.DtoProduct;

namespace FashionClubECommerce.Business.Concrete
{


    public class ProductsManager : IProductsService
    {
        private readonly IUnitOfWorks works;
        private readonly IMapper mapper;

        public ProductsManager(IUnitOfWorks _works, IMapper _mapper)
        {
            works = _works;
            mapper = _mapper;
        }
        public IResult Add(ProductsUpdateDto data)
        {
            
            var Donusturulen = mapper.Map<Products>(data);
            works.ProductsRepository.Add(Donusturulen);
            works.SaveChanges();
            return new Result(ResultStatus.Success, "Kayıt Başarılı");
        }

        public IResult Delete(int Id)
        {
            works.ProductsRepository.Delete(works.ProductsRepository.GetByIdFirst(x => x.Id == Id));
            works.SaveChanges();
            return new Result(ResultStatus.Success, "Kayıt Silindi");
        }

        public IResult DeleteImages(int Id)
        {
            works.ProductImagesRepository.Delete(works.ProductImagesRepository.GetByIdFirst(x => x.Id == Id));
            works.SaveChanges();
            return new Result(ResultStatus.Success, "Resim Silindi");
        }
        public IDataResult<IList<ProductsDto>> GetAll()
        {
            IList<ProductsDto> products = new List<ProductsDto>();
            foreach (var item in works.ProductsRepository.GetAll())
            {
                products.Add(mapper.Map<ProductsDto>(item));
            }
            if (products.Count > 0)
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Success, products.Count() + " Kayıt Listelendi.", products);
            }
            else
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Info, "Kayıt Bulunamadı", null);
            }
        }
        public IDataResult<IList<ProductsDto>> KategoriyeGoreUrunGetirme(int CategoryId)
        {
            IList<ProductsDto> products = new List<ProductsDto>();
            foreach (var item in works.ProductsRepository.GetAll(x=> x.CategoriesId == CategoryId))
            {
                products.Add(mapper.Map<ProductsDto>(item));
            }
            if (products.Count > 0)
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Success, products.Count() + " Kayıt Listelendi.", products);
            }
            else
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Info, "Kayıt Bulunamadı", null);
            }
        }

        public IDataResult<IList<ProductsDto>> GetAllKampanya()
        {
            IList<ProductsDto> products = new List<ProductsDto>();
            foreach (var item in works.ProductsRepository.GetAll(x => x.Price>x.Discount))
            {
                products.Add(mapper.Map<ProductsDto>(item));
            }
            if (products.Count > 0)
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Success, products.Count() + " Kayıt Listelendi.", products);
            }
            else
            {
                return new DataResult<IList<ProductsDto>>(ResultStatus.Info, "Kayıt Bulunamadı", null);
            }
        }

        public IDataResult<ProductsUpdateDto> GetById(int Id)
        {
            var data = works.ProductsRepository.GetByIdFirst(x => x.Id == Id);
            if (data != null)
            {
                var AutoData = mapper.Map<ProductsUpdateDto>(data);
                return new DataResult<ProductsUpdateDto>(ResultStatus.Success, "1 Kayıt Getirildi.", AutoData);
            }
            else
            {
                return new DataResult<ProductsUpdateDto>(ResultStatus.Info, "Kayıt Bulunamadı.", null);
            }
        }
        public IDataResult<int> SearchId(string Name, decimal Price, int Stock)
        {
            var data = works.ProductsRepository.GetByIdFirst(x => x.Name == Name && x.Stock == Stock && x.Price == Price);
            if (data != null)
            {
                return new DataResult<int>(ResultStatus.Success, "1 Kayıt Getirildi.", data.Id);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Info, "Kayıt Bulunamadı.", 0);
            }
        }
        //public static string URLFile = @"C:\Users\Mehmet\Desktop\Projeler\FashionECommerce\FashionClubECommerce.WebUI";
        public IResult Update(ProductsUpdateDto data)
        {
            var Getdata = mapper.Map<Products>(data);
            works.ProductsRepository.Update(Getdata);
            works.SaveChanges();
            return new Result(ResultStatus.Success, "Güncelleme Başarılı");
        }

        public IDataResult<IList<ProductsDto>> Search(string Keywords)
        {
            var data =  works.ProductsRepository.GetAll().Where(f => f.Keywords.Contains(Keywords) || f.Keywords.ToLower().Contains(Keywords.ToLower()) ||f.Keywords.ToUpper().Contains(Keywords.ToUpper())).Take(5);
            return new DataResult<IList<ProductsDto>>(ResultStatus.Success, "Kayıtlar getirildi", mapper.Map<IList<ProductsDto>>(data));
        }
       
    }
}
