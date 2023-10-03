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

namespace B2B_API.Controllers.WebItoursys
{
    [Authorize]
    [RoutePrefix("api/itoursys")]
    public class WebItoursysController : ApiController
    {

        [Route("GetSQLDataByTableConfig")]
        [HttpPost]
        public HttpResponseMessage GetSQLDataByTableConfig(B2B.Ent.CM.entCommond.entSystemPost ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(bus.GetSQLDataByTableConfig(ent.strTableName, ent.strFeildSelect, ent.strWhere)));
        }

        [HttpPost]
        [Route("GetListWebMenu")]
        public HttpResponseMessage GetListWebMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCategoryWebMenu")]
        public HttpResponseMessage AddCategoryWebMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCategoryWebMenu")]
        public HttpResponseMessage UpdCategoryWebMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdStatus")]
        public HttpResponseMessage UpdStatus(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }

        

        [HttpPost]
        [Route("GetDetailWebMenu")]
        public HttpResponseMessage GetDetailWebMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterNewsProduct")]
        public HttpResponseMessage GetFilterNewsProduct(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdNewsProductByAdmin")]
        public HttpResponseMessage UpdNewsProductByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdStatusNewsProduct")]
        public HttpResponseMessage UpdStatusNewsProduct(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("AddNewsProductByAdmin")]
        public HttpResponseMessage AddNewsProductByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("DelNewsProduct")]
        public HttpResponseMessage DelNewsProduct(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListNews")]
        public HttpResponseMessage GetListNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("AddNewsByAdmin")]
        public HttpResponseMessage AddNewsByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdNewsByAdmin")]
        public HttpResponseMessage UpdNewsByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdInsIsTop")]
        public HttpResponseMessage UpdInsIsTop(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdStatusNews")]
        public HttpResponseMessage UpdStatusNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("DelNews")]
        public HttpResponseMessage DelNews(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionNews(ent.strJson)));
        }


        [HttpPost]
        [Route("GetMediaHome")]
        public HttpResponseMessage GetMediaHome(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGallery(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdStatusMediaHome")]
        public HttpResponseMessage UpdStatusMediaHome(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGallery(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMediaHome")]
        public HttpResponseMessage UpdMediaHome(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGallery(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMediaHome")]
        public HttpResponseMessage AddMediaHome(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGallery(ent.strJson)));
        }

        [HttpPost]
        [Route("DelMediaHome")]
        public HttpResponseMessage DelMediaHome(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGallery(ent.strJson)));
        }

        [HttpPost]
        [Route("GetConfigSite")]
        public HttpResponseMessage GetConfigSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }

        [HttpPost]
        [Route("AddConfigSite")]
        public HttpResponseMessage AddConfigSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdConfigSite")]
        public HttpResponseMessage UpdConfigSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdStatusConfigSite")]
        public HttpResponseMessage UpdStatusConfigSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }

        [HttpPost]
        [Route("DeleteConfigSite")]
        public HttpResponseMessage DeleteConfigSite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupportOnline")]
        public HttpResponseMessage GetListSupportOnline(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupport(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddSupportInfo")]
        public HttpResponseMessage AddSupportInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupport(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupportInfo")]
        public HttpResponseMessage UpdSupportInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupport(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdStatusSupportInfo")]
        public HttpResponseMessage UpdStatusSupportInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupport(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupportInfo")]
        public HttpResponseMessage DelSupportInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupport(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAdvertismentByAdmin")]
        public HttpResponseMessage GetListAdvertismentByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAdvertismentByAdmin")]
        public HttpResponseMessage AddAdvertismentByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAdvertismentByAdmin")]
        public HttpResponseMessage UpdAdvertismentByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdStatusAdsByAdmin")]
        public HttpResponseMessage UpdStatusAdsByAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAvdertisement")]
        public HttpResponseMessage DelAvdertisement(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.WI.busWebItoursys bus = new B2B.Bus.WI.busWebItoursys();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAdvertise(ent.strJson)));
        }

    }

}
