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
    [RoutePrefix("api/public/tour")]
    public class PublicTourController : ApiController
    {

        [HttpPost]
        [Route("GetListDestinationForTourByAgent")]
        public HttpResponseMessage GetListDestinationForTourByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCateByCompanyGUID")]
        public HttpResponseMessage GetListCateByCompanyGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourForHomeLMnt")]
        public HttpResponseMessage GetListTourForHomeLMnt(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListTourPublishInTopByPUB")]
        public HttpResponseMessage GetListTourPublishInTopByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListTourPublishInTopByPUB(ent)));
        }
        

        [HttpPost]
        [Route("GetListCompanyDestinationForHmPgTour")]
        public HttpResponseMessage GetListCompanyDestinationForHmPgTour(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListCompanyDestinationForHmPgTour(ent)));
        }


        [HttpPost]
        [Route("GetListTourPublishByPUB")]
        public HttpResponseMessage GetListTourPublishByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListTourPublishByPUB(ent)));
        }


        [HttpPost]
        [Route("GetDetailTourByPUB")]
        public HttpResponseMessage GetDetailTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetDetailTourByPUB(ent)));
        }


        [HttpPost]
        [Route("GetListTourDayByPtn")]
        public HttpResponseMessage GetListTourDayByPtn(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListTourDayByPtn(ent)));
        }


        [HttpPost]
        [Route("GetListImageFile")]
        public HttpResponseMessage GetListImageFile(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListImageFile(ent)));
        }


        [HttpPost]
        [Route("GetListTourPaymentTerm")]
        public HttpResponseMessage GetListTourPaymentTerm(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListTourPaymentTerm(ent)));
        }
        

        [HttpPost]
        [Route("GetListTourCancellationPolicy")]
        public HttpResponseMessage GetListTourCancellationPolicy(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListTourCancellationPolicy(ent)));
        }

        
        [HttpPost]
        [Route("GetListPriceItemTourByPUB")]
        public HttpResponseMessage GetListPriceItemTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListPriceItemTourByPUB(ent)));
        }

        [HttpPost]
        [Route("GetListPaxBookingTourForBkByPUB")]
        public HttpResponseMessage GetListPaxBookingTourForBkByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            B2B.Bus.AB.busApiTour bus = new B2B.Bus.AB.busApiTour();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetListPaxBookingTourForBkByPUB(ent)));
        }

        
        [HttpPost]
        [Route("GetListCompanyDestinationForHmPgTour2")]
        public HttpResponseMessage GetListCompanyDestinationForHmPgTour2(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListTourPublish")]
        public HttpResponseMessage GetListTourPublish(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListTourPublishPromotionForHmPgTour")]
        public HttpResponseMessage GetListTourPublishPromotionForHmPgTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListTourPublishLastMinuteForHmPgTour")]
        public HttpResponseMessage GetListTourPublishLastMinuteForHmPgTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourPublishInTopForHmPgTour")]
        public HttpResponseMessage GetListTourPublishInTopForHmPgTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListTourByPublic")]
        public HttpResponseMessage GetListTourByPublic(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListImageFile_2")]
        public HttpResponseMessage GetListImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourDetailByPtn")]
        public HttpResponseMessage GetListTourDetailByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourDayByPtn_2")]
        public HttpResponseMessage GetListTourDayByPtn_2(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListTourPaymentTerm_2")]
        public HttpResponseMessage GetListTourPaymentTerm_2(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListTourCancellationPolicy_2")]
        public HttpResponseMessage GetListTourCancellationPolicy_2(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevelTour")]
        public HttpResponseMessage GetListPriceLevelTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListPaxBookingTourForBkByPtn")]
        public HttpResponseMessage GetListPaxBookingTourForBkByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrderBookingForTour")]
        public HttpResponseMessage AddOrderBookingForTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPassengerForAffiliate")]
        public HttpResponseMessage UpdPassengerForAffiliate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

    }

}
