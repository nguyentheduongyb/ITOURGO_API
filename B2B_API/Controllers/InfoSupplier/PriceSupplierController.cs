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
namespace B2B_API.Controllers.InfoSupplier
{
    [Authorize]
    [RoutePrefix("api/infosupp/price")]
    public class PriceSupplierController : ApiController
    {
        [HttpPost]
        [Route("GetListPriceSeason")]
        public HttpResponseMessage GetListPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceSeason")]
        public HttpResponseMessage AddPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceSeason")]
        public HttpResponseMessage UpdPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceSeason")]
        public HttpResponseMessage DelPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceListLinkForHT")]
        public HttpResponseMessage GetListPriceListLinkForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceItemForHT")]
        public HttpResponseMessage AddPriceItemForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceItemForHT")]
        public HttpResponseMessage UpdPriceItemForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierMappingPrice")]
        public HttpResponseMessage GetListSupplierMappingPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceListLinkForBT")]
        public HttpResponseMessage GetListPriceListLinkForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceItemForBT")]
        public HttpResponseMessage AddPriceItemForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceItemForBT")]
        public HttpResponseMessage UpdPriceItemForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

    }
}
