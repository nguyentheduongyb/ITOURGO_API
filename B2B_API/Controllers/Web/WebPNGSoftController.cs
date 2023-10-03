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

namespace B2B_API.Controllers.Web
{
    [Authorize]
    [RoutePrefix("api/pngsoft")]
    public class WebPNGSoftController : ApiController
    {

        [Route("GetSQLDataByTableConfig")]
        [HttpPost]
        public HttpResponseMessage GetSQLDataByTableConfig(B2B.Ent.CM.entCommond.entSystemPost ent)
        {
            B2B.Bus.WP.busWebPNGSoft bus = new B2B.Bus.WP.busWebPNGSoft();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(bus.GetSQLDataByTableConfig(ent.strTableName, ent.strFeildSelect, ent.strWhere)));
        }

        [HttpPost]
        [Route("DelAvdertisement")]
        public HttpResponseMessage DelAvdertisement(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WP.busWebPNGSoft bus = new B2B.Bus.WP.busWebPNGSoft();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

    }

}
