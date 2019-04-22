using CoreAPI.Models;
using System;
using System.Web;

namespace CoreAPI.Business.Interfaces
{
    public interface IStoreManager
    {
        HttpModelResult Add(BaseModel model);
        HttpModelResult Update(BaseModel model, Guid id);
        HttpModelResult Get(Guid id);
        HttpModelResult Delete(Guid id);
        HttpModelResult GetAll();
    }
}
