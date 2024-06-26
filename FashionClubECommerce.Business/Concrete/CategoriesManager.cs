﻿using AutoMapper;
using FashionClubECommerce.Business.Abstract;
using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Core.Results.ComplexTypes;
using FashionClubECommerce.Core.Results.Concrete;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.Entities.Concrete;
using FashionClubECommerce.Entities.Dto.DtoCategory;

namespace FashionClubECommerce.Business.Concrete
{
    public class CategoriesManager : ICategoriesService
    {
        // Readonyl Olarak Değişken tanımlandıysa, O değişkene sadece Yapıcı metot yardımıyla veri atılır.
        private readonly IUnitOfWorks works;
        private readonly IMapper mapper;

        public CategoriesManager(IUnitOfWorks _works, IMapper _mapper)
        {
            works = _works;
            mapper = _mapper;
        }

        public IResult Add(CategoriesDto data)
        {
            try
            {
                works.CategoriesRepository.Add(mapper.Map<Categories>(data));
                works.SaveChanges();
                return new Result(ResultStatus.Success, "Kayıt Başarılı.");
            }
            catch (Exception)
            {
                return new Result(ResultStatus.Error, "Kayıt Başarısız.");
            }
        }

        public IResult Delete(int Id)
        {
            try
            {
                works.CategoriesRepository.Delete(works.CategoriesRepository.GetByIdFirst(x => x.Id == Id));
                works.SaveChanges();
                return new Result(ResultStatus.Success, "Silme Başarılı");
            }
            catch (Exception)
            {
                return new Result(ResultStatus.Error, "Silme Başarısız");
            }
        }

        public IDataResult<IList<CategoriesDto>> GetAll(int Id)
        {
            IList<CategoriesDto> data = new List<CategoriesDto>();

            foreach (var item in works.CategoriesRepository.GetAll(x => x.ParentId == Id))
            {
                data.Add(mapper.Map<CategoriesDto>(item));
            }

            if (data.Count > 0)
            {
                return new DataResult<IList<CategoriesDto>>(ResultStatus.Success, data.Count + " Kayıt Listelendi", data);
            }
            else
            {
                return new DataResult<IList<CategoriesDto>>(ResultStatus.Info, "Kayıt Bulunamadı.", null);
            }
        }

        public IDataResult<CategoriesDto> GetById(int Id)
        {
            var data = works.CategoriesRepository.GetByIdFirst(x => x.Id == Id);
            if (data != null)
            {
                return new DataResult<CategoriesDto>(ResultStatus.Success, "1 Kayıt Getirildi.", mapper.Map<CategoriesDto>(data));
            }
            else
            {
                return new DataResult<CategoriesDto>(ResultStatus.Info, "Kayıt Bulunamadı", null);
            }
        }

        public IDataResult<IList<CategoriesDto>> Search(string term)
        {
            var data = works.CategoriesRepository.GetAll().Where(f => f.Name.Contains(term) || f.Name.ToLower().Contains(term.ToLower()) || f.Name.ToUpper().Contains(term.ToUpper())).Take(5);
            return new DataResult<IList<CategoriesDto>>(ResultStatus.Success, "Kayıtlar getirildi", mapper.Map<IList<CategoriesDto>>(data));
        }

        public IResult Update(CategoriesDto data)
        {
            try
            {
                var datam = mapper.Map<Categories>(data);
                works.CategoriesRepository.Update(datam);
                works.SaveChanges();

                return new Result(ResultStatus.Success, "Güncelleme Başarılı");
            }
            catch (Exception)
            {
                return new Result(ResultStatus.Error, "Güncelleme Başarısız");
            }
        }
    }
}
