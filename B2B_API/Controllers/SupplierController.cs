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
    [RoutePrefix("api/supplier")]
    public class SupplierController : ApiController
    {
        

        [HttpPost]
        [Route("AddPriceItemForCopySeason")]
        public HttpResponseMessage AddPriceItemForCopySeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeForCompany")]
        public HttpResponseMessage GetListItemTypeForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        
        [HttpPost]
        [Route("AddOrUpdItemTypeHostAgentNotUsed")]
        public HttpResponseMessage AddOrUpdItemTypeHostAgentNotUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceListForCompany")]
        public HttpResponseMessage GetListPriceListForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrUpdPriceListHostAgentNotUsed")]
        public HttpResponseMessage AddOrUpdPriceListHostAgentNotUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        

        [HttpPost]
        [Route("AddOrUpdPriceBookingDate")]
        public HttpResponseMessage AddOrUpdPriceBookingDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListPriceBookingDate")]
        public HttpResponseMessage GetListPriceBookingDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdSupplierHostAgencyForComType")]
        public HttpResponseMessage UpdSupplierHostAgencyForComType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMenuListItemForMenuItem")]
        public HttpResponseMessage UpdMenuListItemForMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        
        [HttpPost]
        [Route("AddFocForImpMarket")]
        public HttpResponseMessage AddFocForImpMarket(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceSeasonByImpMarket")]
        public HttpResponseMessage AddPriceSeasonByImpMarket(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceSeasonForPriceList")]
        public HttpResponseMessage GetListPriceSeasonForPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceList")]
        public HttpResponseMessage GetListPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceList")]
        public HttpResponseMessage AddPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceList")]
        public HttpResponseMessage UpdPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceList")]
        public HttpResponseMessage DelPriceList(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItemTypeChildOption")]
        public HttpResponseMessage AddItemTypeChildOption(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeChildOptionForNoOfChild")]
        public HttpResponseMessage UpdItemTypeChildOptionForNoOfChild(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItemTypeChildOption")]
        public HttpResponseMessage DelItemTypeChildOption(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListLinkSupplierChildAge")]
        public HttpResponseMessage GetListLinkSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItemTypeChildOption")]
        public HttpResponseMessage GetListItemTypeChildOption(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListChildOption")]
        public HttpResponseMessage GetListChildOption(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckDateForFoc")]
        public HttpResponseMessage GetCheckDateForFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckDateForPriceSeasonDate")]
        public HttpResponseMessage GetCheckDateForPriceSeasonDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceSeasonByCalendar")]
        public HttpResponseMessage AddPriceSeasonByCalendar(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeDetailByAgent")]
        public HttpResponseMessage GetListItemTypeDetailByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMenuListItemForOrder")]
        public HttpResponseMessage UpdMenuListItemForOrder(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListMenuListItemForMenuListMaster")]
        public HttpResponseMessage GetListMenuListItemForMenuListMaster(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeForOrder")]
        public HttpResponseMessage UpdItemTypeForOrder(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItineraryForOrder")]
        public HttpResponseMessage UpdItineraryForOrder(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdSupplierMappingPriceForRefreshMarkupValue")]
        public HttpResponseMessage UpdSupplierMappingPriceForRefreshMarkupValue(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("AddPriceSeasonLevel")]
        public HttpResponseMessage AddPriceSeasonLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceSeasonLevel")]
        public HttpResponseMessage DelPriceSeasonLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierImageFile")]
        public HttpResponseMessage UpdSupplierImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierMappingPriceForRestaurantByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForRestaurantByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierByAgent")]
        public HttpResponseMessage GetListSupplierByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdSupplierMenuForEnable")]
        public HttpResponseMessage UpdSupplierMenuForEnable(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierMenuForItemType")]
        public HttpResponseMessage GetListSupplierMenuForItemType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceItemForDuplicate")]
        public HttpResponseMessage AddPriceItemForDuplicate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceItemForRT")]
        public HttpResponseMessage UpdPriceItemForRT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierMenu")]
        public HttpResponseMessage AddSupplierMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelSupplierMenu")]
        public HttpResponseMessage DelSupplierMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListMenuItem")]
        public HttpResponseMessage GetListMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddMenuItem")]
        public HttpResponseMessage AddMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdMenuItem")]
        public HttpResponseMessage UpdMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelMenuItem")]
        public HttpResponseMessage DelMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddMenuListItem")]
        public HttpResponseMessage AddMenuListItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelMenuListItem")]
        public HttpResponseMessage DelMenuListItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListMenuListMaster")]
        public HttpResponseMessage GetListMenuListMaster(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMenuListMaster")]
        public HttpResponseMessage AddMenuListMaster(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMenuListMaster")]
        public HttpResponseMessage UpdMenuListMaster(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelMenuListMaster")]
        public HttpResponseMessage DelMenuListMaster(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdSupplierMenu")]
        public HttpResponseMessage UpdSupplierMenu(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelSupplierMenuItem")]
        public HttpResponseMessage DelSupplierMenuItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetSupplierMenuItemBySupplierMenuGUID")]
        public HttpResponseMessage GetSupplierMenuItemBySupplierMenuGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListMenuByItemTypeGUID")]
        public HttpResponseMessage GetListMenuByItemTypeGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListPolicyNotes")]
        public HttpResponseMessage GetListPolicyNotes(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPolicyNotes")]
        public HttpResponseMessage AddPolicyNotes(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPolicyNotes")]
        public HttpResponseMessage UpdPolicyNotes(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPolicyNotes")]
        public HttpResponseMessage DelPolicyNotes(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAllotmentUsed")]
        public HttpResponseMessage GetListAllotmentUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListFoc")]
        public HttpResponseMessage GetListFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("AddFoc")]
        public HttpResponseMessage AddFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdFoc")]
        public HttpResponseMessage UpdFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelFoc")]
        public HttpResponseMessage DelFoc(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSurchargeDateForAgent")]
        public HttpResponseMessage GetListSurchargeDateForAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCarType")]
        public HttpResponseMessage GetListCarType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCarType")]
        public HttpResponseMessage AddCarType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCarType")]
        public HttpResponseMessage UpdCarType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCarType")]
        public HttpResponseMessage DelCarType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierVoucherByAgent")]
        public HttpResponseMessage GetListSupplierVoucherByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListVoucherImageFile")]
        public HttpResponseMessage GetListVoucherImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("AddVoucherImageFile")]
        public HttpResponseMessage AddVoucherImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelVoucherImageFile")]
        public HttpResponseMessage DelVoucherImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierVoucher")]
        public HttpResponseMessage GetListSupplierVoucher(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierForRegByB2bAd")]
        public HttpResponseMessage GetListSupplierForRegByB2bAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierMappingPriceForTransportByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForTransportByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierForTransportByAgent")]
        public HttpResponseMessage GetListSupplierForTransportByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierMappingPrice")]
        public HttpResponseMessage UpdSupplierMappingPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdPriceItemForTP")]
        public HttpResponseMessage UpdPriceItemForTP(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItineraryForImportSeason")]
        public HttpResponseMessage GetListItineraryForImportSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItinerary")]
        public HttpResponseMessage GetListItinerary(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItinerary")]
        public HttpResponseMessage AddItinerary(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItinerary")]
        public HttpResponseMessage UpdItinerary(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItinerary")]
        public HttpResponseMessage DelItinerary(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierMappingPriceForHotelByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForHotelByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListSupplierMappingPriceForFlightByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForFlightByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierMappingPriceForGuideByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForGuideByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierMappingPriceForBoatByAgent")]
        public HttpResponseMessage GetListSupplierMappingPriceForBoatByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierForHotelByAgent")]
        public HttpResponseMessage GetListSupplierForHotelByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierMappingForAgentHost")]
        public HttpResponseMessage GetListSupplierMappingForAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAllotmentDetailForIsCheckUnderAlmUser")]
        public HttpResponseMessage GetListAllotmentDetailForIsCheckUnderAlmUser(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentDetail")]
        public HttpResponseMessage GetListAllotmentDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentAdjustment")]
        public HttpResponseMessage GetListAllotmentAdjustment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }
        
        [HttpPost]
        [Route("AddAllotmentAdjustment")]
        public HttpResponseMessage AddAllotmentAdjustment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentItem")]
        public HttpResponseMessage GetListAllotmentItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAllotmentItem")]
        public HttpResponseMessage AddAllotmentItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }   

        [HttpPost]
        [Route("GetListItemTypeForAgentHost")]
        public HttpResponseMessage GetListItemTypeForAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierHostAgency")]
        public HttpResponseMessage DelSupplierHostAgency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierHostAgencyForImportSupp")]
        public HttpResponseMessage AddSupplierHostAgencyForImportSupp(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierMappingPriceForHotel")]
        public HttpResponseMessage UpdSupplierMappingPriceForHotel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListSupplierMappingPrice")]
        public HttpResponseMessage GetListSupplierMappingPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdPriceItemForHT")]
        public HttpResponseMessage UpdPriceItemForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("DelPriceListLink")]
        public HttpResponseMessage DelPriceListLink(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierChildAgeForImportSeason")]
        public HttpResponseMessage GetListSupplierChildAgeForImportSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceListLinkForChildImportSeason")]
        public HttpResponseMessage AddPriceListLinkForChildImportSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeForImportSeason")]
        public HttpResponseMessage GetListItemTypeForImportSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceListLinkForImportSeason")]
        public HttpResponseMessage AddPriceListLinkForImportSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceDate")]
        public HttpResponseMessage GetListPriceDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceDate")]
        public HttpResponseMessage AddPriceDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceDate")]
        public HttpResponseMessage UpdPriceDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceDate")]
        public HttpResponseMessage DelPriceDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPriceSeason")]
        public HttpResponseMessage GetListPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPriceSeason")]
        public HttpResponseMessage AddPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPriceSeason")]
        public HttpResponseMessage UpdPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceSeason")]
        public HttpResponseMessage DelPriceSeason(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierForIsEnable")]
        public HttpResponseMessage UpdSupplierForIsEnable(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeDetail")]
        public HttpResponseMessage UpdItemTypeDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListSupplierImageFile")]
        public HttpResponseMessage GetListSupplierImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("AddSupplierImageFile")]
        public HttpResponseMessage AddSupplierImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelSupplierImageFile")]
        public HttpResponseMessage DelSupplierImageFile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListItemTypeDetail")]
        public HttpResponseMessage GetListItemTypeDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSurchargePrice")]
        public HttpResponseMessage GetListSurchargePrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSurchargePrice")]
        public HttpResponseMessage AddSurchargePrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSurchargePrice")]
        public HttpResponseMessage UpdSurchargePrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSurchargePrice")]
        public HttpResponseMessage DelSurchargePrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierChildAge")]
        public HttpResponseMessage GetListSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierChildAge")]
        public HttpResponseMessage AddSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierChildAge")]
        public HttpResponseMessage UpdSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdSupplierChildAgeForBaseOn")]
        public HttpResponseMessage UpdSupplierChildAgeForBaseOn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelSupplierChildAge")]
        public HttpResponseMessage DelSupplierChildAge(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListSurchargeDate")]
        public HttpResponseMessage GetListSurchargeDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("AddSurchargeDate")]
        public HttpResponseMessage AddSurchargeDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSurchargeDate")]
        public HttpResponseMessage UpdSurchargeDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSurchargeDate")]
        public HttpResponseMessage DelSurchargeDate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }




        [HttpPost]
        [Route("GetListItemType")]
        public HttpResponseMessage GetListItemType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierForAgentHost")]
        public HttpResponseMessage GetListSupplierForAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdInfoSupplierForActiveRegister")]
        public HttpResponseMessage UpdInfoSupplierForActiveRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddInfoSupplierForMemberRegister")]
        public HttpResponseMessage AddInfoSupplierForMemberRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierVoucherPrice")]
        public HttpResponseMessage GetListSupplierVoucherPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierVoucherPrice")]
        public HttpResponseMessage AddSupplierVoucherPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierVoucherPrice")]
        public HttpResponseMessage UpdSupplierVoucherPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierVoucherPrice")]
        public HttpResponseMessage DelSupplierVoucherPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListVoucherCancellationPolicy")]
        public HttpResponseMessage GetListVoucherCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddVoucherCancellationPolicy")]
        public HttpResponseMessage AddVoucherCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdVoucherCancellationPolicy")]
        public HttpResponseMessage UpdVoucherCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelVoucherCancellationPolicy")]
        public HttpResponseMessage DelVoucherCancellationPolicy(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListVoucherPaymentTerm")]
        public HttpResponseMessage GetListVoucherPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddVoucherPaymentTerm")]
        public HttpResponseMessage AddVoucherPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdVoucherPaymentTerm")]
        public HttpResponseMessage UpdVoucherPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelVoucherPaymentTerm")]
        public HttpResponseMessage DelVoucherPaymentTerm(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListVoucherByLevel")]
        public HttpResponseMessage GetListVoucherByLevel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdVoucherByLevel")]
        public HttpResponseMessage UpdVoucherByLevel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPaymentTerm")]
        public HttpResponseMessage GetListSupplierPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierPaymentTerm")]
        public HttpResponseMessage AddSupplierPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierPaymentTerm")]
        public HttpResponseMessage UpdSupplierPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierPaymentTerm")]
        public HttpResponseMessage DelSupplierPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierCancellationPolicy")]
        public HttpResponseMessage GetListSupplierCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierCancellationPolicy")]
        public HttpResponseMessage AddSupplierCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierCancellationPolicy")]
        public HttpResponseMessage UpdSupplierCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierCancellationPolicy")]
        public HttpResponseMessage DelSupplierCancellationPolicy(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierPriceCostForHotelByAgentHost")]
        public HttpResponseMessage GetListSupplierPriceCostForHotelByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItemTypeForAddInSeasonHotel")]
        public HttpResponseMessage GetListItemTypeForAddInSeasonHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierPriceCostForSeasonHotel")]
        public HttpResponseMessage AddSupplierPriceCostForSeasonHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        //[HttpPost]
        //[Route("GetListPriceSeason")]
        //public HttpResponseMessage GetListPriceSeason(entCommond.entFilterData ent)
        //{
        //    B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
        //    return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        //}

        
        //[HttpPost]
        //[Route("AddPriceSeason")]
        //public HttpResponseMessage AddPriceSeason(entCommond.entFilterData ent)
        //{
        //    B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
        //    return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        //}

        
        //[HttpPost]
        //[Route("UpdPriceSeason")]
        //public HttpResponseMessage UpdPriceSeason(entCommond.entFilterData ent)
        //{
        //    B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
        //    return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        //}

        //[HttpPost]
        //[Route("DelPriceSeason")]
        //public HttpResponseMessage DelPriceSeason(entCommond.entFilterData ent)
        //{
        //    B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
        //    return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        //}

        [HttpPost]
        [Route("GetListPriceSeasonDate")]
        public HttpResponseMessage GetListPriceSeasonDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddPriceSeasonDate")]
        public HttpResponseMessage AddPriceSeasonDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdPriceSeasonDate")]
        public HttpResponseMessage UpdPriceSeasonDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelPriceSeasonDate")]
        public HttpResponseMessage DelPriceSeasonDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterDiscountVoucherCode")]
        public HttpResponseMessage GetFilterDiscountVoucherCode(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListDiscountVoucherCateForOrderBooking")]
        public HttpResponseMessage GetListDiscountVoucherCateForOrderBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        //-----------------MrHieu(12/06/2019)
        //[HttpPost]
        //[Route("GetListSupplier")]
        //public HttpResponseMessage GetListSupplier(entCommond.entFilterData ent)
        //{
        //    B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
        //    return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        //}
        //-----------------END(12/06/2019)

        [HttpPost]
        [Route("GetListSourceSupplier")]
        public HttpResponseMessage GetListSourceSupplier(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierForHotelInAd")]
        public HttpResponseMessage GetListSupplierForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevelSupplierForHotel")]
        public HttpResponseMessage GetListPriceLevelSupplierForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevelHotelInAd")]
        public HttpResponseMessage GetListPriceLevelHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPriceLevelBoatInAd")]
        public HttpResponseMessage GetListPriceLevelBoatInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPriceCostTransportInAd")]
        public HttpResponseMessage GetListPriceCostTransportInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevelTransportInAd")]
        public HttpResponseMessage GetListPriceLevelTransportInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        //-----------------MrHieu(22/07/2019)
        [HttpPost]
        [Route("GetListPriceLevelSupplierForTransport")]
        public HttpResponseMessage GetListPriceLevelSupplierForTransport(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdSupplierPriceLevelForTransport")]
        public HttpResponseMessage UpdSupplierPriceLevelForTransport(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------END(22/07/2019)

            
        //-----------------MrHieu(01/08/2019)
        [HttpPost]
        [Route("GetListPriceLevelSupplierForBoat")]
        public HttpResponseMessage GetListPriceLevelSupplierForBoat(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------END(01/08/2019)

        //-----------------MrHieu(05/08/2019)
        [HttpPost]
        [Route("GetListVoucher")]
        public HttpResponseMessage GetListVoucher(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUpdVoucher")]
        public HttpResponseMessage AddOrUpdVoucher(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelVoucher")]
        public HttpResponseMessage DelVoucher(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------END(05/08/2019)

        //-----------------MrHieu(14/08/2019)
        [HttpPost]
        [Route("GetListInfoSupplier")]
        public HttpResponseMessage GetListInfoSupplier(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdInfoSupplier")]
        public HttpResponseMessage UpdInfoSupplier(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------MrHieu - END(14/08/2019)

        //-----------------MrHieu(21/08/2019)
        [HttpPost]
        [Route("GetListInfoSupplierItemType")]
        public HttpResponseMessage GetListInfoSupplierItemType(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUdpInfoSupplierItemType")]
        public HttpResponseMessage AddOrUdpInfoSupplierItemType(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelInfoSupplierItemType")]
        public HttpResponseMessage DelInfoSupplierItemType(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------MrHieu - END(21/08/2019)

        //-----------------MrHieu(22/08/2019)
        [HttpPost]
        [Route("GetListInfoSupplierForTMS")]
        public HttpResponseMessage GetListInfoSupplierForTMS(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        //-----------------MrHieu - END(22/08/2019)

        [HttpPost]
        [Route("GetListItemTypeInAd")]
        public HttpResponseMessage GetListItemTypeInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUdpSupplierItemTypeInAd")]
        public HttpResponseMessage AddOrUdpSupplierItemTypeInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrDelItemTypeDetailForListCkbInAd")]
        public HttpResponseMessage AddOrDelItemTypeDetailForListCkbInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeDetailInAd")]
        public HttpResponseMessage UpdItemTypeDetailInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUdpPriceCostForHotelInAd")]
        public HttpResponseMessage AddOrUdpPriceCostForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddSupplierPriceCost")]
        public HttpResponseMessage AddSupplierPriceCost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdSupplierPriceCost")]
        public HttpResponseMessage UpdSupplierPriceCost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        [HttpPost]
        [Route("DelSupplierPriceCost")]
        public HttpResponseMessage DelSupplierPriceCost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierPriceLevel")]
        public HttpResponseMessage UpdSupplierPriceLevel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAllotmentForHotelInAd")]
        public HttpResponseMessage GetListAllotmentForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAllotmentForHotelInAd")]
        public HttpResponseMessage AddAllotmentForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentItemForHotelInAd")]
        public HttpResponseMessage GetListAllotmentItemForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAllotmentItemForHotelInAd")]
        public HttpResponseMessage AddAllotmentItemForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentDetailForHotelInAd")]
        public HttpResponseMessage GetListAllotmentDetailForHotelInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentDetailForHotel")]
        public HttpResponseMessage GetListAllotmentDetailForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPublishForHotel")]
        public HttpResponseMessage GetListSupplierPublishForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPublishForBoat")]
        public HttpResponseMessage GetListSupplierPublishForBoat(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierIsEnableByOwn")]
        public HttpResponseMessage UpdSupplierIsEnableByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierPriceLevelForHT")]
        public HttpResponseMessage UpdSupplierPriceLevelForHT(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierForBoatByOwn")]
        public HttpResponseMessage GetListSupplierForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItineraryForBoatByOwn")]
        public HttpResponseMessage GetListItineraryForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItineraryForBoatByOwn")]
        public HttpResponseMessage AddItineraryForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItineraryForBoatByOwn")]
        public HttpResponseMessage UpdItineraryForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItineraryForBoatByOwn")]
        public HttpResponseMessage DelItineraryForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItemTypeForBoatByOwn")]
        public HttpResponseMessage GetListItemTypeForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItemTypeForBoatByOwn")]
        public HttpResponseMessage AddItemTypeForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItemTypeForBoatByOwn")]
        public HttpResponseMessage UpdItemTypeForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelItemTypeForBoatByOwn")]
        public HttpResponseMessage DelItemTypeForBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBoatByOwn")]
        public HttpResponseMessage GetListBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBoatByOwn")]
        public HttpResponseMessage AddBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBoatByOwn")]
        public HttpResponseMessage UpdBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelBoatByOwn")]
        public HttpResponseMessage DelBoatByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]  
        [Route("AddSupplierFromSourceSupByOwn")]
        public HttpResponseMessage AddSupplierFromSourceSupByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSupplierForTSByOwn")]
        public HttpResponseMessage GetListSupplierForTSByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddSupplierTransportByOwn")]
        public HttpResponseMessage AddSupplierTransportByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUdpPriceCostForTransportByOwn")]
        public HttpResponseMessage AddOrUdpPriceCostForTransportByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPublishForTransport")]
        public HttpResponseMessage GetListSupplierPublishForTransport(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPriceCost")]
        public HttpResponseMessage GetListSupplierPriceCost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierPublishForVoucher")]
        public HttpResponseMessage GetListSupplierPublishForVoucher(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListItineraryByOwn")]
        public HttpResponseMessage GetListItineraryByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddItineraryByOwn")]
        public HttpResponseMessage AddItineraryByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdItineraryByOwn")]
        public HttpResponseMessage UpdItineraryByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetPriceLevelForTransportByPtn")]
        public HttpResponseMessage GetPriceLevelForTransportByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }
        // Mr Tien (04/08/2020)
        [HttpPost]
        [Route("GetDetailInfoSupplier")]
        public HttpResponseMessage GetDetailInfoSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetRoomBySupItemGUID")]
        public HttpResponseMessage GetRoomBySupItemGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UdpSupItemType")]
        public HttpResponseMessage UdpSupItemType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSupplierInfo")]
        public HttpResponseMessage UpdSupplierInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        // End (04/08/2020)

        // Mr Tien (05/08/2020)
        [HttpPost]
        [Route("AddSupplierInfo")]
        public HttpResponseMessage AddSupplierInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddSupItemType")]
        public HttpResponseMessage AddSupItemType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelSupplierByGUID")]
        public HttpResponseMessage DelSupplierByGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelItemType")]
        public HttpResponseMessage DelItemType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        // End (05/08/2020)

        // Tien (06/08/2020)

        [HttpPost]
        [Route("UpdSupplierInfoForCompany")]
        public HttpResponseMessage UpdSupplierInfoForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("UdpSupItemTypeForCompany")]
        public HttpResponseMessage UdpSupItemTypeForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("AddSupItemTypeForCompany")]
        public HttpResponseMessage AddSupItemTypeForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("DelItemTypeForCompany")]
        public HttpResponseMessage DelItemTypeForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetRoomBySupItemGUIDForCompany")]
        public HttpResponseMessage GetRoomBySupItemGUIDForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierByGUIDForCompany")]
        public HttpResponseMessage DelSupplierByGUIDForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        // End (06/08/2020)

        // Mr Tien (10/08/2020)

        [HttpPost]
        [Route("GetFilterDiscountVoucherCampaign")]
        public HttpResponseMessage GetFilterDiscountVoucherCampaign(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }


        [HttpPost]
        [Route("AddDiscountVoucherCampaign")]
        public HttpResponseMessage AddDiscountVoucherCampaign(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDiscountVoucherCate")]
        public HttpResponseMessage GetListDiscountVoucherCate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        [HttpPost]
        [Route("AddDiscountVoucherCate")]
        public HttpResponseMessage AddDiscountVoucherCate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdDiscountVoucherCampaign")]
        public HttpResponseMessage UpdDiscountVoucherCampaign(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCateIDForCompany")]
        public HttpResponseMessage GetListCateIDForCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdDiscountVoucherCate")]
        public HttpResponseMessage UpdDiscountVoucherCate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        // End (11/08/2020)

        // Mr Tien (11/08/2020)

        [HttpPost]
        [Route("DelDiscountVoucherCampaign")]
        public HttpResponseMessage DelDiscountVoucherCampaign(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        [HttpPost]
        [Route("DelDiscountVoucherCate")]
        public HttpResponseMessage DelDiscountVoucherCate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }



        [HttpPost]
        [Route("AddPartnerToDiscountVoucher")]
        public HttpResponseMessage AddPartnerToDiscountVoucher(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }


        [HttpPost]
        [Route("DelDiscountVoucherMember")]
        public HttpResponseMessage DelDiscountVoucherMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListDiscountVoucherMember")]
        public HttpResponseMessage GetListDiscountVoucherMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionVoucher(ent.strJson)));
        }


        [HttpPost]
        [Route("DelSupplierByGUIDForPngAdmin")]
        public HttpResponseMessage DelSupplierByGUIDForPngAdmin(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }



        // End (10/08/2020)

        [HttpPost]
        [Route("GetListInfoSupplierToImport")]
        public HttpResponseMessage GetListInfoSupplierToImport(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSupplier(ent.strJson)));
        }


        // End (10/08/2020)

        [HttpPost]
        [Route("GetListItemTypeByAgent")]
        public HttpResponseMessage GetListItemTypeByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        
        [HttpPost]
        [Route("GetLabelPriceTable")]
        public HttpResponseMessage GetLabelPriceTable(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetFilterSupplierPriceBySupGUID")]
        public HttpResponseMessage GetFilterSupplierPriceBySupGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }



        [HttpPost]
        [Route("GetSeasonPriceByPriceSeasonGUID")]
        public HttpResponseMessage GetSeasonPriceByPriceSeasonGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetDaySeasonPrice")]
        public HttpResponseMessage GetDaySeasonPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListDateSeason")]
        public HttpResponseMessage GetListDateSeason(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddDateSeasonPrice")]
        public HttpResponseMessage AddDateSeasonPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdDateSeasonPrice")]
        public HttpResponseMessage UpdDateSeasonPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelDateSeason")]
        public HttpResponseMessage DelDateSeason(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListBookingDateByPriceDateGUID")]
        public HttpResponseMessage GetListBookingDateByPriceDateGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterSeasonMaster")]
        public HttpResponseMessage GetFilterSeasonMaster(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingDate")]
        public HttpResponseMessage AddBookingDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdBookingDate")]
        public HttpResponseMessage UpdBookingDate(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelBookingDateByBookingDateGUID")]
        public HttpResponseMessage DelBookingDateByBookingDateGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSeasonPrice")]
        public HttpResponseMessage AddSeasonPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdSeasonPrice")]
        public HttpResponseMessage UpdSeasonPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("AddPriceItem")]
        public HttpResponseMessage AddPriceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListItemTypeBySeasonGUID")]
        public HttpResponseMessage GetListItemTypeBySeasonGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCabinByBoatGUID")]
        public HttpResponseMessage GetListCabinByBoatGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListBoatByItineraryGUID")]
        public HttpResponseMessage GetListBoatByItineraryGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListBoat")]
        public HttpResponseMessage GetListBoat(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdPrice")]
        public HttpResponseMessage UpdPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetPriceTypeByTypeCode")]
        public HttpResponseMessage GetPriceTypeByTypeCode(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdBoat")]
        public HttpResponseMessage UpdBoat(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBoat")]
        public HttpResponseMessage AddBoat(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("DelBoat")]
        public HttpResponseMessage DelBoat(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("AddDuplicatePriceItem")]
        public HttpResponseMessage AddDuplicatePriceItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListSupplierMappingPriceForTransPkg")]
        public HttpResponseMessage GetListSupplierMappingPriceForTransPkg(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSeasonDate")]
        public HttpResponseMessage GetListSeasonDate(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListSupplier")]
        public HttpResponseMessage GetListSupplier(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListSupplierMapping")]
        public HttpResponseMessage GetListSupplierMapping(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetFilterSupplier")]
        public HttpResponseMessage GetFilterSupplier(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdSupItemType")]
        public HttpResponseMessage UpdSupItemType(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelSupplierItem")]
        public HttpResponseMessage DelSupplierItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        
        [HttpPost]
        [Route("GetFilterListServiceByAllotment")]
        public HttpResponseMessage GetFilterListServiceByAllotment(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdAllotmentChangePax")]
        public HttpResponseMessage UpdAllotmentChangePax(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetMaxAllotmentUsedByItemGUID")]
        public HttpResponseMessage GetMaxAllotmentUsedByItemGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllotmentItemByGUID")]
        public HttpResponseMessage GetListAllotmentItemByGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("GetDetailAllotmentByGUID")]
        public HttpResponseMessage GetDetailAllotmentByGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }



        [HttpPost]
        [Route("GetFilterAllotment")]
        public HttpResponseMessage GetFilterAllotment(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddAllotment")]
        public HttpResponseMessage AddAllotment(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAllotment")]
        public HttpResponseMessage UpdAllotment(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }
        [HttpPost]
        [Route("DelAllotmentByGUID")]
        public HttpResponseMessage DelAllotmentByGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }
        [HttpPost]
        [Route("DelAllotmentItem")]
        public HttpResponseMessage DelAllotmentItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }
        [HttpPost]
        [Route("DelAllotmentDetail")]
        public HttpResponseMessage DelAllotmentDetail(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListAllotmentDetailByDate")]
        public HttpResponseMessage GetListAllotmentDetailByDate(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAllotment(ent.strJson)));
        }

        

        [HttpPost]
        [Route("GetSupplierTabConfig")]
        public HttpResponseMessage GetSupplierTabConfig(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdSupplierChildAgeForOrder")]
        public HttpResponseMessage UpdSupplierChildAgeForOrder(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetFilterMenuListMaster")]
        public HttpResponseMessage GetFilterMenuListMaster(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddImportMenuListMaster")]
        public HttpResponseMessage AddImportMenuListMaster(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddSupplierMenuItem")]
        public HttpResponseMessage AddSupplierMenuItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListMenuByMenuListMasterGUID")]
        public HttpResponseMessage GetListMenuByMenuListMasterGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterListMenuItem")]
        public HttpResponseMessage GetFilterListMenuItem(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListFunctionRoomStyle")]
        public HttpResponseMessage GetListFunctionRoomStyle(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddOrUpdFunctionRoomStyle")]
        public HttpResponseMessage AddOrUpdFunctionRoomStyle(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
        

        [HttpPost]
        [Route("DelFunctionRoomStyle")]
        public HttpResponseMessage DelFunctionRoomStyle(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }



        [HttpPost]
        [Route("GetFilterMarkupGroupPolicy")]
        public HttpResponseMessage GetFilterMarkupGroupPolicy(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetMarkupGroupPolicyDetailByGUID")]
        public HttpResponseMessage GetMarkupGroupPolicyDetailByGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMarkupGroup")]
        public HttpResponseMessage AddMarkupGroup(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMarkupGroup")]
        public HttpResponseMessage UpdMarkupGroup(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelMarkupGroup")]
        public HttpResponseMessage DelMarkupGroup(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMarkupGroupPolicy")]
        public HttpResponseMessage AddMarkupGroupPolicy(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdMarkupGroupPolicy")]
        public HttpResponseMessage UpdMarkupGroupPolicy(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("DelMarkupGroupPolicy")]
        public HttpResponseMessage DelMarkupGroupPolicy(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListPolicyMarkup")]
        public HttpResponseMessage GetListPolicyMarkup(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }
        [HttpPost]
        [Route("AddPolicyMarkupPrice")]
        public HttpResponseMessage AddPolicyMarkupPrice(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPolicyMarkupPrice")]
        public HttpResponseMessage UpdPolicyMarkupPrice(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPolicyMarkupByGUID")]
        public HttpResponseMessage DelPolicyMarkupByGUID(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPriceLevelForMarkupService")]
        public HttpResponseMessage GetListPriceLevelForMarkupService(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCopyPriceLevelForMarkupService")]
        public HttpResponseMessage AddCopyPriceLevelForMarkupService(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        [HttpPost]
        [Route("DelPriceLevelForMarkupService")]
        public HttpResponseMessage DelPriceLevelForMarkupService(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetFilterPriceList")]
        public HttpResponseMessage GetFilterPriceList(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrUpdPriceList")]
        public HttpResponseMessage AddOrUpdPriceList(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListMarkupGroupPolicy")]
        public HttpResponseMessage GetListMarkupGroupPolicy(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }

        

        [HttpPost]
        [Route("GetListMarkupGroup")]
        public HttpResponseMessage GetListMarkupGroup(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPriceSupp(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListRouteByAdmin")]
        public HttpResponseMessage GetListRouteByAdmin(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("AddRouteByAdmin")]
        public HttpResponseMessage AddRouteByAdmin(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("UdpRouteByAdmin")]
        public HttpResponseMessage UdpRouteByAdmin(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("DelRouteByAdmin")]
        public HttpResponseMessage DelRouteByAdmin(entCommond.entFilterData ent)
        {
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }
    }
}
