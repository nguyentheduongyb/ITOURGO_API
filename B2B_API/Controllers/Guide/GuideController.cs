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
namespace B2B_API.Controllers.Guide
{
    [Authorize]
    [RoutePrefix("api/guide")]
    public class GuideController : ApiController
    {
        [HttpPost]
        [Route("GetMemberDetail")]
        public HttpResponseMessage GetMemberDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetHTMLOverviewProgramForGuide")]
        public HttpResponseMessage GetHTMLOverviewProgramForGuide(entCommond.entGuideModal ent)
        {
            busTour bus = new busTour();
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetHTMLOverviewProgramForGuide(ent));
        }

        [HttpPost]
        [Route("UpdGuideBookingPaid")]
        public HttpResponseMessage UpdGuideBookingPaid(entCommond.entGuideModal ent)
        {
            busTour bus = new busTour();
            return Request.CreateResponse(HttpStatusCode.OK, bus.UpdGuideBookingPaid(ent));
        }

        [HttpPost]
        [Route("UpdGuideServiceActual")]
        public HttpResponseMessage UpdGuideServiceActual(entCommond.entGuideModal ent)
        {
            busTour bus = new busTour();
            return Request.CreateResponse(HttpStatusCode.OK, bus.UpdGuideServiceActual(ent));
        }

        [HttpPost]
        [Route("GetListBookingGuidePayment")]
        public HttpResponseMessage GetListBookingGuidePayment(entCommond.entGuideModal ent)
        {
            busTour bus = new busTour();
            DataSet ds = bus.GetListBookingGuidePayment(ent.strGuideBookingGUID, ent.strGuideGUID, ent.intLangID);
            entCommond.entDataReturn entReturn = new entCommond.entDataReturn
            {
                strDataRow1 = CMSService.ConvertTableToJsonObject(ds.Tables[0]),
                strDataRow2 = CMSService.ConvertTableToJsonObject(ds.Tables[1]),
            };
            return Request.CreateResponse(HttpStatusCode.OK, entReturn);
        }

        //[HttpPost]
        //[Route("GetListGuideBooking")]
        //public HttpResponseMessage GetListGuideBooking(entCommond.entFilterData ent)
        //{
        //    busTour bus = new busTour();
        //    long intTotal = 0;
        //    entCommond.entDataReturn entReturn = new entCommond.entDataReturn
        //    {
        //        strDataRow1 = bus.GetListGuideBooking(ent.intCurrPage, ent.intPageSize, ref intTotal, ent.dtmDateFrom, ent.dtmDateTo, ent.strWhere, ent.intType, ent.strUserGUID),
        //        intTotalRecode = Convert.ToInt32(intTotal)
        //    };
        //    return Request.CreateResponse(HttpStatusCode.OK, entReturn);
        //}


        [HttpPost]
        [Route("GetDashBoardByGuideBooking")]
        public HttpResponseMessage GetDashBoardByGuideBooking(entCommond.entFilterData ent)
        {
            busTour bus = new busTour();
            entCommond.entDataReturn entReturn = new entCommond.entDataReturn
            {
                strDataRow1 = CMSService.ConvertTableToJsonObject(bus.GetDashBoardByGuideBooking(ent.dtmDateFromEx, ent.dtmDateToEx, ent.strWhere, ent.intType, ent.strUserGUID).Tables[0]),
            };
            return Request.CreateResponse(HttpStatusCode.OK, entReturn);
        }



        [HttpPost]
        [Route("CheckMemberPassword")]
        public HttpResponseMessage CheckMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strUserGUID:'" + Convert.ToString(routes_list["strUserGUID"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(strJson)));
        }


        [HttpPost]
        [Route("UpdMemberPassword")]
        public HttpResponseMessage UpdMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strOldPassword = CMSService.Encrypt(Convert.ToString(routes_list["strOldPassword"]));
            var strNewPassword = CMSService.Encrypt(Convert.ToString(routes_list["strNewPassword"]));

            var strJson = "{strUserGUID:'" + Convert.ToString(routes_list["strUserGUID"]) + "', strOldPassword:'" + Convert.ToString(strOldPassword) + "', strNewPassword:'" + Convert.ToString(strNewPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(strJson)));
        }

        

        [HttpPost]
        [Route("UpdGuideInfoProfile")]
        public HttpResponseMessage UpdGuideInfoProfile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListGuideBankAccount")]
        public HttpResponseMessage GetListGuideBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideBankAccount")]
        public HttpResponseMessage AddGuideBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideBankAccount")]
        public HttpResponseMessage UpdGuideBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideBankAccount")]
        public HttpResponseMessage DelGuideBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAgentHostNoAddByGuide")]
        public HttpResponseMessage GetListAgentHostNoAddByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAgentHostToGuide")]
        public HttpResponseMessage AddAgentHostToGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailSendRequestLinkAgentHostByGuide")]
        public HttpResponseMessage GetEmailSendRequestLinkAgentHostByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListGuideBooking")]
        public HttpResponseMessage GetListGuideBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideBookingByCalendar")]
        public HttpResponseMessage AddGuideBookingByCalendar(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListGuideByAgentHost")]
        public HttpResponseMessage GetListGuideByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideAgentHostLinkByConfirm")]
        public HttpResponseMessage UpdGuideAgentHostLinkByConfirm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailConfirmRequestLinkByAgentHostAndGuide")]
        public HttpResponseMessage GetEmailConfirmRequestLinkByAgentHostAndGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListGuideLang")]
        public HttpResponseMessage GetListGuideLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideLang")]
        public HttpResponseMessage AddGuideLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideLang")]
        public HttpResponseMessage UpdGuideLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideLang")]
        public HttpResponseMessage DelGuideLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListGuidePlace")]
        public HttpResponseMessage GetListGuidePlace(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuidePlace")]
        public HttpResponseMessage AddGuidePlace(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuidePlace")]
        public HttpResponseMessage UpdGuidePlace(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuidePlace")]
        public HttpResponseMessage DelGuidePlace(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListLicenceGuide")]
        public HttpResponseMessage GetListLicenceGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddListLicenceGuide")]
        public HttpResponseMessage AddListLicenceGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdListLicenceGuide")]
        public HttpResponseMessage UpdListLicenceGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelListLicenceGuide")]
        public HttpResponseMessage DelListLicenceGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideBooking")]
        public HttpResponseMessage UpdGuideBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }
        
        [HttpPost]
        [Route("DelGuideBooking")]
        public HttpResponseMessage DelGuideBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideInBooking")]
        public HttpResponseMessage GetListGuideInBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideInBooking")]
        public HttpResponseMessage AddGuideInBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideInBooking")]
        public HttpResponseMessage UpdGuideInBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideInBooking")]
        public HttpResponseMessage DelGuideInBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideProgramDay")]
        public HttpResponseMessage GetListGuideProgramDay(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideProgramDay")]
        public HttpResponseMessage UpdGuideProgramDay(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        

        [HttpPost]
        [Route("GetListClientByGuide")]
        public HttpResponseMessage GetListClientByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideServiceSchedule")]
        public HttpResponseMessage GetListGuideServiceSchedule(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideServiceSchedule")]
        public HttpResponseMessage AddGuideServiceSchedule(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideServiceSchedule")]
        public HttpResponseMessage UpdGuideServiceSchedule(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideServiceSchedule")]
        public HttpResponseMessage DelGuideServiceSchedule(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListSupplierMappingByGuide")]
        public HttpResponseMessage GetListSupplierMappingByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideServiceCost")]
        public HttpResponseMessage GetListGuideServiceCost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideServiceCost")]
        public HttpResponseMessage AddGuideServiceCost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideServiceCost")]
        public HttpResponseMessage UpdGuideServiceCost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideServiceCost")]
        public HttpResponseMessage DelGuideServiceCost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdGuideServiceScheduleForPriceTotal")]
        public HttpResponseMessage UpdGuideServiceScheduleForPriceTotal(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideCollectForSupplier")]
        public HttpResponseMessage GetListGuideCollectForSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideCollectForSupplier")]
        public HttpResponseMessage AddGuideCollectForSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideCollectForSupplier")]
        public HttpResponseMessage UpdGuideCollectForSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideCollectForSupplier")]
        public HttpResponseMessage DelGuideCollectForSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideAdvance")]
        public HttpResponseMessage GetListGuideAdvance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideAdvance")]
        public HttpResponseMessage AddGuideAdvance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideAdvance")]
        public HttpResponseMessage UpdGuideAdvance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGuideAdvance")]
        public HttpResponseMessage DelGuideAdvance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierByGuide")]
        public HttpResponseMessage GetListSupplierByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdGuideServiceCostForActual")]
        public HttpResponseMessage UpdGuideServiceCostForActual(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdGuideCollectForSupplierForActual")]
        public HttpResponseMessage UpdGuideCollectForSupplierForActual(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdGuideBookingByFinal")]
        public HttpResponseMessage UpdGuideBookingByFinal(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetDashBoardByMonthYearGuide")]
        public HttpResponseMessage GetDashBoardByMonthYearGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideByManage")]
        public HttpResponseMessage GetListGuideByManage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGuideForEnable")]
        public HttpResponseMessage UpdGuideForEnable(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdGuideBookingStatus")]
        public HttpResponseMessage UpdGuideBookingStatus(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideFileAttach")]
        public HttpResponseMessage GetListGuideFileAttach(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGuideFileAttach")]
        public HttpResponseMessage AddGuideFileAttach(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strFile_PathRoot = Convert.ToString(routes_list["strFile_PathRoot"]);
            string strFile_Data = Convert.ToString(routes_list["strFile_Data"]);
            string strFile_Name = Convert.ToString(routes_list["strFile_Name"]);


            string path = "";
            path = "UpLoad/" + strFile_PathRoot + "/" + DateTime.Now.ToString("yyyy/MM") + "/";
            if (!System.IO.Directory.Exists(CMSService.GetPath(path)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(path));
            }


            string strFileName = System.IO.Path.GetFileNameWithoutExtension(strFile_Name) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + System.IO.Path.GetExtension(strFile_Name);
            string strPathFileName = CMSService.GetPath(path + strFileName);

            Byte[] bytes = Convert.FromBase64String(strFile_Data);
            System.IO.File.WriteAllBytes(strPathFileName, bytes);

            var intIndex = 0;
            var strJson = "";
            strJson += "{";
            foreach (var record in routes_list)
            {
                if (!record.Key.Contains("File_") && !record.Key.Contains("dblFileSize") && !record.Key.Contains("strFileName") && !record.Key.Contains("strFilePath"))
                {

                    strJson += (intIndex == 0 ? "" : ",") + record.Key + ": " + (record.Value == null ? "null" : "'" + record.Value + "'");

                    intIndex++;
                }
            }
            strJson += ",dblFileSize: " + routes_list["dblFileSize"].ToString().Replace(',', '.') + "";
            strJson += ",strFilePath: '" + path + "'";
            strJson += ",strFileName: '" + strFileName + "'";
            strJson += "}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(strJson)));
        }

        [HttpPost]
        [Route("DelGuideFileAttach")]
        public HttpResponseMessage DelGuideFileAttach(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strFileLink = Convert.ToString(routes_list["strFilePath"]) + Convert.ToString(routes_list["strFileName"]);
            System.IO.File.Delete(CMSService.GetPath(strFileLink));


            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        
        [HttpPost]
        [Route("GetDetailGuidePaxDailyBookingTour")]
        public HttpResponseMessage GetDetailGuidePaxDailyBookingTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("AddGuidePaxDailyRouting")]
        public HttpResponseMessage AddGuidePaxDailyRouting(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdGuidePaxDailyRouting")]
        public HttpResponseMessage UpdGuidePaxDailyRouting(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("DelGuidePaxDailyRouting")]
        public HttpResponseMessage DelGuidePaxDailyRouting(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdGuidePaxDailyBookingTourByInfo")]
        public HttpResponseMessage UpdGuidePaxDailyBookingTourByInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

    }
}
