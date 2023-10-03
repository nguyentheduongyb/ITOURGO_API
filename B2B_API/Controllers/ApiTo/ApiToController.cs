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
using System.Net.Http.Headers;
using System.Web.Http;

namespace B2B_API.Controllers.ApiTo
{
    [Authorize]
    [RoutePrefix("api/connectto/tour")]
    public class ApiToTourController : ApiController
    {

        [HttpPost]
        [Route("AddNewTourFromB2B")]
        public HttpResponseMessage AddNewTourFromB2B(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, _AddNewTourFromB2B(ent.strJson));
        }
        static async System.Threading.Tasks.Task<object> _AddNewTourFromB2B(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            var arrUserNameandPassword = strAuthen.Split(':');

            var data = new entApiCommon.entJson();

            data.strJson1 = routes_list["strJson1"].ToString();
            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(GetHostTMS("api/connectfrom/tour/AddNewTourFromB2B"), c).ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        [Route("AddRequestServiceByAgent")]
        public HttpResponseMessage AddRequestServiceByAgent(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();

            DataSet ds = bus.ActionRequest(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, _AddSaleRequestFromB2B(ent.strJson, ds.Tables[0]));
        }
        static async System.Threading.Tasks.Task<object> _AddSaleRequestFromB2B(string _strJson,DataTable dt)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            if(strAuthen != "")
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

                var data = new entApiCommon.entJson();

                data.strJson1 = strJson;
                data.strHost = arrUserNameandPassword[2];
                HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
                HttpResponseMessage response = await client.PostAsync(GetHostTMS("api/connectfrom/tour/AddSaleRequestFromB2B"), c).ConfigureAwait(continueOnCapturedContext: false);

                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return false;
            }
        }


        [HttpPost]
        [Route("AddAgentRequest")]
        public HttpResponseMessage AddAgentRequest(entApiCommon.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            busApiCommon bus = new busApiCommon();
            DataSet ds = bus.ActionRequest(routes_list["strJson"].ToString());

            return Request.CreateResponse(HttpStatusCode.OK, _AddRequest(ent.strJson, ds.Tables[0]));
        }
        static async System.Threading.Tasks.Task<object> _AddRequest(string _strJson, DataTable dt)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            if (strAuthen != "")
            {

                var json_serializer2 = new System.Web.Script.Serialization.JavaScriptSerializer();
                var routes_list_2 = (IDictionary<string, object>)json_serializer2.DeserializeObject(routes_list["strJson"].ToString());

                //var intIndex = 0;
                var strJson = "";
                strJson += "{";
                //foreach (var record in routes_list_2)
                //{
                //    strJson += (intIndex == 0 ? "\"" : ",\"") + record.Key + "\":" + (record.Value == null ? "null" : "\"" + record.Value + "\"");

                //    intIndex++;
                //}
                foreach (DataColumn dc in dt.Columns)
                {
                    strJson += ",\"" + dc + "\":\"" + dt.Rows[0][dc].ToString().Replace(',', '.') + "\"";
                }

                strJson += "}";


                var arrUserNameandPassword = strAuthen.Split(':');

                var data = new entApiCommon.entJson();

                data.strJson1 = strJson;
                data.strHost = arrUserNameandPassword[2];
                HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
                HttpResponseMessage response = await client.PostAsync(GetHostTMS("api/connectfrom/tour/AddCustCareTicketFromB2B"), c).ConfigureAwait(continueOnCapturedContext: false);

                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return false;
            }
        }


        [HttpPost]
        [Route("GetListBookingTransToTMS")]
        public HttpResponseMessage GetListBookingTransToTMS(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            System.Data.DataSet ds = bus.ActionBooking(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMS(ds, "api/connectfrom/tour/AddOrUpdTourBaseTransFromB2B", routes_list["strCompanyGUID"].ToString()).Result);
        }


        [HttpPost]
        [Route("GetListAgentHostServiceTransToTMS")]
        public HttpResponseMessage GetListAgentHostServiceTransToTMS(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            System.Data.DataSet ds = bus.ActionAgtHostBooking(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMS(ds, "api/connectfrom/tour/AddOrUpdTourBaseByBookingTransFromB2B", routes_list["strCompanyGUID"].ToString()).Result);
        }


        public static string GetHostTMS(string strUrl)
        {
            var strHost = "https://demoapi.itoursys.com/";
            if (System.Web.HttpContext.Current.Request.Url.Authority.IndexOf("localhost") != -1)
                strHost = "http://localhost:4563/";
            return strHost + strUrl;
        }


        public static string GetDetailLoginToTMS(string _strCompanyGUID)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();

            var strJson = "{";
            strJson += "strCompanyGUID:'"+ _strCompanyGUID + "'";
            strJson += "}";

            System.Data.DataTable dt = bus.ActionMember(strJson).Tables[0];

            string strRtn = "";
            if(dt.Rows.Count > 0)
                strRtn = dt.Rows[0]["strCompanyGUID"].ToString() + ":" + dt.Rows[0]["strKeyAccessToken"].ToString() + ":" + dt.Rows[0]["strHostDBKey"].ToString();

            return strRtn;
        }
    }



    [Authorize]
    [RoutePrefix("api/connectto/management")]
    public class ApiToManagementController : ApiController
    {

        [HttpPost]
        [Route("AddOrUpdMemberAppKey")]
        public HttpResponseMessage AddOrUpdMemberAppKey(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            System.Data.DataSet ds = bus.ActionMember(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMS(ds, "api/connectfrom/management/AddOrUpdCompanyFromB2B", routes_list["strCompanyGUID"].ToString()).Result);
        }

    }


    [Authorize]
    [RoutePrefix("api/connectto/menu")]
    public class ApiToMenuController : ApiController
    {
        [HttpPost]
        [Route("GetListMenuByChangeLanguage")]
        public HttpResponseMessage GetListMenuByChangeLanguage(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, _GetListMenuByChangeLanguage(ent.strJson).Result);
        }
        static async System.Threading.Tasks.Task<object> _GetListMenuByChangeLanguage(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = CMSService.GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            var arrUserNameandPassword = strAuthen.Split(':');

            var data = new entApiCommon.entJson();

            data.strJson1 = routes_list["strJson1"].ToString();
            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(CMSService.GetHostTMS("api/connectfrom/menu/GetListMenuByChangeLanguage"), c).ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        [Route("AddOrUpdMenuMapping")]
        public HttpResponseMessage AddOrUpdMenuMapping(entApiCommon.entFilterData ent)
        {
            busApiCommon bus = new busApiCommon();

            return Request.CreateResponse(HttpStatusCode.OK, _AddOrUpdMenuMapping(ent.strJson).Result);
        }
        static async System.Threading.Tasks.Task<object> _AddOrUpdMenuMapping(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strAuthen = CMSService.GetDetailLoginToTMS(routes_list["strCompanyGUID"].ToString());

            var arrUserNameandPassword = strAuthen.Split(':');

            var data = new entApiCommon.entJson();

            data.strJson1 = routes_list["strJson1"].ToString();
            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(CMSService.GetHostTMS("api/connectfrom/menu/AddOrUpdMenuMapping"), c).ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsStringAsync();
        }


        [HttpPost]
        [Route("ExecSQL")]
        public HttpResponseMessage ExecSQL(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectfrom/menu/ExecSQL", routes_list["strCompanyGUID"].ToString()).Result);
        }
    }


    [RoutePrefix("api/connectto/supplier")]
    public class ApiToSupplierController : ApiController
    {
        [Authorize]
        [HttpPost]
        [Route("GetListSupplier")]
        public HttpResponseMessage GetListSupplier(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectfrom/supplier/GetListSupplier", routes_list["strCompanyGUID"].ToString()).Result);
        }


        [Authorize]
        [HttpPost]
        [Route("GetListSupplierMapping")]
        public HttpResponseMessage GetListSupplierMapping(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectfrom/supplier/GetListSupplierMapping", routes_list["strCompanyGUID"].ToString()).Result);
        }


        [Authorize]
        [HttpPost]
        [Route("GetListSupplierChildAge")]
        public HttpResponseMessage GetListSupplierChildAge(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectfrom/supplier/GetListSupplierChildAge", routes_list["strCompanyGUID"].ToString()).Result);
        }


        [Authorize]
        [HttpPost]
        [Route("UpdSupplierMappingForRefCodeTransFromB2B")]
        public HttpResponseMessage UpdSupplierMappingForRefCodeTransFromB2B(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectto/supplier/UpdSupplierMappingForRefCodeTransFromB2B", routes_list["strCompanyGUID"].ToString()).Result);
        }




        [Authorize]
        [HttpPost]
        [Route("UpdSupplierIsTransferToB2B")]
        public HttpResponseMessage UpdSupplierIsTransferToB2B(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectto/supplier/UpdSupplierIsTransferToB2B", routes_list["strCompanyGUID"].ToString()).Result);
        }


        [Authorize]
        [HttpPost]
        [Route("AddSupplierChildAge")]
        public HttpResponseMessage AddSupplierChildAge(entApiCommon.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMSBystrJSON(routes_list["strJson1"].ToString(), "api/connectfrom/supplier/AddSupplierChildAge", routes_list["strCompanyGUID"].ToString()).Result);
        }

        
        [TMSAuthorizationFilter]
        [HttpPost]
        [Route("GetDetailSupplierTranToTMS")]
        public HttpResponseMessage GetDetailSupplierTranToTMS(entApiCommon.entJson ent)
        {

            busApiCommon bus = new busApiCommon();
            System.Data.DataSet ds = bus.ActionStoreSupplier(ent.strJson1);
            
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.UpdTransferToTMS(ds, "api/connectfrom/supplier/AddSupplierTransFromB2B", ent.strCompanyGUID).Result);
        }
    }
}