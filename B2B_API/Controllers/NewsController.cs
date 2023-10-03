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

namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/news")]
    public class NewsController : ApiController
    {


        [HttpPost]
        [Route("GetListNewsletterRegister")]
        public HttpResponseMessage GetListNewsletterRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListGuestContact")]
        public HttpResponseMessage GetListGuestContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdNewsForAddClient")]
        public HttpResponseMessage UpdNewsForAddClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        // Mr Tien (01/08/2020)
        [HttpPost]
        [Route("GetListNewsType")]
        public HttpResponseMessage GetListNewsType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("AddNewsTypePart")]
        public HttpResponseMessage AddNewsTypePart(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdNewsTypePart")]
        public HttpResponseMessage UpdNewsTypePart(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterALLNews")]
        public HttpResponseMessage GetFilterALLNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("AddNews")]
        public HttpResponseMessage AddNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdNews")]
        public HttpResponseMessage UpdNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("GetNewsTypePartByNewsTypeGUID")]
        public HttpResponseMessage GetNewsTypePartByNewsTypeGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        //End (01/08/2020)
        // Mr Tien (03/08/2020)
        [HttpPost]
        [Route("DelNewsTypePart")]
        public HttpResponseMessage DelNewsTypePart(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("DelNews")]
        public HttpResponseMessage DelNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("AddNewsType")]
        public HttpResponseMessage AddNewsType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdNewsType")]
        public HttpResponseMessage UpdNewsType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("DelNewsType")]
        public HttpResponseMessage DelNewsType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        //End (03/08/2020)


    }

}
