using B2B.Bus.CM;
using B2B.Dat.SL;
using B2B.Ent.CM;
using B2B_API.App_Start;
using B2B_API.Filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/system")]
    public class SystemController : ApiController
    {


        [HttpPost]
        [Route("GetListDirectorySearchingForSuppByAgent")]
        public HttpResponseMessage GetListDirectorySearchingForSuppByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDirectorySearchingForTourByAgent")]
        public HttpResponseMessage GetListDirectorySearchingForTourByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSearchIndexByAgent")]
        public HttpResponseMessage GetListSearchIndexByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSrcIndex(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListDestinationForItineraryByAgent")]
        public HttpResponseMessage GetListDestinationForItineraryByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCateByAgentHost")]
        public HttpResponseMessage GetListCateByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailForCreateAgentMemberByAgentHost")]
        public HttpResponseMessage GetEmailForCreateAgentMemberByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDestinationForTourByAgent")]
        public HttpResponseMessage GetListDestinationForTourByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListDestinationForSuppByAgent")]
        public HttpResponseMessage GetListDestinationForSuppByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailSendAgentHostByAgentBook")]
        public HttpResponseMessage GetEmailSendAgentHostByAgentBook(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailSendAgentHostByAgentHold")]
        public HttpResponseMessage GetEmailSendAgentHostByAgentHold(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }
        //-------------------MrHieu(26/07/2019)
        [HttpPost]
        [Route("GetAppKeyConnectTMS")]
        public HttpResponseMessage GetAppKeyConnectTMS(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        //[HttpPost]
        //[Route("UploadImage")]
        //public HttpResponseMessage UploadImage(B2B.Ent.SL.entCommond.entFilterData ent)
        //{
        //    string strFileName = System.Guid.NewGuid().ToString().Replace("-", "");

        //    strFileName = strFileName + "." + ent.strCombocode;
        //    byte[] content = Convert.FromBase64String(ent.strJson);
        //    System.IO.File.WriteAllBytes(System.Web.Hosting.HostingEnvironment.MapPath("~/UpLoad/") + strFileName, content);
        //    return Request.CreateResponse(HttpStatusCode.OK, "");
        //}
        //-------------------END(26/07/2019)

        //[HttpGet]
        //[CMSMemberUserFilter]
        //[Route("GetWebMenu")]
        //public HttpResponseMessage GetWebMenu(HttpRequestMessage request)
        //{
        //    entCommond.entDataReturn ent = new entCommond.entDataReturn();
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    var strUserGUID = User.Identity.Name;
        //    busCommond bus = new busCommond();
        //    ds = bus.GetWebMenu(strUserGUID);
        //    return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        //}

        [HttpPost]
        // [CMSMemberUserFilter]
        [Route("GetWebMenu")]
        public HttpResponseMessage GetWebMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }

        [HttpPost]
        [Route("GetMenuLeftListItems")]
        public HttpResponseMessage GetMenuLeftListItems(entCommond.entXML ent)
        {
            //entCommond.entDataReturn ent = new entCommond.entDataReturn();
            System.Data.DataSet ds = new System.Data.DataSet();
            var strXml = ent.strXML1 + "<strUserGUID>" + User.Identity.Name + "</strUserGUID>";
            busCommond bus = new busCommond();
            ds = bus.GetListItemInPanel(strXml);
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[0]));
        }




        [HttpPost]
        [Route("GetListPaxConfig")]
        public HttpResponseMessage GetListPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaxConfig")]
        public HttpResponseMessage AddPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaxConfig")]
        public HttpResponseMessage UpdPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPaxConfig")]
        public HttpResponseMessage DelPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevel")]
        public HttpResponseMessage GetListPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceLevel")]
        public HttpResponseMessage AddPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceLevel")]
        public HttpResponseMessage UpdPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceLevel")]
        public HttpResponseMessage DelPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPaymentTerm")]
        public HttpResponseMessage GetListPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaymentTerm")]
        public HttpResponseMessage AddPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaymentTerm")]
        public HttpResponseMessage UpdPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPaymentTerm")]
        public HttpResponseMessage DelPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCancellationPolicy")]
        public HttpResponseMessage GetListCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCancellationPolicy")]
        public HttpResponseMessage AddCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCancellationPolicy")]
        public HttpResponseMessage UpdCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCancellationPolicy")]
        public HttpResponseMessage DelCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListChildAge")]
        public HttpResponseMessage GetListChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUpdChildAge")]
        public HttpResponseMessage AddOrUpdChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelChildAge")]
        public HttpResponseMessage DelChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        //-------------------MrHieu(01/10/2019)
        [HttpPost]
        [Route("GetListDestinationByPartnerSearch")]
        public HttpResponseMessage GetListDestinationByPartnerSearch(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }
        //-------------------END(01/10/2019)

        [HttpPost]
        [Route("GetListCurrency")]
        public HttpResponseMessage GetListCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }
        

        [HttpPost]
        [Route("GetListDestinationForSupplierOnlineByAgent")]
        public HttpResponseMessage GetListDestinationForSupplierOnlineByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetListDestinationForVoucherByAgent")]
        public HttpResponseMessage GetListDestinationForVoucherByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCity")]
        public HttpResponseMessage GetListCity(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourSite")]
        public HttpResponseMessage GetListTourSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListEmailTemplate")]
        public HttpResponseMessage GetListEmailTemplate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddEmailTemplate")]
        public HttpResponseMessage AddEmailTemplate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdEmailTemplate")]
        public HttpResponseMessage UpdEmailTemplate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailBookingConfirm")]
        public HttpResponseMessage GetEmailBookingConfirm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        // Tien (23/07/2020)


        [HttpPost]
        [Route("GetFilterLanguage")]
        public HttpResponseMessage GetFilterLanguage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdLanguage")]
        public HttpResponseMessage UpdLanguage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterCurrency")]
        public HttpResponseMessage GetFilterCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCurrency")]
        public HttpResponseMessage UpdCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterExchangeRate")]
        public HttpResponseMessage GetFilterExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }

        [HttpPost]
        [Route("AddExchangeRate")]
        public HttpResponseMessage AddExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdExchangeRate")]
        public HttpResponseMessage UpdExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }


        [HttpPost]
        [Route("DelExchangeRate")]
        public HttpResponseMessage DelExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }


        // End (23/07/2020)


        // Tien (27/07/2020)

        [HttpPost]
        [Route("GetListCityByCountry")]
        public HttpResponseMessage GetListCityByCountry(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCity")]
        public HttpResponseMessage UpdCity(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCity")]
        public HttpResponseMessage DelCity(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]
        [Route("DelRegion")]
        public HttpResponseMessage DelRegion(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("DelDepartment")]
        public HttpResponseMessage DelDepartment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCity")]
        public HttpResponseMessage AddCity(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }




          [HttpPost]
        [Route("AddDepartment")]
        public HttpResponseMessage AddDepartment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        [HttpPost]

        [Route("UpdDepartment")]
        public HttpResponseMessage UpdDepartment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]

        [Route("UpdRegion")]
        public HttpResponseMessage UpdRegion(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("AddRegion")]
        public HttpResponseMessage AddRegion(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCountry")]
        public HttpResponseMessage GetListCountry(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }



        [HttpPost]
        [Route("AddCountry")]
        public HttpResponseMessage AddCountry(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdCountry")]
        public HttpResponseMessage UpdCountry(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }



        [HttpPost]
        [Route("DelCountry")]
        public HttpResponseMessage DelCountry(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        // End (27/07/2020)
        // Mr Tien (05/08/2020)

        [HttpPost]
        [Route("GetSglDBL")]
        public HttpResponseMessage GetSglDBL(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }
        // End (05/08/2020)


        [HttpPost]
        [Route("AddMainAttraction")]
        public HttpResponseMessage AddMainAttraction(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }



        [HttpPost]
        [Route("DelMainAttraction")]
        public HttpResponseMessage DelMainAttraction(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdMainAttraction")]
        public HttpResponseMessage UpdMainAttraction(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListAppLabel")]
        public HttpResponseMessage GetListAppLabel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenuMap(ent.strJson)));
        }


        [HttpPost]
        [Route("AddAppLabel")]
        public HttpResponseMessage AddAppLabel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenuMap(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdAppLabel")]
        public HttpResponseMessage UpdAppLabel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenuMap(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdAppLabelByLang")]
        public HttpResponseMessage UpdAppLabelByLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenuMap(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListError")]
        public HttpResponseMessage GetListError(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSystem(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdErrorBySetDone")]
        public HttpResponseMessage UpdErrorBySetDone(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSystem(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAllowOriginHostFromTMS")]
        public HttpResponseMessage GetListAllowOriginHostFromTMS(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        // End (08/09/2020)


        [HttpPost]
        [Route("GetEmailSendRequestBookingByAgent")]
        public HttpResponseMessage GetEmailSendRequestBookingByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }



        [HttpPost]
        [Route("GetSendEmail")]
        public HttpResponseMessage GetSendEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strReturn = CMSService.SendEmail(routes_list["strUserGUID"].ToString(), Convert.ToString(routes_list["strEmailsSendTo"]), Convert.ToString(routes_list["strEmailsCC"]), Convert.ToString(routes_list["strEmailsBCC"]), routes_list["strSubject"].ToString(), routes_list["strBody"].ToString(), Convert.ToBoolean(routes_list["IsBodyHtml"]));
            
            return Request.CreateResponse(HttpStatusCode.OK, strReturn);
        }

        [HttpPost]
        [Route("GetListMedia")]
        public HttpResponseMessage GetListMedia(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string pathRoot = Convert.ToString(routes_list["pathRoot"]);
            string path = Convert.ToString(routes_list["path"]);

            pathRoot = "Upload/" + pathRoot;

            string strReturn = "";

            strReturn += "\"pathRoot\":\"" + pathRoot + "\"";
            strReturn += ",\"path\":\"" + path + "\"";

            
            if (!System.IO.Directory.Exists(CMSService.GetPath(pathRoot + "\\" + path)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(pathRoot + "\\" + path));
            }
            string[] folderArray = System.IO.Directory.GetDirectories(CMSService.GetPath(pathRoot + "\\" + path));//Directory.GetFiles(GetPath("Uploads"));
            if (folderArray.Length != 0)
            {
                strReturn += ",\"folder\":[";

                for (int i = 0; i < folderArray.Length; i++)
                {
                    strReturn += (i == 0 ? "" : ",") + "{\"name\":\"" + folderArray[i].Replace(CMSService.GetPath(pathRoot + "\\" + path + "\\"), "") + "\",\"path\":\"" + folderArray[i].Replace(CMSService.GetPath(pathRoot) + "\\", "").Replace("\\", "/") + "\"}";
                }
                strReturn += "]";
            }

            string[] fileArray = System.IO.Directory.GetFiles(CMSService.GetPath(pathRoot + "\\" + path));//Directory.GetFiles(GetPath("Uploads"));
            if (fileArray.Length != 0)
            {
                strReturn += ",\"file\":[";

                for (int i = 0; i < fileArray.Length; i++)
                {
                    strReturn += (i == 0 ? "" : ",") + "{\"name\":\"" + fileArray[i].Replace(CMSService.GetPath(pathRoot + "\\" + path + "\\"), "") + "\",\"path\":\"" + fileArray[i].Replace(CMSService.GetPath(""), "").Replace("\\", "/") + "\"}";
                }
                strReturn += "]";
            }
            return Request.CreateResponse(HttpStatusCode.OK, "{" + strReturn + "}");
        }


        [HttpPost]
        [Route("AddFolderMedia")]
        public HttpResponseMessage AddFolderMedia(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string pathRoot = Convert.ToString(routes_list["pathRoot"]);
            string path = Convert.ToString(routes_list["path"]);
            string newName = Convert.ToString(routes_list["newName"]);

            pathRoot = "Upload/" + pathRoot;

            string pathFile_New = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newName);

            if (System.IO.Directory.Exists(pathFile_New))
            {
                int dupplicate_count = 0;
                string newFileNameWithDupplicateIndex;
                string newFilePathWithDupplicateIndex;
                do
                {
                    dupplicate_count++;
                    newFileNameWithDupplicateIndex = newName + " (" + dupplicate_count + ")";
                    newFilePathWithDupplicateIndex = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newFileNameWithDupplicateIndex);
                } while (System.IO.Directory.Exists(newFilePathWithDupplicateIndex));
                pathFile_New = newFilePathWithDupplicateIndex;

                //System.IO.File.Delete(newFilePath)
                //throw new System.IO.IOException("The destination file already exists.");
            }
            System.IO.Directory.CreateDirectory(pathFile_New);

            return Request.CreateResponse(HttpStatusCode.OK, "");
        }

        [HttpPost]
        [Route("UpdRenameFolderOrFileMedia")]
        public HttpResponseMessage UpdRenameFolderOrFileMedia(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string pathRoot = Convert.ToString(routes_list["pathRoot"]);
            string path = Convert.ToString(routes_list["path"]);
            string fileName = Convert.ToString(routes_list["fileName"]);
            string newName = Convert.ToString(routes_list["newName"]);

            pathRoot = "Upload/" + pathRoot;

            int fileExtPos = fileName.LastIndexOf(".");

            if (fileExtPos >= 0)//---------------FILE
            {
                string ext = fileName.Substring(fileExtPos, fileName.Length - fileExtPos);

                string pathFile_Old = CMSService.GetPath(pathRoot + "\\" + path + "\\" + fileName);
                string pathFile_New = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newName + ext);

                if (System.IO.File.Exists(pathFile_New))
                {
                    int dupplicate_count = 0;
                    string newFileNameWithDupplicateIndex;
                    string newFilePathWithDupplicateIndex;
                    do
                    {
                        dupplicate_count++;
                        newFileNameWithDupplicateIndex = newName + " (" + dupplicate_count + ")" + ext;
                        newFilePathWithDupplicateIndex = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newFileNameWithDupplicateIndex);
                    } while (System.IO.File.Exists(newFilePathWithDupplicateIndex));
                    pathFile_New = newFilePathWithDupplicateIndex;

                    //System.IO.File.Delete(newFilePath)
                    //throw new System.IO.IOException("The destination file already exists.");
                }
                System.IO.File.Move(pathFile_Old, pathFile_New);

            }
            else//---------------FOLDER
            {
                string pathFile_Old = CMSService.GetPath(pathRoot + "\\" + path + "\\" + fileName);
                string pathFile_New = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newName);

                if (System.IO.Directory.Exists(pathFile_New))
                {
                    int dupplicate_count = 0;
                    string newFileNameWithDupplicateIndex;
                    string newFilePathWithDupplicateIndex;
                    do
                    {
                        dupplicate_count++;
                        newFileNameWithDupplicateIndex = newName + " (" + dupplicate_count + ")";
                        newFilePathWithDupplicateIndex = CMSService.GetPath(pathRoot + "\\" + path + "\\" + newFileNameWithDupplicateIndex);
                    } while (System.IO.Directory.Exists(newFilePathWithDupplicateIndex));
                    pathFile_New = newFilePathWithDupplicateIndex;

                    //System.IO.File.Delete(newFilePath)
                    //throw new System.IO.IOException("The destination file already exists.");
                }
                System.IO.Directory.Move(pathFile_Old, pathFile_New);
            }

            return Request.CreateResponse(HttpStatusCode.OK, "");
        }

        [HttpPost]
        [Route("DelFolderOrFileMedia")]
        public HttpResponseMessage DelFolderOrFileMedia(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string pathRoot = Convert.ToString(routes_list["pathRoot"]);
            string path = Convert.ToString(routes_list["path"]);
            string fileName = Convert.ToString(routes_list["fileName"]);

            pathRoot = "Upload/" + pathRoot;

            int fileExtPos = fileName.LastIndexOf(".");

            if (fileExtPos >= 0)//---------------FILE
            {
                string pathFile = CMSService.GetPath(pathRoot + "\\" + path + "\\" + fileName);

                if (System.IO.File.Exists(pathFile))
                {
                    System.IO.File.Delete(pathFile);
                }
            }
            else//---------------FOLDER
            {
                string pathFile = CMSService.GetPath(pathRoot + "\\" + path + "\\" + fileName);

                if (System.IO.Directory.Exists(pathFile))
                {
                    System.IO.Directory.Delete(pathFile);
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK, "");
        }



        [HttpPost]
        [Route("UploadFiles")]
        public HttpResponseMessage UploadFiles()
        {
            var context = System.Web.HttpContext.Current;
            string path = context.Request.QueryString["path"];
            path = "UpLoad/" + path + "/";

            if (!System.IO.Directory.Exists(CMSService.GetPath(path)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(path));
            }

            string pathReturn = "[";
            if (context.Request.Files.Count > 0)
            {
                System.Web.HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    System.Web.HttpPostedFile file = files[i];

                    string strFileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + System.IO.Path.GetExtension(file.FileName);//CMSService.GetPath(path + file.FileName);
                    string strPathFileName = CMSService.GetPath(path + strFileName);

                    file.SaveAs(strPathFileName);

                    pathReturn += (i == 0 ? "" : ",") + "\"" + path + strFileName + "\"";
                }
            }
            pathReturn += "]";
            return Request.CreateResponse(HttpStatusCode.OK, pathReturn);
        }

        [HttpPost]
        [Route("UploadFilesForBytesOverwrite")]
        public HttpResponseMessage UploadFilesForBytesOverwrite(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strPathRoot = Convert.ToString(routes_list["strPathRoot"]);
            string strPath = Convert.ToString(routes_list["strPath"]);
            string strFileName = Convert.ToString(routes_list["strFileName"]);
            string strData = Convert.ToString(routes_list["strData"]);
            strPath = "UpLoad/" + strPathRoot + "/" + strPath + "/";

            if (!System.IO.Directory.Exists(CMSService.GetPath(strPath)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(strPath));
            }

            string strPathFileName = CMSService.GetPath(strPath + strFileName);

            Byte[] bytes = Convert.FromBase64String(strData);
            System.IO.File.WriteAllBytes(strPathFileName, bytes);

            string pathReturn = "[";
            //if (context.Request.Files.Count > 0)
            //{
            //    System.Web.HttpFileCollection files = context.Request.Files;
            //    for (int i = 0; i < files.Count; i++)
            //    {
            //        System.Web.HttpPostedFile file = files[i];

            //        string strFileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + System.IO.Path.GetExtension(file.FileName);//CMSService.GetPath(path + file.FileName);
            //        string strPathFileName = CMSService.GetPath(path + strFileName);

            //        file.SaveAs(strPathFileName);

                    pathReturn += strPathFileName;
            //    }
            //}
            pathReturn += "]";
            return Request.CreateResponse(HttpStatusCode.OK, pathReturn);
        }


        [HttpPost]
        [Route("GetByteImage")]
        public HttpResponseMessage GetByteImage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string pathRoot = Convert.ToString(routes_list["strUrlImg"]);

            byte[] content;
            HttpWebRequest requestcontent = (HttpWebRequest)WebRequest.Create(pathRoot);
            WebResponse response = requestcontent.GetResponse();

            System.IO.Stream stream = response.GetResponseStream();

            using (System.IO.BinaryReader br = new System.IO.BinaryReader(stream))
            {
                content = br.ReadBytes(1000000000);
                br.Close();
            }
            response.Close();

            return Request.CreateResponse(HttpStatusCode.OK, content);
        }



        [Route("BindDropDownList")]
        [HttpPost]
        public HttpResponseMessage BindDropDownList(entCommond.entFilterData ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busUser bus = new busUser();
            return Request.CreateResponse(HttpStatusCode.OK, datCommond.GetComboboxByCode(ent.strCombocode));
        }

        [Route("GetComboboxByCode")]
        [HttpPost]
        public HttpResponseMessage GetComboboxByCode(entCommond.entFilterData ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busUser bus = new busUser();
            return Request.CreateResponse(HttpStatusCode.OK, datCommond.GetComboboxByCode(ent.strCombocode, ent.strWhere));
        }

        [Route("GetSQLDataByTableConfig")]
        [HttpPost]
        public HttpResponseMessage GetSQLDataByTableConfig(entCommond.entSystemPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(bus.GetSQLDataByTableConfig(ent.strTableName, ent.strFeildSelect, ent.strWhere)));
        }

        [Route("GetDropDownListJson")]
        [HttpPost]
        public HttpResponseMessage GetDropDownListJson(entCommond.entFilterData ent)
        {
            if (ent.strWhere != null && ent.strWhere.Trim().ToLower() != "null" && ent.strWhere != "")
                ent.strWhere = ent.strWhere.Replace("^", "'");
            System.Data.DataSet ds = new System.Data.DataSet();
            busCommond bus = new busCommond();
            if (ent.strWhere == null || ent.strWhere == "")
                ds = bus.GetDllByCode(ent.strCombocode); // .BindDropDownList(strComboCode)
            else
                ds = bus.GetDllByCode(ent.strCombocode, ent.strWhere);// .BindDropDownList(strComboCode)
            List<clsDropDownList> _clsDropDownList = new List<clsDropDownList>();
            DataTable t = new DataTable();
            t = ds.Tables[0];
            if (t.Rows.Count > 0)
            {
                for (int i = 0; i <= t.Rows.Count - 1; i++)
                {
                    clsDropDownList item = new clsDropDownList();
                    item.strTextField = t.Rows[i]["strTextField"].ToString();
                    item.strValueField = t.Rows[i]["strValueField"].ToString();
                    _clsDropDownList.Add(item);
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK, _clsDropDownList);
        }
        
       
    }
    public class clsDropDownList
    {
        private string _strTextField;
        public string strTextField
        {
            get
            {
                return _strTextField;
            }
            set
            {
                _strTextField = value;
            }
        }
        private string _strValueField;
        public string strValueField
        {
            get
            {
                return _strValueField;
            }
            set
            {
                _strValueField = value;
            }
        }
    }
}
