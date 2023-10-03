using B2B.Bus.CM;
using B2B.Dat.SL;
using B2B.Ent.CM;
using B2B.Ent.SL;
using B2B_API.App_Start;
using B2B_API.Filter;
using B2B_API.Providers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers.Public
{
    [RoutePrefix("api/public")]
    public class PublicController : ApiController
    {

        [HttpPost]
        [Route("AddErrorID")]
        public HttpResponseMessage AddErrorID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionSystem(ent.strJson)));
        }

        [HttpPost]
        [Route("GetDetailSupport")]
        public HttpResponseMessage GetDetailSupport(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCommon(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckTaxCode")]
        public HttpResponseMessage GetCheckTaxCode(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetCheckTaxCode(ent.strJson).Result);

        }
        static async System.Threading.Tasks.Task<object> _GetCheckTaxCode(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strTaxCode = Convert.ToString(routes_list["strTaxCode"]);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://thongtindoanhnghiep.co/api/company/" + strTaxCode).ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsAsync<object>();
        }


        [HttpPost]
        [Route("GetInfoIP")]
        public HttpResponseMessage GetInfoIP(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetInfoIP(ent.strJson).Result);

        }
        static async System.Threading.Tasks.Task<object> _GetInfoIP(string _strJson)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://extreme-ip-lookup.com/json/?key=demo").ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsStringAsync();
        }

        [HttpPost]
        [Route("GetListInfoSupplier")]
        public HttpResponseMessage GetListInfoSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListClient")]
        public HttpResponseMessage GetListClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        //-------------MrHieu(07/10/2019)(1)
        [HttpPost]
        [Route("AddMemberRegister")]
        public HttpResponseMessage AddMemberRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [Route("GetSQLDataByTableConfig")]
        [HttpPost]
        public HttpResponseMessage GetSQLDataByTableConfig(B2B.Ent.CM.entCommond.entSystemPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busCommond bus = new busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(bus.GetSQLDataByTableConfig(ent.strTableName, ent.strFeildSelect, ent.strWhere)));
        }

        //-------------END(07/10/2019)(1)

        [HttpPost]
        [Route("GetListCurrency")]
        public HttpResponseMessage GetListCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetFilterLanguage")]
        public HttpResponseMessage GetFilterLanguage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionCountry(ent.strJson)));
        }

        // Tien 18/07/2020

        [HttpPost]
        [Route("GetEmailRegisterMember")]
        public HttpResponseMessage GetEmailRegisterMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        // End 18/07/2020


        [HttpPost]
        [Route("GetSendEmail")]
        public HttpResponseMessage GetSendEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strReturn = CMSService.SendEmail(routes_list["strUserGUID"].ToString(), Convert.ToString(routes_list["strEmailsSendTo"]), Convert.ToString(routes_list["strEmailsCC"]), Convert.ToString(routes_list["strEmailsBCC"]), routes_list["strSubject"].ToString(), routes_list["strBody"].ToString(), Convert.ToBoolean(routes_list["IsBodyHtml"]));

            return Request.CreateResponse(HttpStatusCode.OK, strReturn);
        }

        
        // Tien 11/08/2020

        [HttpPost]
        [Route("AddOnWebContact")]
        public HttpResponseMessage AddOnWebContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailOnWebContact")]
        public HttpResponseMessage GetEmailOnWebContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }



        // End 11/08/2020


        [HttpPost]
        [Route("GetEmailMemberConfirmed")]
        public HttpResponseMessage GetEmailMemberConfirmed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }



        [HttpPost]
        [Route("GetDetailMember")]
        public HttpResponseMessage GetDetailMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("SetPasswordDirectMember")]
        public HttpResponseMessage SetPasswordDirectMember(entUser ent)
        {
            busUser bus = new busUser();
            ent.strPassword = CMSService.Encrypt(ent.strPassword);
            string strResult = "0";
            strResult = bus.SetPasswordDirectMember(ent);
            return Request.CreateResponse(HttpStatusCode.OK, strResult);
        }

        // End 13/08/2020

        [HttpPost]
        [Route("GetDetaiPassengerRegister")]
        public HttpResponseMessage GetDetaiPassengerRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }




        [HttpPost]
        [Route("UpdPassengerPassword")]
        public HttpResponseMessage UpdPassengerPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strPassengerGUID:'" + Convert.ToString(routes_list["strPassengerGUID"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(strJson)));
        }


        // End 22/08/2020

        
        [HttpPost]
        [Route("GetEmailRegisterPassenger")]
        public HttpResponseMessage GetEmailRegisterPassenger(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailPricePassenger")]
        public HttpResponseMessage GetEmailPricePassenger(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }
        // End 24/08/2020


        [HttpPost]
        [Route("GetCheckAgentRegisterByEmail")]
        public HttpResponseMessage GetCheckAgentRegisterByEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckAgentRegisterByTaxCode")]
        public HttpResponseMessage GetCheckAgentRegisterByTaxCode(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckPassengerByEmail")]
        public HttpResponseMessage GetCheckPassengerByEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }


        [HttpPost]
        [Route("AddPassengerToRegister")]
        public HttpResponseMessage AddPassengerToRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTraveller(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterAgentHostByCodeInvite")]
        public HttpResponseMessage GetFilterAgentHostByCodeInvite(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailRegisterAgent")]
        public HttpResponseMessage GetEmailRegisterAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }
        

        [HttpPost]
        [Route("GetDetailAgentMember")]
        public HttpResponseMessage GetDetailAgentMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddRegisterMemberToAgent")]
        public HttpResponseMessage AddRegisterMemberToAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            //var strJson = "{strMemberRegisterGUID:'" + Convert.ToString(routes_list["strMemberRegisterGUID"]) + "', strPassword:'" + Convert.ToString(strPassword) + "',}";
            var strJson = "{";
            foreach (var record in routes_list)
            {
                if (record.Key != "strPassword")
                {
                    strJson += "," + record.Key + ":" + (record.Value == null ? "null" : "\"" + record.Value + "\"");
                }
            }
            strJson += ", strPassword:\"" + Convert.ToString(strPassword) + "\"";
            strJson += "}";
            strJson = strJson.Replace("{,", "{");

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(strJson)));
        }


        [HttpPost]
        [Route("UpdResetPassword")]
        public HttpResponseMessage UpdResetPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strPassword = CMSService.Encrypt(Convert.ToString(routes_list["strPassword"]));

            var strJson = "{strEmail:'" + Convert.ToString(routes_list["strEmail"]) + "', strPassword:'" + Convert.ToString(strPassword) + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(strJson)));
        }



        [HttpPost]
        [Route("GetCheckResetPasswordByEmail")]
        public HttpResponseMessage GetCheckResetPasswordByEmail(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailResetPasswordAgent")]
        public HttpResponseMessage GetEmailResetPasswordAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailResetPasswordAgentHost")]
        public HttpResponseMessage GetEmailResetPasswordAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailRegisterAgentHost")]
        public HttpResponseMessage GetEmailRegisterAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailRegisterPassengerHomePage")]
        public HttpResponseMessage GetEmailRegisterPassengerHomePage(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }





        [HttpPost]
        [Route("GetEmailSendRequestLinkAgentHost")]
        public HttpResponseMessage GetEmailSendRequestLinkAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetEmailActiveLinkAgentHost")]
        public HttpResponseMessage GetEmailActiveLinkAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailAgentHostSendRequestLinkToClient")]
        public HttpResponseMessage GetEmailAgentHostSendRequestLinkToClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListBooking")]
        public HttpResponseMessage GetListBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListBookingService")]
        public HttpResponseMessage GetListBookingService(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionBooking(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListSupplierForAgentHost")]
        public HttpResponseMessage GetListSupplierForAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionStoreSupplier(ent.strJson)));
        }

        // End 29/08/2020

        [Route("GetComboboxByCode")]
        [HttpPost]
        public HttpResponseMessage GetComboboxByCode(B2B.Ent.CM.entCommond.entFilterData ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busUser bus = new busUser();
            return Request.CreateResponse(HttpStatusCode.OK, datCommond.GetComboboxByCode(ent.strCombocode, ent.strWhere));
        }


        [HttpPost]
        [Route("GetEmailSendGuestContactByPublic")]
        public HttpResponseMessage GetEmailSendGuestContactByPublic(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetEmailSendRegisterEmailByPublic")]
        public HttpResponseMessage GetEmailSendRegisterEmailByPublic(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }


        [HttpPost]
        [Route("GetEmailSendConfirmToPax")]
        public HttpResponseMessage GetEmailSendConfirmToPax(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionTemplate(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAgentByPUB")]
        public HttpResponseMessage GetListAgentByPUB(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetValueByURL")]
        public HttpResponseMessage GetLang(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetValueByURL(ent.strJson).Result);

        }
        static async System.Threading.Tasks.Task<object> _GetValueByURL(string _strJson)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(routes_list["strUrl"].ToString()).ConfigureAwait(continueOnCapturedContext: false);

            return await response.Content.ReadAsStringAsync();
        }



        [HttpPost]
        [Route("TestFireBase")]
        public HttpResponseMessage TestFireBase(B2B.Ent.CM.entCommond.entFilterData ent)
        {

            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.DocumentReference Doc = database.Collection("itl-channel").Document("myDoc");

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "Fistname", "abc"}
            };

            Doc.SetAsync(data);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }


        //[HttpPost]
        //[Route("GetTestFireBase")]
        //public HttpResponseMessage GetTestFireBase(B2B.Ent.CM.entCommond.entFilterData ent)
        //{

        //    return Request.CreateResponse(HttpStatusCode.OK, Get_ALL().Result);
        //}

        [HttpPost]
        [Route("GetDetailQueue")]
        public HttpResponseMessage GetDetailQueue(B2B.Ent.SL.entCommond.entFilterDataChkRemain ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);


            var strQueueSerCode = routes_list["strQueueSerCode"].ToString();
            Dictionary<string, object> objDetail = new Dictionary<string, object>();

            objDetail = CMSService.FsDB_GetDetailDocAsync("png_Booking_listQueue", strQueueSerCode).Result;

            var str = "";
            if (objDetail.Count > 0)
            {
                str = objDetail["IsBooking"].ToString();
            }
            else
            {

            }

            return Request.CreateResponse(HttpStatusCode.OK, str);

        }

        [HttpPost]
        [Route("GetCheckQueue")]
        public HttpResponseMessage GetCheckQueue(B2B.Ent.SL.entCommond.entFilterDataChkRemain ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strQueueCode = ent.strQueueCode;
            var strListSerCode = ent.strListSerCode;
            var strTest = "";
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.Query qref = database.Collection("png_Booking_listQueue");

            if (String.IsNullOrEmpty(strQueueCode))
            {
                strQueueCode = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds() + "_" + System.Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
            }

            if (String.IsNullOrEmpty(strListSerCode))
            {
                DataTable dt = GetListSerCodeChkRemain().Tables[0];
                strListSerCode = dt.Rows[0]["strListSerCode"].ToString();
            }

            bool IsLastBook = false;
            bool IsNotBook = false;

            var strSplit = strListSerCode.Split('#');
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i].ToString() != "")
                {
                    var strSplit_2 = strSplit[i].Split('!');

                    bool IsCheck = false;
                    string strQueueSerCode = strQueueCode + "_" + strSplit_2[0];
                    Dictionary<string, object> objDetail = new Dictionary<string, object>();

                    objDetail = CMSService.FsDB_GetDetailDocAsync("png_Booking_listQueue", strQueueSerCode).Result;

                    if (objDetail.Count == 0)
                    {

                        Dictionary<string, object> data = new Dictionary<string, object>()
                        {
                            { "strCode", strQueueCode},
                            { "strSerCode", strSplit_2[0]},
                            { "IsBooking", 0},
                            { "dtmCreatedDate", DateTime.Now.ToString("yyyyMMddHHmmss")},
                        };
                        var a = CMSService.FsDB_AddDocAsync("png_Booking_listQueue", strQueueSerCode, data).Result;

                        IsCheck = true;
                    }
                    else
                    {
                        if (Convert.ToInt16(objDetail["IsBooking"].ToString()) == 1)
                        {

                        }
                        else
                        {
                            IsCheck = true;
                        }
                    }

                    if (IsCheck)
                    {
                        var IsDone = GetCheckQueue(strSplit_2[0], strQueueCode).Result;

                        if (IsDone.ToString() == "1")
                        {
                            DataTable dt_2 = GetRemainBySerCodeChk("{\"strSerCode\":\"" + strSplit_2[0] + "\"}").Tables[0];

                            if (Convert.ToInt32(dt_2.Rows[0]["intRemain"].ToString()) >= Convert.ToInt32(strSplit_2[1]))
                            {
                                Dictionary<string, object> data_2 = new Dictionary<string, object>()
                                {
                                    { "IsBooking", 1}
                                };

                                var a_2 = CMSService.FsDB_UpdDocAsync("png_Booking_listQueue", strQueueSerCode, data_2).Result;
                            }
                            else
                            {
                                var a_2 = CMSService.FsDB_DelDocAsync("png_Booking_listQueue", strQueueSerCode).Result;
                                IsNotBook = true;
                            }
                        }
                        else
                        {
                            IsLastBook = true;
                        }
                    }
                    


                }
            }

            if (IsNotBook)
            {
                for (int i = 0; i < strSplit.Length; i++)
                {
                    if (strSplit[i].ToString() != "")
                    {
                        var strSplit_2 = strSplit[i].Split('!');

                        string strQueueSerCode = strQueueCode + "_" + strSplit_2[0];

                        var a_2 = CMSService.FsDB_DelDocAsync("png_Booking_listQueue", strQueueSerCode);

                    }
                }

                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    { "strMess", "Not Book"},
                };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            else
            {
                if (IsLastBook)
                {
                    Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        { "strMess", "Last Book "+strTest},
                        { "strQueueCode", strQueueCode},
                        { "strListSerCode", strListSerCode},
                    };
                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                else
                {
                    for (int i = 0; i < strSplit.Length; i++)
                    {
                        if (strSplit[i].ToString() != "")
                        {
                            var strSplit_2 = strSplit[i].Split('!');

                            string strQueueSerCode = strQueueCode + "_" + strSplit_2[0];

                            try
                            {
                                GetTestBooking("{\"strSerCode\":\"" + strSplit_2[0] + "\",\"intQuantity\":\"" + strSplit_2[1] + "\"}");
                            }
                            finally
                            {
                                var a_2 = CMSService.FsDB_DelDocAsync("png_Booking_listQueue", strQueueSerCode).Result;
                            }

                        }
                    }

                    Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        { "strMess", ""},
                    };
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
            }

            

            //Dictionary<string, object> data = new Dictionary<string, object>()
            //{
            //    { "strCode", strQueueCode},
            //    { "strSerCode", "030303"},
            //    { "IsBooking", 0},
            //    { "dtmCreatedDate", DateTime.Now.ToString("yyyyMMddHHmmss")},
            //};
            //var a = CMSService.FsDB_AddDocAsync("png_Booking_listQueue", strQueueCode, data);






        }


        async System.Threading.Tasks.Task<string> GetCheckQueue(string _strSerCode, string _strQueueCode)
        {
            string IsDone = "0";
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.Query qref = database.Collection("png_Booking_listQueue");
            Google.Cloud.Firestore.QuerySnapshot snap = await qref.WhereEqualTo("strSerCode", _strSerCode).OrderBy("strCode").Limit(1).GetSnapshotAsync().ConfigureAwait(continueOnCapturedContext: false);
            string strCode = "";
            foreach (Google.Cloud.Firestore.DocumentSnapshot docsnap in snap)
            {
                if (docsnap.Exists)
                {
                    Dictionary<string, object> abc = docsnap.ToDictionary();
                    //str += abc["strCode"];
                    strCode = abc["strCode"].ToString();
                    if (abc["strCode"].ToString() == _strQueueCode)
                    {
                        IsDone = "1";
                    }
                }
            }
            return IsDone+"_"+ strCode;
        }



        [HttpPost]
        [Route("GetApiWaitQueue")]
        public HttpResponseMessage GetApiWaitQueue(B2B.Ent.SL.entCommond.entFilterDataChkRemain ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var str = GetWaitQueue();

            return Request.CreateResponse(HttpStatusCode.OK, str);

        }

        string GetWaitQueue()
        {
            string IsDone = "";
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.CollectionReference qref = database.Collection("png_Booking_listTour");
            Google.Cloud.Firestore.FirestoreChangeListener listener = qref.Listen(snapshot =>
            {
                foreach (Google.Cloud.Firestore.DocumentChange change in snapshot.Changes)
                {
                    if (change.ChangeType.ToString() == "Added")
                    {
                        //console.writeline("new customer: {0}", change.document.id);
                    }
                    else if (change.ChangeType.ToString() == "Modified")
                    {
                        IsDone = change.Document.Id;
                    }
                    //else if (change.ChangeType.ToString() == "removed")
                    //{
                    //    console.writeline("removed customer: {0}", change.document.id);
                    //}
                }
            });
            while (String.IsNullOrEmpty(IsDone))
            {

            }
            return IsDone;
        }

        public DataSet GetListSerCodeChkRemain(string _strJson = "{}")
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return bus.ActionAgtHostBooking(_strJson);
        }
        public DataSet GetRemainBySerCodeChk(string _strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return bus.ActionAgtHostBooking(_strJson);
        }
        public string GetTestBooking(string _strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return CMSService.ConvertDataSetToArray(bus.ActionAgtHostBooking(_strJson));
        }

        
            

        [HttpPost]
        [Route("AddTestFireBase")]
        public HttpResponseMessage AddTestFireBase(B2B.Ent.CM.entCommond.entFilterData ent)
        {

            var strQueueCode = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds() + "_" + System.Guid.NewGuid().ToString().Substring(0, 6).ToUpper();

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "strCode", strQueueCode},
                { "strSerCode", "030303"},
                { "intQuantity", 10},
                { "IsHold", 0},
                { "dtmCreatedDate", DateTime.Now.ToString("yyyyMMddHHmmss")},
            };
            
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.FsDB_AddDocAsync("png_Booking_listQueue", strQueueCode, data));
        }

        [HttpPost]
        [Route("UpdTestFireBase")]
        public HttpResponseMessage UpdTestFireBase(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strQueueCode = routes_list["strQueueCode"].ToString();

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "IsHold", 1}
            };

            var a = CMSService.FsDB_UpdDocAsync("png_Booking_listQueue", strQueueCode, data);
            
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }


        [HttpPost]
        [Route("DelTestFireBase")]
        public HttpResponseMessage DelTestFireBase(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            var strQueueCode = routes_list["strQueueCode"].ToString();

            var a = CMSService.FsDB_DelDocAsync("png_Booking_listQueue", strQueueCode);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }

    }

}
