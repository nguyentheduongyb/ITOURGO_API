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

namespace B2B_API.Controllers.Widget
{
    [RoutePrefix("api/widget/tour")]
    public class WidgetTourController : ApiController
    {

        [HttpPost]
        [Route("GetListTourDetailByPtn")]
        public HttpResponseMessage GetListTourDetailByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
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
        [Route("AddCartForTour")]
        public HttpResponseMessage AddCartForTour(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }
    }

}
