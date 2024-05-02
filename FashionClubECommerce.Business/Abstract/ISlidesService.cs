using FashionClubECommerce.Core.Results.Abstract;
using FashionClubECommerce.Entities.Dto.DtoSlide;

namespace FashionClubECommerce.Business.Abstract
{
    public interface ISlidesService
    {
        IDataResult<IList<SlidesDto>> GetAll();
        IDataResult<SlidesDto> GetById(int Id);
        IResult Add(SlidesDto data);
        IResult Update(SlidesDto data);
        IResult Delete(int Id);
    }
}
