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
    [RoutePrefix("api/log")]
    public class LogController : ApiController
    {

        [HttpPost]
        [Route("GetListAgentActionLog")]
        public HttpResponseMessage GetListAgentActionLog(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionLog(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAgentHostActionLog")]
        public HttpResponseMessage GetListAgentHostActionLog(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionLog(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGuideActionLog")]
        public HttpResponseMessage GetListGuideActionLog(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionLog(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPaxActionLog")]
        public HttpResponseMessage GetListPaxActionLog(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionLog(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddActionLogByLogOut")]
        public HttpResponseMessage AddActionLogByLogOut(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionLog(ent.strJson)));
        }
        
    }
}
