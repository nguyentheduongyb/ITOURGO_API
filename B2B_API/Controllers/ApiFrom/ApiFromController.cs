using B2B.Bus.AB;
using B2B.Ent.AB;
using B2B_API.App_Start;
using B2B_API.Filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers.ApiFrom
{
    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/tour")]
    public class ApiFromTourController : ApiController
    {

        [HttpPost]
        [Route("AddNewTourFromTMS")]
        public HttpResponseMessage AddNewTourFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();


            var strJson = "";
            strJson += "{";
            strJson += " strCompanyGUID: '" + ent.strCompanyGUID + "', ";
            strJson += " strJson1: '"+ent.strJson1 + "' ";
            strJson += "}";

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionTour(strJson));
            //return Request.CreateResponse(HttpStatusCode.OK, ent.strJson2);
        }

        
        [HttpPost]
        [Route("AddTourTransFromTMS")]
        public HttpResponseMessage AddTourTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionTour_Json(ent));
            //return Request.CreateResponse(HttpStatusCode.OK, ent.strJson2);
        }
        [HttpPost]
        [Route("AddTourFixDepartTransFromTMS")]
        public HttpResponseMessage AddTourFixDepartTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionTour_Json(ent));
            //return Request.CreateResponse(HttpStatusCode.OK, ent.strJson2);
        }


        [HttpPost]
        [Route("AddPaxGroupTransFromTMS")]
        public HttpResponseMessage AddPaxGroupTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionMember_Json(ent));
            //return Request.CreateResponse(HttpStatusCode.OK, ent.strJson2);
        }

        
        [HttpPost]
        [Route("AddDealProgramTransFromTMS")]
        public HttpResponseMessage AddDealProgramTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionDeal_Json(ent));
        }
    }


    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/service")]
    public class ApiFromServiceController : ApiController
    {
        [HttpPost]
        [Route("GetWebMenu")]
        public HttpResponseMessage GetWebMenu(entApiCommon.entJson ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMenu(ent.strJson1)));
        }

        [HttpPost]
        [Route("GetListSupplierForHotelByAgent")]
        public HttpResponseMessage GetListSupplierForHotelByAgent(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson1)));
        }

        [HttpPost]
        [Route("GetListSupplierMappingPriceForHotelByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForHotelByAgent(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson1)));
        }

    }

    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/request")]
    public class ApiFromRequestController : ApiController
    {
        [HttpPost]
        [Route("GetListServiceItemBySaleReq")]
        public HttpResponseMessage GetListServiceItemBySaleReq(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson1)));
        }

        [HttpPost]
        [Route("GetListRequestMessage")]
        public HttpResponseMessage GetListRequestMessage(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(ent.strJson1)));
        }


        [HttpPost]
        [Route("AddRequestMessage")]
        public HttpResponseMessage AddRequestMessage(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(ent.strJson1)));
        }

        
        [HttpPost]
        [Route("AddCustomizeTourBySaleReq")]
        public HttpResponseMessage AddCustomizeTourBySaleReq(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson1)));
        }

        
        [HttpPost]
        [Route("AddSaleRequestFromTMS")]
        public HttpResponseMessage AddSaleRequestFromTMS(entApiCommon.entJson ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();

            var strJson = "";
            strJson += "{";
            strJson += " strUserGUID: null ";
            strJson += " ,strJson1: '" + ent.strJson1 + "' ";
            strJson += " ,strCompanyGUID: '" + ent.strCompanyGUID + "' ";
            strJson += "}";
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(strJson)));
        }

        
        [HttpPost]
        [Route("AddServiceItemFromTMS")]
        public HttpResponseMessage AddServiceItemFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase_Json(ent)));
        }

    }


    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/admin")]
    public class ApiFromAdminController : ApiController
    {
        [HttpPost]
        [Route("AddChildAgeTransFromTMS")]
        public HttpResponseMessage AddChildAgeTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionMember_Json(ent)); ;
        }

        
        [HttpPost]
        [Route("AddPriceLevelTransFromTMS")]
        public HttpResponseMessage AddPriceLevelTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionMember_Json(ent)); ;
        }
    }

    [RoutePrefix("api/connectfrom/guide")]
    public class ApiFromGuideController : ApiController
    {
        [HttpPost]
        [Route("AddGuideBookingFromTMS")]
        public HttpResponseMessage AddGuideBookingFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionGuide_Json(ent)));
        }
    }


    [RoutePrefix("api/connectfrom/log")]
    public class ApiFromLogController : ApiController
    {
        [HttpPost]
        [Route("AddErrorID")]
        public HttpResponseMessage AddErrorID(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSystem(ent.strJson1)));
        }
    }


    [RoutePrefix("api/connectfrom/lang")]
    public class ApiFromLangController : ApiController
    {
        [HttpPost]
        [Route("GetListAppLabel")]
        public HttpResponseMessage GetListAppLabel(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUpdAppLabel")]
        public HttpResponseMessage AddOrUpdAppLabel(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }
    }


    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/company")]
    public class ApiFromCompanyController : ApiController
    {
        [HttpPost]
        [Route("GetListAllowOriginHostFromTMS")]
        public HttpResponseMessage GetListAllowOriginHostFromTMS(entApiCommon.entJson ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            var strJson = "";
            strJson += "{";
            strJson += " strJson1: '" + ent.strJson1.Replace("'", "\'") + "' ";
            strJson += "}";
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(strJson)));
        }


    }


    [TMSAuthorizationFilter]
    [RoutePrefix("api/connectfrom/supplier")]
    public class ApiFromSupplierController : ApiController
    {
        [HttpPost]
        [Route("AddSupplierFromTMS")]
        public HttpResponseMessage AddSupplierFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionStoreSupplier_Json(ent));
        }

        
        [HttpPost]
        [Route("UpdSupplierByMappingFromTMS")]
        public HttpResponseMessage UpdSupplierByMappingFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionStoreSupplier_Json(ent));
        }


        [HttpPost]
        [Route("AddPriceSupplierTransFromTMS")]
        public HttpResponseMessage AddPriceSupplierTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionPriceSupp_Json(ent));
        }

        
        [HttpPost]
        [Route("AddMarkupGroupPolicyTransFromTMS")]
        public HttpResponseMessage AddMarkupGroupPolicyTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionPriceSupp_Json(ent));
        }


        [HttpPost]
        [Route("AddPriceForSuppTransFromTMS")]
        public HttpResponseMessage AddPriceForSuppTransFromTMS(entApiCommon.entJson ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionPriceSupp_Json(ent));
        }

    }


}