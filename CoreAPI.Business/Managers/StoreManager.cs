using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAPI.Business.Managers
{
    public class StoreManager
    {
        public HttpModelResult Get(Guid id)
        {
            HttpModelResult result = new HttpModelResult();
            BaseDto dto = _dataStore.Get(id);
            if (dto == null)
            {
                result.HttpStatus == System.Net.HttpStatusCode.NotFound;
            }
            else
            {
                result.HttpStatus = System.Net.HttpStatusCode.OK;
                result.Model = _mapper.Map<StoreModel>(dto);
            }
            return result;
        }
    }
}
