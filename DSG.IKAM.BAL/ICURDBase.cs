using DSG.IKAM.SHARED.Http;
using System.Collections.Generic;

namespace DSG.IKAM.BAL
{
    public interface ICURDBase<TDto>
    {
        IEnumerable<TDto> GetAll();
        TDto GetByCode(string code);
        Response<TDto> Create(TDto model);
        Response<TDto> Edit(TDto model);
        Response<TDto> Remove(TDto model);
    }
}
