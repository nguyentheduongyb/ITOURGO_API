using B2B.Bus.SL;
using B2B.Ent.SL;
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
using B2B.Bus.CM;
using System.Data;
using System.Collections;

namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/tour")]
    public class TourController : ApiController
    {

        [HttpPost]
        [Route("GetTourReportByPaxCalendar")]
        public HttpResponseMessage GetTourReportByPaxCalendar(B2B.Ent.SL.entCommond.entFilterData ent)
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
        [Route("AddTourAffiliateLink")]
        public HttpResponseMessage AddTourAffiliateLink(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("DelTourAffiliateLinkForLinkName")]
        public HttpResponseMessage DelTourAffiliateLinkForLinkName(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        

        [HttpPost]
        [Route("UpdDepartureTourLevelForPriceChild")]
        public HttpResponseMessage UpdDepartureTourLevelForPriceChild(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdDepartureTourLevel")]
        public HttpResponseMessage UpdDepartureTourLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdDepartureTour")]
        public HttpResponseMessage UpdDepartureTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourSeasonLevel")]
        public HttpResponseMessage AddTourSeasonLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourPriceItemLevelForRefreshMarkupValue")]
        public HttpResponseMessage UpdTourPriceItemLevelForRefreshMarkupValue(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourSeasonLevel")]
        public HttpResponseMessage DelTourSeasonLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDepartureTourLevelByAgentHost")]
        public HttpResponseMessage GetListDepartureTourLevelByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourPriceItemLevelByAgentHostAddBooking")]
        public HttpResponseMessage GetListTourPriceItemLevelByAgentHostAddBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListDepartureTourLevelByAgentHostAddBooking")]
        public HttpResponseMessage GetListDepartureTourLevelByAgentHostAddBooking(B2B.Ent.SL.entCommond.entFilterData ent)
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
        [Route("AddTourSeasonByCalendar")]
        public HttpResponseMessage AddTourSeasonByCalendar(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourSeasonDate")]
        public HttpResponseMessage GetListTourSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("GetCheckDateForTourSeasonDate")]
        public HttpResponseMessage GetCheckDateForTourSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [Route("AddTourSeasonDate")]
        public HttpResponseMessage AddTourSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTourSeasonDate")]
        public HttpResponseMessage UpdTourSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTourSeasonDate")]
        public HttpResponseMessage DelTourSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrUpdDayItemLink")]
        public HttpResponseMessage AddOrUpdDayItemLink(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourForHasService")]
        public HttpResponseMessage UpdTourForHasService(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourDayForBookingService")]
        public HttpResponseMessage GetListTourDayForBookingService(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPaxBookingTour")]
        public HttpResponseMessage DelPaxBookingTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaxBookingTourForTotalPax")]
        public HttpResponseMessage UpdPaxBookingTourForTotalPax(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckRemainCreditForAddTourToBookingByAgent")]
        public HttpResponseMessage GetCheckRemainCreditForAddTourToBookingByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckRemainForServicesBooking")]
        public HttpResponseMessage GetCheckRemainForServicesBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourPriceItemLevelForPriceChild")]
        public HttpResponseMessage UpdTourPriceItemLevelForPriceChild(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("AddTourPriceItemForSeason")]
        public HttpResponseMessage AddTourPriceItemForSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("DelTourPriceItem")]
        public HttpResponseMessage DelTourPriceItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourSeason")]
        public HttpResponseMessage GetListTourSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourSeason")]
        public HttpResponseMessage AddTourSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdTourSeason")]
        public HttpResponseMessage UpdTourSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourSeason")]
        public HttpResponseMessage DelTourSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("AddTourForDuplicate")]
        public HttpResponseMessage AddTourForDuplicate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetTourReportByFixedDepartureByStatus")]
        public HttpResponseMessage GetTourReportByFixedDepartureByStatus(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCompanyDestinationForHmPgTour")]
        public HttpResponseMessage GetListCompanyDestinationForHmPgTour(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourPublishInTopForHmPgTour")]
        public HttpResponseMessage GetListTourPublishInTopForHmPgTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelDepartureTour")]
        public HttpResponseMessage DelDepartureTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCateByCompanyGUID")]
        public HttpResponseMessage GetListCateByCompanyGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        //---------------MrHieu(30/07/2019)
        [HttpPost]
        [Route("AddPromotionPriceLevelTour")]
        public HttpResponseMessage AddPromotionPriceLevelTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UdpPromotionPriceLevelTour")]
        public HttpResponseMessage UdpPromotionPriceLevelTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListPromotionPriceLevelTour")]
        public HttpResponseMessage GetListPromotionPriceLevelTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //---------------END(30/07/2019)

        //---------------MrHieu(12/09/2019)
        [HttpPost]
        [Route("GetListTour")]
        public HttpResponseMessage GetListTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //---------------END(12/09/2019)

        [HttpPost]
        [Route("GetListTourInAd")]
        public HttpResponseMessage GetListTourInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListTourPriceItemInAd")]
        public HttpResponseMessage GetListTourPriceItemInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("AddTourPriceItem")]
        public HttpResponseMessage AddTourPriceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourPriceItem")]
        public HttpResponseMessage UpdTourPriceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdTourPriceItemLevel")]
        public HttpResponseMessage UpdTourPriceItemLevel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        //---------------MrHieu(18/09/2019)
        [HttpPost]
        [Route("UpdTourInExcluded")]
        public HttpResponseMessage UpdTourInExcluded(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourDayDestination")]
        public HttpResponseMessage AddTourDayDestination(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourTripType")]
        public HttpResponseMessage AddTourTripType(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //---------------END(18/09/2019)

        //---------------MrHieu(23/09/2019)
        [HttpPost]
        [Route("GetListImageFile")]
        public HttpResponseMessage GetListImageFile(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourImageFile")]
        public HttpResponseMessage AddTourImageFile(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTourImageFile")]
        public HttpResponseMessage DelTourImageFile(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //---------------END(23/09/2019)
        

        //---------------MrHieu(18/06/2019)
        [HttpPost]
        [Route("GetListTourPublish")]
        public HttpResponseMessage GetListTourPublish(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListPriceLevelTour")]
        public HttpResponseMessage GetListPriceLevelTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //---------------END(18/06/2019)
        [HttpPost]
        [Route("GetListTourPriceItemLevelInAd")]
        public HttpResponseMessage GetListTourPriceItemLevelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        //------------------END(10/07/2019)

        [HttpPost]
        [Route("GetListTourChildAge")]
        public HttpResponseMessage GetListTourChildAge(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourForHasPriceKid")]
        public HttpResponseMessage UpdTourForHasPriceKid(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTourForHasNotPriceKid")]
        public HttpResponseMessage UpdTourForHasNotPriceKid(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUpdTourChildAge")]
        public HttpResponseMessage AddOrUpdTourChildAge(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourChildAge")]
        public HttpResponseMessage DelTourChildAge(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourServiceInAd")]
        public HttpResponseMessage GetListTourServiceInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourService")]
        public HttpResponseMessage AddTourService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourService")]
        public HttpResponseMessage UpdTourService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourService")]
        public HttpResponseMessage DelTourService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        //------------MrHIeu(20/12/2019)
        [HttpPost]
        [Route("GetListTourPaymentTerm")]
        public HttpResponseMessage GetListTourPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourPaymentTerm")]
        public HttpResponseMessage AddTourPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTourPaymentTerm")]
        public HttpResponseMessage UpdTourPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTourPaymentTerm")]
        public HttpResponseMessage DelTourPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListTourCancellationPolicy")]
        public HttpResponseMessage GetListTourCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourCancellationPolicy")]
        public HttpResponseMessage AddTourCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTourCancellationPolicy")]
        public HttpResponseMessage UpdTourCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTourCancellationPolicy")]
        public HttpResponseMessage DelTourCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //------------MrHIeu - END (20/12/2019)

        

        [HttpPost]
        [Route("AddTour")]
        public HttpResponseMessage AddTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTour")]
        public HttpResponseMessage UpdTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTour")]
        public HttpResponseMessage DelTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        [HttpPost]
        [Route("GetTourDetail")]
        public HttpResponseMessage GetTourDetail(entCommond.entFilterData ent)
        {
            busTour bus = new busTour();
            //return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(bus.GetTourDetail(ent.strTourGUID, ent.intTypeID, ent.strUserGUID).Tables[0]));
            entCommond.entDataReturn entReturn = new entCommond.entDataReturn
            {
                strDataRow1 = CMSService.ConvertTableToJsonObject(bus.GetTourDetail(ent.strTourGUID, ent.intTypeID, ent.strUserGUID).Tables[0]),
                strDataRow2 = CMSService.ConvertTableToJsonObject(bus.GetTourDetail(ent.strTourGUID, ent.intTypeID, ent.strUserGUID).Tables[1]),
            };
            return Request.CreateResponse(HttpStatusCode.OK, entReturn);
        }



        [HttpPost]
        [Route("GetDetailTourDay")]
        public HttpResponseMessage GetDetailTourDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourDay")]
        public HttpResponseMessage UpdTourDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        //-----------MrHieu(11/05/2020)
        [HttpPost]
        [Route("GetListTourDetailByPtn")]
        public HttpResponseMessage GetListTourDetailByPtn(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //-----------END(11/05/2020)


        //-----------MrHieu(12/05/2020)
        [HttpPost]
        [Route("GetListTourDayByPtn")]
        public HttpResponseMessage GetListTourDayByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //-----------END(12/05/2020)


        [HttpPost]
        [Route("GetListTourMainAttractionByAd")]
        public HttpResponseMessage GetListTourMainAttractionByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourMainAttractionByAd")]
        public HttpResponseMessage AddTourMainAttractionByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourMainAttractionByAd")]    
        public HttpResponseMessage UpdTourMainAttractionByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourMainAttractionByAd")]
        public HttpResponseMessage DelTourMainAttractionByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourDestinationByAd")]
        public HttpResponseMessage GetListTourDestinationByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourDestinationByAd")]
        public HttpResponseMessage AddTourDestinationByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTourDestinationByAd")]
        public HttpResponseMessage UpdTourDestinationByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourDestinationByAd")]
        public HttpResponseMessage DelTourDestinationByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourForHomeGRTee")]
        public HttpResponseMessage GetListTourForHomeGRTee(B2B.Ent.SL.entCommond.entFilterData ent)
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
        [Route("GetListPaxBookingTourByOwn")]
        public HttpResponseMessage GetListPaxBookingTourByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaxBookingTourByOwn")]
        public HttpResponseMessage AddPaxBookingTourByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTourPriceItemForDateRange")]
        public HttpResponseMessage AddTourPriceItemForDateRange(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        [HttpPost]
        [Route("AddDepartureTourForApplyByOwn")]
        public HttpResponseMessage AddDepartureTourForApplyByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDepartureTourByOwn")]
        public HttpResponseMessage GetListDepartureTourByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourToAllience")]
        public HttpResponseMessage GetListTourToAllience(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        //-----------END(15/07/2020)
        
        [HttpPost]
        [Route("GetListDepartureTourLevelByPtn")]
        public HttpResponseMessage GetListDepartureTourLevelByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
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

        // Tien (20/07/2020)

        [HttpPost]
        [Route("AddCopyAllienceTour")]
        public HttpResponseMessage AddCopyAllienceTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        // End (20/07/2020)

        [HttpPost]
        [Route("AddTourTripTypeForAlliance")]
        public HttpResponseMessage AddTourTripTypeForAlliance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        // Tien (21/07/2020)

        [HttpPost]
        [Route("GetListTourAllienceInAd")]
        public HttpResponseMessage GetListTourAllienceInAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetTourReportByFixedDeparture")]
        public HttpResponseMessage GetTourReportByFixedDeparture(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetTourReportByDailyTour")]
        public HttpResponseMessage GetTourReportByDailyTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        // End (21/07/2020)

        // Tien (23/07/2020)
        [HttpPost]
        [Route("AddCompanyListCateID")]
        public HttpResponseMessage AddCompanyListCateID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        // End (23/07/2020)

        // Tien (30/07/2020)
        [HttpPost]
        [Route("UpdTourEnable")]
        public HttpResponseMessage UpdTourEnable(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }


        // End (30/07/2020)
        // Tien (31/07/2020)
        [HttpPost]
        [Route("UpdTourOnTop")]
        public HttpResponseMessage UpdTourOnTop(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourOnTop")]
        public HttpResponseMessage DelTourOnTop(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourToAddTop")]
        public HttpResponseMessage GetListTourToAddTop(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        // End (31/07/2020)


        [HttpPost]
        [Route("GetTourReportByDailyTourByStatus")]
        public HttpResponseMessage GetTourReportByDailyTourByStatus(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        // End (25/08/2020)
        

        [HttpPost]
        [Route("DelTourAlliance")]
        public HttpResponseMessage DelTourAlliance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllienceComTypeID")]
        public HttpResponseMessage GetListAllienceComTypeID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        // End (28/08/2020)


        [HttpPost]
        [Route("GetHTMLCustomizeTourForExport")]
        public HttpResponseMessage GetHTMLCustomizeTourForExport(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCopyTourItem")]
        public HttpResponseMessage AddCopyTourItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListTourByGuide")]
        public HttpResponseMessage GetListTourByGuide(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
    }
}
