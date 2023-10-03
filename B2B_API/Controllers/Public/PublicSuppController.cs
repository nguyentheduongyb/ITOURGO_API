using B2B.Bus.CM;
using B2B.Dat.SL;
using B2B.Ent.CM;
using B2B.Ent.SL;
using B2B_API.App_Start;
using B2B_API.Filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers.Public
{
    [RoutePrefix("api/public/supplier")]
    public class PublicSuppController : ApiController
    {

        [HttpPost]
        [Route("GetListSupplierForHotelByPUB")]
        public HttpResponseMessage GetListSupplierForHotelByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListSupplierMappingPriceForHotelByPUB")]
        public HttpResponseMessage GetListSupplierMappingPriceForHotelByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDirectorySearchingForSuppByAgent")]
        public HttpResponseMessage GetListDirectorySearchingForSuppByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierForHotelByAgent")]
        public HttpResponseMessage GetListSupplierForHotelByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrderBookingForSupByHotel")]
        public HttpResponseMessage AddOrderBookingForSupByHotel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierMappingPriceForHotelByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForHotelByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListSupplierChildAge")]
        public HttpResponseMessage GetListSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListSurchargeDateForAgent")]
        public HttpResponseMessage GetListSurchargeDateForAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierImageFile")]
        public HttpResponseMessage GetListSupplierImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItemTypeDetailByAgent")]
        public HttpResponseMessage GetListItemTypeDetailByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPaymentTerm")]
        public HttpResponseMessage GetListSupplierPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListSupplierCancellationPolicy")]
        public HttpResponseMessage GetListSupplierCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListFoc")]
        public HttpResponseMessage GetListFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListLinkSupplierChildAge")]
        public HttpResponseMessage GetListLinkSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPolicyNotes")]
        public HttpResponseMessage GetListPolicyNotes(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPriceList")]
        public HttpResponseMessage GetListPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListPriceListForCompany")]
        public HttpResponseMessage GetListPriceListForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeByAgent")]
        public HttpResponseMessage GetListItemTypeByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
    }

}
