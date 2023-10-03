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
    [RoutePrefix("api/public/traveller")]
    public class PublicTravellerController : ApiController
    {

        [HttpPost]
        [Route("AddPassengerOrderForSupByHotelByPUB")]
        public HttpResponseMessage AddPassengerOrderForSupByHotelByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaxBookingTourForBkByPUB")]
        public HttpResponseMessage GetListPaxBookingTourForBkByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListPriceItemTourByPUB")]
        public HttpResponseMessage GetListPriceItemTourByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }
        

        [HttpPost]
        [Route("GetListDestinationForTourByPUB")]
        public HttpResponseMessage GetListDestinationForTourByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourPublishByPUB")]
        public HttpResponseMessage GetListTourPublishByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTour(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPassengerOrderForTour")]
        public HttpResponseMessage AddPassengerOrderForTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddNewBookingByTraveller")]
        public HttpResponseMessage AddNewBookingByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListBookingByTraveller")]
        public HttpResponseMessage GetListBookingByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListBookingAgentHostByTraveller")]
        public HttpResponseMessage GetListBookingAgentHostByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdResetPasswordByTraveller")]
        public HttpResponseMessage UpdResetPasswordByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strEmail:'" + Convert.ToString(routes_list["strEmail"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(strJson)));
        }


        [HttpPost]
        [Route("GetEmailResetPasswordTraveller")]
        public HttpResponseMessage GetEmailResetPasswordTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDirectorySearchingForSuppByTraveller")]
        public HttpResponseMessage GetListDirectorySearchingForSuppByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
    }

}
