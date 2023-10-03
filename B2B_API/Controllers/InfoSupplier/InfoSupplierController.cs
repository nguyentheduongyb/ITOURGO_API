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
namespace B2B_API.Controllers.InfoSupplier
{
    [Authorize]
    [RoutePrefix("api/infosupp")]
    public class InfoSupplierController : ApiController
    {
        [HttpPost]
        [Route("GetMemberDetail")]
        public HttpResponseMessage GetMemberDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }
        
        [HttpPost]
        [Route("CheckMemberPassword")]
        public HttpResponseMessage CheckMemberPassword(B2B.Ent.CM.entUser ent)
        {
            var strJson = "{strMemberGUID:'" + ent.strMemberGUID + "'";
            strJson += ", strPassword:'" + CMSService.Encrypt(ent.strPassword) + "'";
            strJson += "}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(strJson)));
        }

        [HttpPost]
        [Route("UpdMemberPassword")]
        public HttpResponseMessage UpdMemberPassword(B2B.Ent.CM.entUser ent)
        {
            var strJson = "{strMemberGUID:'" + ent.strMemberGUID + "'";
            strJson += ", strNewPassword:'" + CMSService.Encrypt(ent.strNewPassword) + "'";
            strJson += ", strOldPassword:'" + CMSService.Encrypt(ent.strOldPassword) + "'";
            strJson += "}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(strJson)));
        }

        [HttpPost]
        [Route("GetListInfoSupplierForHT")]
        public HttpResponseMessage GetListInfoSupplierForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListInfoSupplierItemTypeForHT")]
        public HttpResponseMessage GetListInfoSupplierItemTypeForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItemTypeForHT")]
        public HttpResponseMessage AddItemTypeForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeForHT")]
        public HttpResponseMessage UpdItemTypeForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeDetailForHT")]
        public HttpResponseMessage UpdItemTypeDetailForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAmenities")]
        public HttpResponseMessage GetListAmenities(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddRoomFacility")]
        public HttpResponseMessage AddRoomFacility(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListFacilities")]
        public HttpResponseMessage GetListFacilities(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierFacility")]
        public HttpResponseMessage AddSupplierFacility(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSwimmingPool")]
        public HttpResponseMessage GetListSwimmingPool(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddSwimmingPool")]
        public HttpResponseMessage AddSwimmingPool(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSwimmingPool")]
        public HttpResponseMessage UpdSwimmingPool(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSpa")]
        public HttpResponseMessage GetListSpa(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSpa")]
        public HttpResponseMessage AddSpa(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdSpa")]
        public HttpResponseMessage UpdSpa(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListRestaurant")]
        public HttpResponseMessage GetListRestaurant(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddRestaurant")]
        public HttpResponseMessage AddRestaurant(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdRestaurant")]
        public HttpResponseMessage UpdRestaurant(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBanquet")]
        public HttpResponseMessage GetListBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBanquet")]
        public HttpResponseMessage AddBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBanquet")]
        public HttpResponseMessage UpdBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOutdoorBanquet")]
        public HttpResponseMessage GetListOutdoorBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddOutdoorBanquet")]
        public HttpResponseMessage AddOutdoorBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }
        

        [HttpPost]
        [Route("UpdOutdoorBanquet")]
        public HttpResponseMessage UpdOutdoorBanquet(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListInfoSupplierForBT")]
        public HttpResponseMessage GetListInfoSupplierForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdInfoSupplierForBT")]
        public HttpResponseMessage UpdInfoSupplierForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBoat")]
        public HttpResponseMessage GetListBoat(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBoat")]
        public HttpResponseMessage AddBoat(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBoat")]
        public HttpResponseMessage UpdBoat(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelBoat")]
        public HttpResponseMessage DelBoat(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeForBT")]
        public HttpResponseMessage GetListItemTypeForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItemTypeForBT")]
        public HttpResponseMessage AddItemTypeForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeForBT")]
        public HttpResponseMessage UpdItemTypeForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItemTypeForBT")]
        public HttpResponseMessage DelItemTypeForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItineraryForBT")]
        public HttpResponseMessage GetListItineraryForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItineraryForBT")]
        public HttpResponseMessage AddItineraryForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItineraryForBT")]
        public HttpResponseMessage UpdItineraryForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItineraryForBT")]
        public HttpResponseMessage DelItineraryForBT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionInfoSupplier(ent.strJson)));
        }


    }
}
