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
    [RoutePrefix("api/APIChannel")]
    public class APIChannelController : ApiController
    {
        [HttpPost]
        [Route("GetListAPIChannel")]
        public HttpResponseMessage GetListAPIChannel(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAPIChannel")]
        public HttpResponseMessage AddAPIChannel(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAPIChannel")]
        public HttpResponseMessage UpdAPIChannel(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAPIChannel")]
        public HttpResponseMessage DelAPIChannel(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        
        [HttpPost]
        [Route("GetListChannelItem")]
        public HttpResponseMessage GetListChannelItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        [HttpPost]
        [Route("AddChannelItem")]
        public HttpResponseMessage AddChannelItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdChannelItem")]
        public HttpResponseMessage UpdChannelItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        [HttpPost]
        [Route("DelChannelItem")]
        public HttpResponseMessage DelChannelItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdChannelParam")]
        public HttpResponseMessage UpdChannelParam(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }


        [HttpPost]
        [Route("DelChannelParam")]
        public HttpResponseMessage DelChannelParam(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionChannel(ent.strJson)));
        }
    }
}
