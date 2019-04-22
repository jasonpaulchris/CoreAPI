using CoreAPI.Business.Interfaces;
using CoreAPI.Business.Managers;
using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class StoresController : Controller

    {
        private readonly IStoreManager _storeManager;
        public StoresController(IStoreManager storeManager)
        {
            _storeManager = storeManager;
        }

        [HttpGet]
        public IEnumerable<StoreModel> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Id")]
        public IActionResult Get(Guid id)
        {
            HttpModelResult modelResult = _storeManager.Get(id);
            if (modelResult.HttpStatus == HttpStatusCode.OK)
            {
                StoreModel storeModel = modelResult.Model as StoreModel;
                return Ok(storeModel);
            }

            switch (modelResult.HttpStatus)
            {
                case HttpStatusCode.NotFound:
                    return HttpNotFound();
            }

            return HttpBadRequest();
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody]StoreModel model)
        {
            HttpModelResult modelResult = _storeManager.Add(model);
            if (modelResult.HttpStatus == HttpStatusCode.Created)
            {
                return new CreatedResult(
                    string.Format("/api/stores/[0]",
                    modelResult.Model.Id),
                    modelResult.Model);
            }
            return new HttpStatusCodeResult((int)modelResult.HttpStatus);
        }

        [HttpPut("Id")]
        public void Put(Guid id, [FromBody]StoreModel model)
        {

        }

        [HttpDelete("Id")]
        public void Delete(int id)
        {

        }

    }
}