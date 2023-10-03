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
using System.Net.Http.Headers;

namespace B2B_API.Controllers
{   
    [Authorize]
    [RoutePrefix("api/request")]
    public class RequestController : ApiController
    {

        [HttpPost]
        [Route("GetListRequestRespond")]
        public HttpResponseMessage GetListRequestRespond(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddRequestRespond")]
        public HttpResponseMessage AddRequestRespond(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListRequestService")]
        public HttpResponseMessage GetListRequestService(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        [HttpPost]
        [Route("AddRequestServiceByAgent")]
        public HttpResponseMessage AddRequestServiceByAgent(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }   

        //------------------MrHieu(16/07/2019)
        [HttpPost]
        [Route("AddRequest")]
        public HttpResponseMessage AddRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddRequestReply")]
        public HttpResponseMessage AddRequestReply(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        //----------------MrHieu(19/07/2019)
        [HttpPost]
        [Route("GetListRequestQuote")]
        public HttpResponseMessage GetListRequestQuote(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUpdRequestQuote")]
        public HttpResponseMessage AddOrUpdRequestQuote(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("DelRequestQuote")]
        public HttpResponseMessage DelRequestQuote(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListRequestDay")]
        public HttpResponseMessage GetListRequestDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddRequestDay")]
        public HttpResponseMessage AddRequestDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdFromTourModuleToRequestDay")]
        public HttpResponseMessage UpdFromTourModuleToRequestDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("DelRequestDay")]
        public HttpResponseMessage DelRequestDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListRequestReply")]
        public HttpResponseMessage GetListRequestReply(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        //----------------END(19/07/2019)

        //----------------MrHieu(08/08/2019)
        [HttpPost]
        [Route("GetListTourModule")]
        public HttpResponseMessage GetListTourModule(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTourModule")]
        public HttpResponseMessage AddTourModule(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("UdpTourModule")]
        public HttpResponseMessage UdpTourModule(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTourModule")]
        public HttpResponseMessage DelTourModule(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListTourModuleDays")]
        public HttpResponseMessage GetListTourModuleDays(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        [HttpPost]
        [Route("AddOrUdpTourModuleDay")]
        public HttpResponseMessage AddOrUdpTourModuleDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTourModuleDay")]
        public HttpResponseMessage DelTourModuleDay(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }
        //----------------END(08/08/2019)

        [HttpPost]
        [Route("GetListAgentRequest")]
        public HttpResponseMessage GetListAgentRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }




        [HttpPost]
        [Route("AddAgentRequest")]
        public HttpResponseMessage AddAgentRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAgentRequestForDone")]
        public HttpResponseMessage UpdAgentRequestForDone(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        //----------------END(10/09/2019)


        
        [HttpPost]
        [Route("AddBookingRequestForTour")]
        public HttpResponseMessage AddBookingRequestForTour(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListBookingRequest")]
        public HttpResponseMessage GetListBookingRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetDetailBookingRequest")]
        public HttpResponseMessage GetDetailBookingRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdBookingRequestByRequestProcessID")]
        public HttpResponseMessage UpdBookingRequestByRequestProcessID(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingRequestForHotel")]
        public HttpResponseMessage AddBookingRequestForHotel(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListSaleRequest")]
        public HttpResponseMessage GetListSaleRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(ent.strJson)));
        }


        [HttpPost]
        [Route("AddSaleRequest")]
        public HttpResponseMessage AddSaleRequest(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();

            DataSet ds = bus.ActionSaleReq(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, _AddSaleRequestFromB2B(ent.strJson, ds.Tables[0]));
        }


        static async System.Threading.Tasks.Task<object> _AddSaleRequestFromB2B(string _strJson, DataTable dt)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = CMSService.GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            if (strAuthen != "")
            {
                var intIndex = 0;
                var strJson = "";
                strJson += "{";
                foreach (var record in routes_list)
                {
                    strJson += (intIndex == 0 ? "\"" : ",\"") + record.Key + "\":" + (record.Value == null ? "null" : "\"" + record.Value + "\"");

                    intIndex++;
                }
                foreach (DataColumn dc in dt.Columns)
                {
                    strJson += ",\"" + dc + "\":\"" + dt.Rows[0][dc].ToString().Replace(',', '.') + "\"";
                }

                strJson += "}";


                var arrUserNameandPassword = strAuthen.Split(':');

                var data = new B2B.Ent.AB.entApiCommon.entJson();

                data.strJson1 = strJson;
                data.strHost = arrUserNameandPassword[2];
                HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
                HttpResponseMessage response = await client.PostAsync(CMSService.GetHostTMS("api/connectfrom/tour/AddSaleRequestFromB2B"), c).ConfigureAwait(continueOnCapturedContext: false);

                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return false;
            }
        }



        [HttpPost]
        [Route("GetListServiceItemBySaleReq")]
        public HttpResponseMessage GetListServiceItemBySaleReq(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCustomizeTourBySaleReq")]
        public HttpResponseMessage AddCustomizeTourBySaleReq(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListRequestMessage")]
        public HttpResponseMessage GetListRequestMessage(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(ent.strJson)));
        }


        [HttpPost]
        [Route("AddRequestMessage")]
        public HttpResponseMessage AddRequestMessage(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSaleReq(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListServiceItemPriceDetail")]
        public HttpResponseMessage GetListServiceItemPriceDetail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdServiceItemPriceDetailForPrice")]
        public HttpResponseMessage UpdServiceItemPriceDetailForPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTourBase(ent.strJson)));
        }


        [HttpPost]
        [Route("AddBookingRequestForTransport")]
        public HttpResponseMessage AddBookingRequestForTransport(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }

        
        [HttpPost]
        [Route("AddBookingRequestForBoat")]
        public HttpResponseMessage AddBookingRequestForBoat(entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionRequest(ent.strJson)));
        }


    }
}
