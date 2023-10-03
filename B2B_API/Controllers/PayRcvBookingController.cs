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
    [RoutePrefix("api/payrcvbooking")]
    public class PayRcvBookingController : ApiController
    {

        [HttpPost]
        [Route("GetListPayableBookingItemAdjustment")]
        public HttpResponseMessage GetListPayableBookingItemAdjustment(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOrUpdPayableBookingItemAdjustment")]
        public HttpResponseMessage AddOrUpdPayableBookingItemAdjustment(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPaidBankSlipUpload")]
        public HttpResponseMessage GetListPaidBankSlipUpload(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }
        [HttpPost]
        [Route("AddPaidBankSlipUpload")]
        public HttpResponseMessage AddPaidBankSlipUpload(B2B.Ent.SL.entCommond.entFilterData ent)
        {


            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strFile_PathRoot = Convert.ToString(routes_list["strFile_PathRoot"]);
            string strFile_Data = Convert.ToString(routes_list["strFile_Data"]);
            string strFile_Name = Convert.ToString(routes_list["strFile_Name"]);


            string path = "";
            path = "UpLoad/" + strFile_PathRoot + "/"+ DateTime.Now.ToString("yyyy/MM") + "/";
            if (!System.IO.Directory.Exists(CMSService.GetPath(path)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(path));
            }


            string strFileName = System.IO.Path.GetFileNameWithoutExtension(strFile_Name) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + System.IO.Path.GetExtension(strFile_Name);
            string strPathFileName = CMSService.GetPath(path + strFileName);

            Byte[] bytes = Convert.FromBase64String(strFile_Data);
            System.IO.File.WriteAllBytes(strPathFileName, bytes);

            var intIndex = 0;
            var strJson = "";
            strJson += "{";
            foreach (var record in routes_list)
            {
                if (!record.Key.Contains("File_") && !record.Key.Contains("dblPaidBankSlipUploadFileSize"))
                {

                    strJson += (intIndex == 0 ? "" : ",") + record.Key + ": " + (record.Value == null ? "null" : "'" + record.Value+ "'");

                    intIndex++;
                }
            }
            strJson += ",dblPaidBankSlipUploadFileSize: " + routes_list["dblPaidBankSlipUploadFileSize"].ToString().Replace(',','.') + "";
            strJson += ",strPaidBankSlipUploadFileLink: '" + path + strFileName + "'";
            strJson += "}";

            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(strJson)));
            //return Request.CreateResponse(HttpStatusCode.OK, strJson);
        }
        [HttpPost]
        [Route("DelPaidBankSlipUpload")]
        public HttpResponseMessage DelPaidBankSlipUpload(B2B.Ent.SL.entCommond.entFilterData ent)
        {


            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strPaidBankSlipUploadFileLink = Convert.ToString(routes_list["strPaidBankSlipUploadFileLink"]);
            System.IO.File.Delete(CMSService.GetPath(strPaidBankSlipUploadFileLink));


            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdPayableBookingItemForPaymentType")]
        public HttpResponseMessage UpdPayableBookingItemForPaymentType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPaidBookingItem")]
        public HttpResponseMessage GetListPaidBookingItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaidBookingItem")]
        public HttpResponseMessage AddPaidBookingItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaidBookingItem")]
        public HttpResponseMessage UpdPaidBookingItem(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPayableBookingItem")]
        public HttpResponseMessage GetListPayableBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPayableBookingItemByAgent")]
        public HttpResponseMessage GetListPayableBookingItemByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaidBookingItemByAgent")]
        public HttpResponseMessage GetListPaidBookingItemByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("AddOrUpdBookingToPayable")]
        public HttpResponseMessage AddOrUpdBookingToPayable(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdPaymentBookingPeriodForBankCheckingIsPaidByAgent")]
        public HttpResponseMessage UpdPaymentBookingPeriodForBankCheckingIsPaidByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaymentBookingPeriodForBankCheckingIsPaidByAgentHost")]
        public HttpResponseMessage UpdPaymentBookingPeriodForBankCheckingIsPaidByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportPayableBookingItemByAgent")]
        public HttpResponseMessage GetReportPayableBookingItemByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }





        [HttpPost]
        [Route("GetListReceivableBookingItem")]
        public HttpResponseMessage GetListReceivableBookingItem(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListReceivableBookingItemByAgentHost")]
        public HttpResponseMessage GetListReceivableBookingItemByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListReceivedBookingItemByAgentHost")]
        public HttpResponseMessage GetListReceivedBookingItemByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetReportReceivableBookingItemByAgentHost")]
        public HttpResponseMessage GetReportReceivableBookingItemByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAHBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOrUpdHoldToBookingPayable")]
        public HttpResponseMessage AddOrUpdHoldToBookingPayable(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCancellationTermByBookingItemGUID")]
        public HttpResponseMessage UpdCancellationTermByBookingItemGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCancellationTermByBookingGUID")]
        public HttpResponseMessage UpdCancellationTermByBookingGUID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionPayBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPayableBooking")]
        public HttpResponseMessage GetListPayableBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaidBooking")]
        public HttpResponseMessage GetListPaidBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddPaidBookingByAgentHost")]
        public HttpResponseMessage AddPaidBookingByAgentHost(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaymentBookingPeriod")]
        public HttpResponseMessage GetListPaymentBookingPeriod(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }
        
        [HttpPost]
        [Route("AddPaidComBooking")]
        public HttpResponseMessage AddPaidComBooking(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(ent.strJson)));
        }

    }
}
