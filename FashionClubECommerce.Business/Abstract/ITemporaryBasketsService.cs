using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoAutoBasket;
using FashionClubECommerce.Entities.Dto.DtoTemporaryBasket;

namespace FashionClubECommerce.Business.Abstract
{
    public interface ITemporaryBasketsService
    {
        IDataResult<IList<TemporaryBasketsDto>> GetAll(int CookiesID);
        IDataResult<TemporaryBasketsDto> GetById(int Id);
        IResult SepetArttirEksilt(int Id,bool islem);
        IResult AddUpdate(int ProductId,int CookiesId,int[] variantIds);
        IResult Delete(int Id);
        IResult AutoBasketUpdate(AutoBasketsDto data);
        IDataResult<AutoBasketsDto> GetByIdAuto(int Id);
    }
}
