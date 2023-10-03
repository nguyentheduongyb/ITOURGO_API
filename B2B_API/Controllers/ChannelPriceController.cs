using B2B_API.App_Start;
using B2B_API.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using B2B.Dat.SL;
using B2B.Bus.SL;
using B2B.Ent.SL;
using System.Data;
namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/channelprice")]
    public class ChannelPriceController : ApiController
    {
        [HttpPost]
        [Route("AddChannelPrice")]
        public HttpResponseMessage AddChannelPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannelPrice(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListChannelPrice")]
        public HttpResponseMessage GetListChannelPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannelPrice(ent.strJson)));
        }
    }
}
