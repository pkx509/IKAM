using DSG.IKAM.BAL.Interfaces;
using DSG.IKAM.SHARED.Dto;
using DSG.IKAM.SHARED.Http;
using System;
using System.Collections.Generic;

namespace DSG.IKAM.BAL.Implements
{
    public class BrandService : IBrandService
    {

        internal static BrandService CreateInstant()
        {
            return new BrandService();
        }

        public IEnumerable<BrandDto> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public BrandDto GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        private void Validation(BrandDto model)
        {
            if (model == null)
                throw new Exception("Invalid");
        }

        public Response<BrandDto> Create(BrandDto model)
        {
            try
            {
                this.Validation(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }

        public Response<BrandDto> Edit(BrandDto model)
        {
            throw new NotImplementedException();
        }

        public Response<BrandDto> Remove(BrandDto model)
        {
            throw new NotImplementedException();
        }

    }
}
