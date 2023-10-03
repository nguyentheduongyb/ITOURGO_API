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
    [RoutePrefix("api/public/guide")]
    public class PublicGuideController : ApiController
    {


        [HttpPost]
        [Route("AddGuideForRegister")]
        public HttpResponseMessage AddGuideForRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckGuideRegisterByEmail")]
        public HttpResponseMessage GetCheckGuideRegisterByEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetEmailRegisterGuideCfmPass")]
        public HttpResponseMessage GetEmailRegisterGuideCfmPass(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetDetaiGuideRegister")]
        public HttpResponseMessage GetDetaiGuideRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdGuidePassword")]
        public HttpResponseMessage UpdGuidePassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strGuideGUID:'" + Convert.ToString(routes_list["strGuideGUID"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(strJson)));
        }

        [HttpPost]
        [Route("UpdResetPasswordByGuide")]
        public HttpResponseMessage UpdResetPasswordByGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strEmail:'" + Convert.ToString(routes_list["strEmail"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide(strJson)));
        }


        [HttpPost]
        [Route("GetEmailResetPasswordGuide")]
        public HttpResponseMessage GetEmailResetPasswordGuide(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }
    }

}
