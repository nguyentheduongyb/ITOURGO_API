using Aspose.Words;
using B2B.Bus.CM;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace B2B_API.App_Start
{
    //APP DEVELOPMENT BY 

    public class CMSService
    {
        public static string ClearSQLInject(string strSQL)
        {
            strSQL = strSQL.Replace("'", "''");
            return strSQL;
        }
        public static string AutoBindTable(System.Data.DataTable t)
        {
            string strReturn = "<div class='table-scrollable'>";
            strReturn = strReturn + "<table class='table table-striped table-bordered table-hover table-checkable order-column dataTable'>";
            strReturn = strReturn + "<thead><tr>";
            foreach (System.Data.DataColumn item in t.Columns)
            {
                strReturn = strReturn + "<th>" + item.ColumnName + "</th>";
            }
            strReturn = strReturn + "</tr></thead><tbody>";


            for (int j = 0; j < t.Rows.Count; j++)
            {
                strReturn = strReturn + "<tr>";
                for (int i = 0; i < t.Columns.Count; i++)
                {
                    strReturn = strReturn + "<td>" + t.Rows[j][i].ToString() + "</td>";
                }
                strReturn = strReturn + "</tr>";
            }

            strReturn = strReturn + "</tbody</table>";
            strReturn = strReturn + "</div>";
            return strReturn;
        }

        public static string ConvertTableToJsonObject(DataTable dt)
        {
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row = default(Dictionary<string, object>);
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        public static string ConvertTableToString(DataTable dt)
        {
            string strResult = "";
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    strResult += dr[col].ToString();
                }
            }
            return strResult;
        }
        //-----------MrHieu(12/07/2019)
        public static string ConvertDataSetToArray(DataSet ds)
        {

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            System.Collections.ArrayList root = new System.Collections.ArrayList();
            List<Dictionary<string, object>> table;
            Dictionary<string, object> data;

            foreach (DataTable dt in ds.Tables)
            {
                table = new List<Dictionary<string, object>>();
                foreach (DataRow dr in dt.Rows)
                {
                    data = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        data.Add(col.ColumnName, dr[col]);
                    }
                    table.Add(data);
                }
                root.Add(table);
            }

            return serializer.Serialize(root);
        }
        //-----------END(12/07/2019)

        public static System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        {
            busCommond bus = new busCommond();
            return bus.GetSQLDataByTableConfig(strTableName, strFeildSelect, strWhere);
        }

        public static string Encrypt(string cleanString)
        {
            byte[] encodedPassword = new System.Text.UnicodeEncoding().GetBytes(cleanString);
            var hash = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            return BitConverter.ToString(hash);
        }

        public static FirestoreDb FirestoreDatabase()
        {
            var builder = new Google.Cloud.Firestore.V1.FirestoreClientBuilder { JsonCredentials = System.IO.File.ReadAllText(GetPath("Metadata/Firebase/cloudfire.json")) };

            FirestoreDb db = FirestoreDb.Create("chatfirehieu", builder.Build());
            return db;
        }


        public async static System.Threading.Tasks.Task<Dictionary<string, object>> FsDB_GetDetailDocAsync(string _strCollection, string _strDocCode)
        {
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.DocumentReference Doc = database.Collection(_strCollection).Document(_strDocCode);

            DocumentSnapshot snap = await Doc.GetSnapshotAsync().ConfigureAwait(continueOnCapturedContext: false);

            Dictionary<string, object> objDetail = new Dictionary<string, object>();
            if (snap.Exists)
            {
                objDetail = snap.ToDictionary();
            }
            return objDetail;
        }

        public async static System.Threading.Tasks.Task<string> FsDB_AddDocAsync(string _strCollection, string _strDocCode, Dictionary<string, object> _data)
        {
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.DocumentReference Doc = database.Collection(_strCollection).Document(_strDocCode);
            
            await Doc.SetAsync(_data).ConfigureAwait(continueOnCapturedContext: false);
            return "";
        }

        public async static System.Threading.Tasks.Task<string> FsDB_UpdDocAsync(string _strCollection, string _strDocCode, Dictionary<string, object> _data)
        {
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.DocumentReference Doc = database.Collection(_strCollection).Document(_strDocCode);

            DocumentSnapshot snap = await Doc.GetSnapshotAsync().ConfigureAwait(continueOnCapturedContext: false);
            if (snap.Exists)
            {
                await Doc.UpdateAsync(_data).ConfigureAwait(continueOnCapturedContext: false);
            }
            return "";
        }

        public async static System.Threading.Tasks.Task<string> FsDB_DelDocAsync(string _strCollection, string _strDocCode)
        {
            Google.Cloud.Firestore.FirestoreDb database = CMSService.FirestoreDatabase();
            Google.Cloud.Firestore.DocumentReference Doc = database.Collection(_strCollection).Document(_strDocCode);

            DocumentSnapshot snap = await Doc.GetSnapshotAsync().ConfigureAwait(continueOnCapturedContext: false);
            if (snap.Exists)
            {
                await Doc.DeleteAsync().ConfigureAwait(continueOnCapturedContext: false);
            }
            return "";
        }

        public static string GetPath(string path)
        {
            return System.Web.Hosting.HostingEnvironment.MapPath("~/" + path);
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
            strJson += "strCompanyGUID:'" + _strCompanyGUID + "'";
            strJson += "}";

            System.Data.DataTable dt = bus.ActionMember(strJson).Tables[0];

            string strRtn = "";
            if (dt.Rows.Count > 0)
                strRtn = dt.Rows[0]["strCompanyGUID"].ToString() + ":" + dt.Rows[0]["strKeyAccessToken"].ToString() + ":" + dt.Rows[0]["strHostDBKey"].ToString();

            return strRtn;
        }


        public static async System.Threading.Tasks.Task<object> UpdTransferToTMS(System.Data.DataSet ds, string _strLink, string _strCompanyGUID)
        {

            string strAuthen = GetDetailLoginToTMS(_strCompanyGUID);

            var arrUserNameandPassword = strAuthen.Split(':');

            var data = new B2B.Ent.AB.entApiCommon.entJson();

            var intTotal = ds.Tables.Count;
            var intCol = 0;
            var intRow = 0;
            var strJson = "";

            data.intTotalPrm = 1;

            if (intTotal > 5)
                data.intTotalPrm = 2;
            if (intTotal > 10)
                data.intTotalPrm = 3;
            if (intTotal > 15)
                data.intTotalPrm = 4;

            for (var i = 0; i < intTotal; i++)
            {
                strJson = "";
                intRow = 0;
                try
                {
                    foreach (System.Data.DataRow dtRow in ds.Tables[i].Rows)
                    {
                        intCol = 0;
                        strJson += (intRow == 0 ? "" : ",") + "{";
                        foreach (System.Data.DataColumn dc in ds.Tables[i].Columns)
                        {
                            strJson += (intCol == 0 ? "\"" : ",\"") + dc + "\":" + (ds.Tables[i].Rows[intRow][dc] == DBNull.Value ? "null" : "\"" + ds.Tables[i].Rows[intRow][dc].ToString().Replace("'", "\\'") + "\"") + "";
                            intCol++;
                        }

                        strJson += "}";

                        intRow++;
                    }
                }
                catch (Exception) { }

                if (i == 0)
                {
                    data.strJson1 = strJson;
                }
                if (i == 1)
                {
                    data.strJson2 = strJson;
                }
                if (i == 2)
                {
                    data.strJson3 = strJson;
                }
                if (i == 3)
                {
                    data.strJson4 = strJson;
                }
                if (i == 4)
                {
                    data.strJson5 = strJson;
                }
                if (i == 5)
                {
                    data.strJson6 = strJson;
                }
                if (i == 6)
                {
                    data.strJson7 = strJson;
                }
                if (i == 7)
                {
                    data.strJson8 = strJson;
                }
                if (i == 8)
                {
                    data.strJson9 = strJson;
                }
                if (i == 9)
                {
                    data.strJson10 = strJson;
                }
                if (i == 10)
                {
                    data.strJson11 = strJson;
                }
                if (i == 11)
                {
                    data.strJson12 = strJson;
                }
                if (i == 12)
                {
                    data.strJson13 = strJson;
                }
                if (i == 13)
                {
                    data.strJson14 = strJson;
                }
                if (i == 14)
                {
                    data.strJson15 = strJson;
                }
                if (i == 15)
                {
                    data.strJson16 = strJson;
                }
                if (i == 16)
                {
                    data.strJson17 = strJson;
                }
                if (i == 17)
                {
                    data.strJson18 = strJson;
                }
                if (i == 18)
                {
                    data.strJson19 = strJson;
                }
                if (i == 19)
                {
                    data.strJson20 = strJson;
                }
            }

            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");


            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(GetHostTMS(_strLink), c).ConfigureAwait(continueOnCapturedContext: false);

            if (!response.IsSuccessStatusCode)
            {
                System.Web.Http.Controllers.HttpActionContext context = new System.Web.Http.Controllers.HttpActionContext();
                context.Response = context.Request
                        .CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                return response.Content.ReadAsStringAsync();
            }

            return await response.Content.ReadAsStringAsync();
        }

        public static async System.Threading.Tasks.Task<object> UpdTransferToTMSByListJSON(B2B.Ent.AB.entApiCommon.entJson data, string _strLink, string _strCompanyGUID)
        {

            string strAuthen = GetDetailLoginToTMS(_strCompanyGUID);

            var arrUserNameandPassword = strAuthen.Split(':');

            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(GetHostTMS(_strLink), c).ConfigureAwait(continueOnCapturedContext: false);

            if (!response.IsSuccessStatusCode)
            {
                System.Web.Http.Controllers.HttpActionContext context = new System.Web.Http.Controllers.HttpActionContext();
                context.Response = context.Request
                        .CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                return response.Content.ReadAsStringAsync();
            }

            return await response.Content.ReadAsStringAsync();
        }


        public static async System.Threading.Tasks.Task<object> UpdTransferToTMSBystrJSON(string _strJSON, string _strLink, string _strCompanyGUID)
        {

            string strAuthen = GetDetailLoginToTMS(_strCompanyGUID);

            var arrUserNameandPassword = strAuthen.Split(':');

            var data = new B2B.Ent.AB.entApiCommon.entJson();

            data.strJson1 = _strJSON;
            data.strHost = arrUserNameandPassword[2];
            HttpContent c = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", strAuthen);
            HttpResponseMessage response = await client.PostAsync(GetHostTMS(_strLink), c).ConfigureAwait(continueOnCapturedContext: false);

            if (!response.IsSuccessStatusCode)
            {
                System.Web.Http.Controllers.HttpActionContext context = new System.Web.Http.Controllers.HttpActionContext();
                context.Response = context.Request
                        .CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                return response.Content.ReadAsStringAsync();
            }

            return await response.Content.ReadAsStringAsync();
        }

        public static string SendEmail(string strUserGUID, string strEmailsSendTo, string strEmailsCC, string strEmailsBCC, string strSubject, string strBody, Boolean IsBodyHtml, string strAttachments = "")
        {
            string strReturn = "1";
            try
            {
                B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();

                var strJson = "{strUserGUID:'" + strUserGUID + "', tblsReturn:null}";
                DataTable t = bus.GetListEmailConfig(strJson).Tables[0];

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

                smtp.Port = Convert.ToInt32(t.Rows[0]["intPort"]);
                smtp.Host = t.Rows[0]["strHost"].ToString(); //for gmail host  
                smtp.EnableSsl = Convert.ToBoolean(t.Rows[0]["IsSSL"]);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(t.Rows[0]["strEmailUser"].ToString(), t.Rows[0]["strEmailPass"].ToString());
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.From = new System.Net.Mail.MailAddress(t.Rows[0]["strEmailForward"].ToString(), t.Rows[0]["strEmailName"].ToString());
                message.ReplyToList.Add(new System.Net.Mail.MailAddress(t.Rows[0]["strEmailForward"].ToString(), t.Rows[0]["strEmailName"].ToString()));

                if (!string.IsNullOrEmpty(strEmailsSendTo))
                {
                    foreach (String s in strEmailsSendTo.Split(','))
                    {
                        message.To.Add(s);
                    }
                }

                if (!string.IsNullOrEmpty(strEmailsCC))
                {
                    foreach (String s in strEmailsCC.Split(','))
                    {
                        message.CC.Add(s);
                    }
                }

                if (!string.IsNullOrEmpty(strEmailsBCC))
                {
                    foreach (String s in strEmailsBCC.Split(','))
                    {
                        message.Bcc.Add(s);
                    }
                }
                if (!string.IsNullOrEmpty(strAttachments))
                {
                    foreach (String s in strAttachments.Split('|'))
                    {
                        message.Attachments.Add(new System.Net.Mail.Attachment(CMSService.GetPath(s)));
                    }
                }


                message.Subject = strSubject;
                message.IsBodyHtml = IsBodyHtml; //to make message body as html  
                message.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
                message.Body = strBody;

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                strReturn = ex.Message;
            }
            return strReturn;
        }
    }
}