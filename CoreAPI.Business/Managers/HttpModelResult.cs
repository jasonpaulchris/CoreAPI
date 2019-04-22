using CoreAPI.Models;
using System.Collections.Generic;
using System.Net;

namespace CoreAPI.Business.Managers
{
    public class HttpModelResult
    {
        public HttpStatusCode HttpStatus { get; set; }
        public BaseModel Model { get; set; }
        public IEnumerable<BaseModel> Models { get; set; }
    }
}
