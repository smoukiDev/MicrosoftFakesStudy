using MSFakesStudy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MSFakesStudy.Controllers
{
    public class GoodsController : ApiController
    {
        private readonly IShoppingService _service;

        public GoodsController()
        {
            _service = new ShoppingService();
        }

        [Route("api/goods/{name}")]
        [HttpGet]
        public IHttpActionResult GetByName(string name)
        {
            var result = _service.GetGoodsByName(name);
            return this.Ok(result);
        }
    }
}
