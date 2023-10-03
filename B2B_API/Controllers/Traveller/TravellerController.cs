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

namespace B2B_API.Controllers.Traveller
{
    [Authorize]
    [RoutePrefix("api/traveller")]
    public class TravellerController : ApiController
    {
         //Mr Tien (18/08/2020)
        [HttpPost]
        [Route("GetMemberDetail")]
        public HttpResponseMessage GetMemberDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMemberDetail")]
        public HttpResponseMessage UpdMemberDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        [HttpPost]
        [Route("CheckMemberPassword")]
        public HttpResponseMessage CheckMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);
                
            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strTLUserGUID:'" + Convert.ToString(routes_list["strTLUserGUID"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";
            
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(strJson)));
        }


        [HttpPost]
        [Route("UpdMemberPassword")]
        public HttpResponseMessage UpdMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strOldPassword = CMSService.Encrypt(Convert.ToString(routes_list["strOldPassword"]));
            var strNewPassword = CMSService.Encrypt(Convert.ToString(routes_list["strNewPassword"]));

            var strJson = "{strTLUserGUID:'" + Convert.ToString(routes_list["strTLUserGUID"]) + "', strOldPassword:'" + Convert.ToString(strOldPassword) + "', strNewPassword:'" + Convert.ToString(strNewPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(strJson)));
        }

        [HttpPost]
        [Route("GetFilterPassengerBooking")]
        public HttpResponseMessage GetFilterPassengerBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterPassengerOrderBooking")]
        public HttpResponseMessage GetFilterPassengerOrderBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        //Mr Tien (21/08/2020)

        [HttpPost]
        [Route("GetCheckPassengerByEmail")]
        public HttpResponseMessage GetCheckPassengerByEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("AddPassengerToRegister")]
        public HttpResponseMessage AddPassengerToRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("AddPassengerBooking")]
        public HttpResponseMessage AddPassengerBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        //End (21/08/2020)

        [HttpPost]
        [Route("GetListTravellerNewRegister")]
        public HttpResponseMessage GetListTravellerNewRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdStatusAccountPassenger")]
        public HttpResponseMessage UpdStatusAccountPassenger(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        //End (05/09/2020)
        [HttpPost]
        [Route("AddOrUpdPassengerOrderBooking")]
        public HttpResponseMessage AddOrUpdPassengerOrderBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUpdPassengerBooking")]
        public HttpResponseMessage AddOrUpdPassengerBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdOrderBookingStep1ByPassengerByPUB")]
        public HttpResponseMessage UpdOrderBookingStep1ByPassengerByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdPassengerForOrderBookingStep1ByPUB")]
        public HttpResponseMessage UpdPassengerForOrderBookingStep1ByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPassengerOrderByAgentHost")]
        public HttpResponseMessage GetListPassengerOrderByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPassengerOrderItem")]
        public HttpResponseMessage GetListPassengerOrderItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingFromTourByPassenger")]
        public HttpResponseMessage AddBookingFromTourByPassenger(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListPassengerBooking")]
        public HttpResponseMessage GetListPassengerBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingFromOrderByTraveller")]
        public HttpResponseMessage AddBookingFromOrderByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingFromHotelByTraveller")]
        public HttpResponseMessage AddBookingFromHotelByTraveller(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

    }

}
