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
    [RoutePrefix("api/booking")]
    public class BookingController : ApiController
    {
        [HttpPost]
        [Route("UpdBookingServiceForConfirm")]
        public HttpResponseMessage UpdBookingServiceForConfirm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
      
        [HttpPost]
        [Route("AddPayableBookingUsed")]
        public HttpResponseMessage AddPayableBookingUsed(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetBookingItemForConfirmedCode")]
        public HttpResponseMessage GetBookingItemForConfirmedCode(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingServiceForSupp")]
        public HttpResponseMessage GetListBookingServiceForSupp(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingItemForHotelByAgentHost")]
        public HttpResponseMessage AddBookingItemForHotelByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrderBookingForSupByRestaurant")]
        public HttpResponseMessage AddOrderBookingForSupByRestaurant(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingForHotelInstant")]
        public HttpResponseMessage AddBookingForHotelInstant(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("DelBookingItem")]
        public HttpResponseMessage DelBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdAgentBookingItemDetailForPrice")]
        public HttpResponseMessage UpdAgentBookingItemDetailForPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingItemForTourByAgentHost")]
        public HttpResponseMessage AddBookingItemForTourByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddNewBookingByAgentHost")]
        public HttpResponseMessage AddNewBookingByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportReceivableByAgent")]
        public HttpResponseMessage GetReportReceivableByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportPayableByAgentHost")]
        public HttpResponseMessage GetReportPayableByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportCommissionByAgent")]
        public HttpResponseMessage GetReportCommissionByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetReportCommissionByAgentHost")]
        public HttpResponseMessage GetReportCommissionByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckPaymentTransactionByAgent")]
        public HttpResponseMessage GetCheckPaymentTransactionByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaymentTransactionByAgent")]
        public HttpResponseMessage AddPaymentTransactionByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingServiceForBookingStatus")]
        public HttpResponseMessage UpdBookingServiceForBookingStatus(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdBookingItemForVoucherStatus")]
        public HttpResponseMessage UpdBookingItemForVoucherStatus(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingServiceForTourAddManual")]
        public HttpResponseMessage UpdBookingServiceForTourAddManual(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("DelBookingService")]
        public HttpResponseMessage DelBookingService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUpdBookingServiceTourDay")]
        public HttpResponseMessage AddOrUpdBookingServiceTourDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingServiceForTour")]
        public HttpResponseMessage GetListBookingServiceForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingServiceForTourAddManual")]
        public HttpResponseMessage AddBookingServiceForTourAddManual(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("AddBookingServiceForTourImportSupp")]
        public HttpResponseMessage AddBookingServiceForTourImportSupp(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetDashBoardByMonthYearAgent")]
        public HttpResponseMessage GetDashBoardByMonthYearAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("GetDashBoardByMonthYearAgentHost")]
        public HttpResponseMessage GetDashBoardByMonthYearAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingItemForTour")]
        public HttpResponseMessage AddBookingItemForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPassengerForBooking")]
        public HttpResponseMessage UpdPassengerForBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListBookingAgentHostByAgent")]
        public HttpResponseMessage GetListBookingAgentHostByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddAdjustmentBookingItemByAgentHost")]
        public HttpResponseMessage AddAdjustmentBookingItemByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingCancellationPolicyForBooking")]
        public HttpResponseMessage GetListBookingCancellationPolicyForBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckRemainCreditForPaymentBookingByAgent")]
        public HttpResponseMessage GetCheckRemainCreditForPaymentBookingByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetCheckRemainCreditByAgent")]
        public HttpResponseMessage GetCheckRemainCreditByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckRemainForServicesBooking")]
        public HttpResponseMessage GetCheckRemainForServicesBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingForChangeHoldToBook")]
        public HttpResponseMessage UpdBookingForChangeHoldToBook(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOrderBookingRoom")]
        public HttpResponseMessage GetListOrderBookingRoom(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAgentHostBooking")]
        public HttpResponseMessage GetListAgentHostBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }
        
        [HttpPost]
        [Route("GetDetailServiceForOrderBooking")]
        public HttpResponseMessage GetDetailServiceForOrderBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdOrderBookingForQuantity")]
        public HttpResponseMessage UpdOrderBookingForQuantity(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("DelOrderBookingItem")]
        public HttpResponseMessage DelOrderBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOrderPassenger")]
        public HttpResponseMessage GetListOrderPassenger(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrderPassenger")]
        public HttpResponseMessage AddOrderPassenger(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingForAllotmentUsed")]
        public HttpResponseMessage GetListBookingForAllotmentUsed(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingForVoucherUsed")]
        public HttpResponseMessage GetListBookingForVoucherUsed(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportBookingPayablePlatformFeeByAgentHost")]
        public HttpResponseMessage GetReportBookingPayablePlatformFeeByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrUpdBookingInvoiceByOwn")]
        public HttpResponseMessage AddOrUpdBookingInvoiceByOwn(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPayableBooking")]
        public HttpResponseMessage GetListPayableBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrderBookingAdjustmentForOrderBooking")]
        public HttpResponseMessage AddOrderBookingAdjustmentForOrderBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddRequestBookingByPtn")]
        public HttpResponseMessage AddRequestBookingByPtn(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdBookingInvoiceForCancellationPayment")]
        public HttpResponseMessage UpdBookingInvoiceForCancellationPayment(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingStatusCancellation")]
        public HttpResponseMessage UpdBookingStatusCancellation(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetBookingCancellationPolicyForPriceCharge")]
        public HttpResponseMessage GetBookingCancellationPolicyForPriceCharge(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingInvoiceForConfirmIsPaid")]
        public HttpResponseMessage UpdBookingInvoiceForConfirmIsPaid(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingInvoice")]
        public HttpResponseMessage AddBookingInvoice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAgentOrderBookingItemDetailForPrice")]
        public HttpResponseMessage UpdAgentOrderBookingItemDetailForPrice(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetPaymentBookingAmountAndPeriod")]
        public HttpResponseMessage GetPaymentBookingAmountAndPeriod(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingPaymentTermNoPaid")]
        public HttpResponseMessage GetListBookingPaymentTermNoPaid(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingInvoicePaid")]
        public HttpResponseMessage GetListBookingInvoicePaid(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        //---------------MrHieu(26/07/2019)
        [HttpPost]
        [Route("GetBookingTransferDataConfig")]
        public HttpResponseMessage GetBookingTransferDataConfig(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        //---------------END(26/07/2019)

        //---------------MrHieu(22/07/2019)
        [HttpPost]
        [Route("GetListReportBookingForClient")]
        public HttpResponseMessage GetListReportBookingForClient(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListReportBookingForPax")]
        public HttpResponseMessage GetListReportBookingForPax(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        //---------------END(22/07/2019)

        //---------------MrHieu(19/06/2019)
        [HttpPost]
        [Route("AddNewBooking")]
        public HttpResponseMessage AddNewBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        //---------------END(19/06/2019)
        //---------------MrHieu(22/06/2019)
        [HttpPost]
        [Route("GetListOrderBooking")]
        public HttpResponseMessage GetListOrderBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        //---------------END(22/06/2019)
        //---------------MrHieu(04/07/2019)
        [HttpPost]
        [Route("AddOrderBookingForTour")]
        public HttpResponseMessage AddOrderBookingForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrderBookingForSupByHotel")]
        public HttpResponseMessage AddOrderBookingForSupByHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrderBookingForSupByTransport")]
        public HttpResponseMessage AddOrderBookingForSupByTransport(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdPassengerForOrderBookingStep1")]
        public HttpResponseMessage UpdPassengerForOrderBookingStep1(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdOrderBookingStep1ByPassenger")]
        public HttpResponseMessage UpdOrderBookingStep1ByPassenger(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdOrderBookingStep1")]
        public HttpResponseMessage UpdOrderBookingStep1(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdOrderBookingStep2")]
        public HttpResponseMessage UpdOrderBookingStep2(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdOrderBookingStep3ByStatusHold")]
        public HttpResponseMessage UpdOrderBookingStep3ByStatusHold(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListBooking")]
        public HttpResponseMessage GetListBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        //---------------END(04/07/2019)

        [HttpPost]
        [Route("GetListBookingItem")]
        public HttpResponseMessage GetListBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingService")]
        public HttpResponseMessage GetListBookingService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingItemInAd")]
        public HttpResponseMessage GetListBookingItemInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingServiceInAd")]
        public HttpResponseMessage GetListBookingServiceInAd(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddBookingService")]
        public HttpResponseMessage AddBookingService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingService")]
        public HttpResponseMessage UpdBookingService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdBookingStatus")]
        public HttpResponseMessage UpdBookingStatus(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        //---------------MrHieu(08/07/2019)
        [HttpPost]
        [Route("AddNewInvoiceBooking")]
        public HttpResponseMessage AddNewInvoiceBooking(entCommond.entFilterData ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionBooking(ent.strJson));
        }
        //---------------END(08/07/2019)
        //---------------MrHieu(10/07/2019)
        [HttpPost]
        [Route("GetListInvoiceBooking")]
        public HttpResponseMessage GetListInvoiceBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdPaidInvoiceBooking")]
        public HttpResponseMessage UpdPaidInvoiceBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, bus.ActionBooking(ent.strJson));
        }
        [HttpPost]
        [Route("AddNewCartBooking")]
        public HttpResponseMessage AddNewCartBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListCartBooking")]
        public HttpResponseMessage GetListCartBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetTourServiceXMLForTMS")]
        public HttpResponseMessage GetTourServiceXMLForTMS(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrderBookingForSupTransport")]
        public HttpResponseMessage AddOrderBookingForSupTransport(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrderBookingForSupVoucher")]
        public HttpResponseMessage AddOrderBookingForSupVoucher(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetPaymentAmountAndPeriod")]
        public HttpResponseMessage GetPaymentAmountAndPeriod(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        // Tien (21/07/2020)

        [HttpPost]
        [Route("GetReportBookingProfitByOwn")]
        public HttpResponseMessage GetReportBookingProfitByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        // Tien (15/08/2020)
        [HttpPost]
        [Route("GetFilterRequestBooking")]
        public HttpResponseMessage GetFilterRequestBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        // End (15/08/2020)

        [HttpPost]
        [Route("GetListOrderBookingByAgentHost")]
        public HttpResponseMessage GetListOrderBookingByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOrderBookingItem")]
        public HttpResponseMessage GetListOrderBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOrderPaymentTerm")]
        public HttpResponseMessage GetListOrderPaymentTerm(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingFromOrderByAgent")]
        public HttpResponseMessage AddBookingFromOrderByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingFromTourByAgent")]
        public HttpResponseMessage AddBookingFromTourByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingFromRequestByAgentHost")]
        public HttpResponseMessage AddBookingFromRequestByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdOrderBookingItemForTour")]
        public HttpResponseMessage UpdOrderBookingItemForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingFromHotelByAgent")]
        public HttpResponseMessage AddBookingFromHotelByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaymentAmountForOrderItem")]
        public HttpResponseMessage GetListPaymentAmountForOrderItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdOrderBookingItemForHotel")]
        public HttpResponseMessage UpdOrderBookingItemForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }
        


        [HttpPost]
        [Route("AddBookingFromSaleRequest")]
        public HttpResponseMessage AddBookingFromSaleRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddAgentBooking")]
        public HttpResponseMessage AddAgentBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingFromTourByGuide")]
        public HttpResponseMessage AddBookingFromTourByGuide(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCartForTour")]
        public HttpResponseMessage AddCartForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListCartServiceItem")]
        public HttpResponseMessage GetListCartServiceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }



        [HttpPost]
        [Route("AddBookingForCart")]
        public HttpResponseMessage AddBookingForCart(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListPaymentAmountForCart")]
        public HttpResponseMessage GetListPaymentAmountForCart(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }
        

        [HttpPost]
        [Route("UpdCartForTour")]
        public HttpResponseMessage UpdCartForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCartServiceItem")]
        public HttpResponseMessage DelCartServiceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAgentHostServiceItem")]
        public HttpResponseMessage GetListAgentHostServiceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingForTour")]
        public HttpResponseMessage AddBookingForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdServiceItemForBookingStatus")]
        public HttpResponseMessage UpdServiceItemForBookingStatus(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddAgentBookingByCart")]
        public HttpResponseMessage AddAgentBookingByCart(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListAgentForGroup")]
        public HttpResponseMessage GetListAgentForGroup(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListAgentBookingServiceItem")]
        public HttpResponseMessage GetListAgentBookingServiceItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingForQuote")]
        public HttpResponseMessage AddBookingForQuote(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListBookingCom")]
        public HttpResponseMessage GetListBookingCom(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetReportProfitForDailyTour")]
        public HttpResponseMessage GetReportProfitForDailyTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetReportProfitForFixDepart")]
        public HttpResponseMessage GetReportProfitForFixDepart(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetReportProfitForPkgTour")]
        public HttpResponseMessage GetReportProfitForPkgTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportProfitByAgtHost")]
        public HttpResponseMessage GetReportProfitByAgtHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionReportBooking(ent.strJson)));
        }
        

        [HttpPost]
        [Route("AddCartForHotel")]
        public HttpResponseMessage AddCartForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCart(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingForHotel")]
        public HttpResponseMessage AddBookingForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }
    }
}
