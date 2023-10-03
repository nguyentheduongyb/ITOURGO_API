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
using System.Configuration;

namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/payonline")]
    public class PayOnlineController : ApiController
    {

        private string vnp_Url = ConfigurationManager.AppSettings["vnp_Url"];
        private string vnp_TmnCode = ConfigurationManager.AppSettings["vnp_TmnCode"];
        private string vnp_HashSecret = ConfigurationManager.AppSettings["vnp_HashSecret"];

        [HttpPost]
        [Route("GetUrlPayOnline")]
        public HttpResponseMessage GetUrlPayOnline(entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string vnp_TxnRef = Convert.ToString(routes_list["strOrderBeforePaymentCode"]);
            string vnp_Returnurl = Convert.ToString(routes_list["strReturnUrl"]); //URL nhan ket qua tra ve 
            string vnp_Amount = Convert.ToString(Convert.ToDecimal(routes_list["dblAmount"])*100);
            string vnp_OrderInfo = Convert.ToString(routes_list["strDescription"]);
            //string vnp_Url = ConfigurationManager.AppSettings["vnp_Url"]; //URL thanh toan cua VNPAY 
            //string vnp_TmnCode = ConfigurationManager.AppSettings["vnp_TmnCode"]; //Ma website
            //string vnp_HashSecret = ConfigurationManager.AppSettings["vnp_HashSecret"]; //Chuoi bi mat

            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", "2.0.0");
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);

            //string locale = language.SelectedItem.Value;
            //if (!string.IsNullOrEmpty(locale))
            //{
            //    vnpay.AddRequestData("vnp_Locale", locale);
            //}
            //else
            //{
                vnpay.AddRequestData("vnp_Locale", "vn");
            //}

            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_TxnRef", vnp_TxnRef);
            vnpay.AddRequestData("vnp_OrderInfo", vnp_OrderInfo);
            //vnpay.AddRequestData("vnp_OrderType", orderCategory.SelectedItem.Value); //default value: other
            vnpay.AddRequestData("vnp_Amount", vnp_Amount);
            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_IpAddr", VnPayUtils.GetIpAddress());
            vnpay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));

            //if (bank.SelectedItem != null && !string.IsNullOrEmpty(bank.SelectedItem.Value))
            //{
            //    vnpay.AddRequestData("vnp_BankCode", bank.SelectedItem.Value);
            //}

            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);

            string strObjRtn = "";
            strObjRtn += "{";
                strObjRtn += "\"strPaymentUrl\":\""+ paymentUrl + "\"";
            strObjRtn += "}";

            return Request.CreateResponse(HttpStatusCode.OK, strObjRtn);
        }

        [HttpPost]
        [Route("GetCheckSecureHash")]
        public HttpResponseMessage GetCheckSecureHash(entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            String vnp_SecureHash = routes_list["strSecureHash"].ToString();
            String strReturnUrl = routes_list["strReturnUrl"].ToString();

            VnPayLibrary vnpay = new VnPayLibrary();

            var arrUrl = strReturnUrl.Split('?');
            System.Collections.Specialized.NameValueCollection vnpaydata = System.Web.HttpUtility.ParseQueryString(arrUrl[1]);

            foreach (string s in vnpaydata)
            {
                //get all querystring data
                if (!string.IsNullOrEmpty(s) && s.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(s, vnpaydata[s]);
                }
            }
            bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, vnp_HashSecret);

            return Request.CreateResponse(HttpStatusCode.OK, checkSignature);
        }

    }
}
