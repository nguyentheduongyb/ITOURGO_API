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
    [Authorize]
    [RoutePrefix("api/notify")]
    public class NotifyController : ApiController
    {

        [HttpPost]
        [Route("GetListAgentNotify")]
        public HttpResponseMessage GetListAgentNotify(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNotify(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdAgentNotifyToForIsNew")]
        public HttpResponseMessage UpdAgentNotifyToForIsNew(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNotify(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdAgentNotifyToForIsRead")]
        public HttpResponseMessage UpdAgentNotifyToForIsRead(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNotify(ent.strJson)));
        }

    }
}
