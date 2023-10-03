using B2B.Ent.SL;
using B2B_API.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2B_API.Page
{
    public partial class vnpay_ipn : System.Web.UI.Page
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Page_Load(object sender, EventArgs e)
        {
            string returnContent = string.Empty;
            if (Request.QueryString.Count > 0)
            {
                string vnp_HashSecret = ConfigurationManager.AppSettings["vnp_HashSecret"]; //Chuoi bi mat
                var vnpayData = Request.QueryString;
                VnPayLibrary vnpay = new VnPayLibrary();
                //if (vnpayData.Count > 0)
                //{
                foreach (string s in vnpayData)
                {
                    //get all querystring data
                    if (!string.IsNullOrEmpty(s) && s.StartsWith("vnp_"))
                    {
                        vnpay.AddResponseData(s, vnpayData[s]);
                    }
                }
                // }

                //vnp_TxnRef: Ma don hang merchant gui VNPAY tai command=pay    
                string orderId = vnpay.GetResponseData("vnp_TxnRef");
                //vnp_TransactionNo: Ma GD tai he thong VNPAY
                long vnpayTranId = Convert.ToInt64(vnpay.GetResponseData("vnp_TransactionNo"));
                //vnp_ResponseCode:Response code from VNPAY: 00: Thanh cong, Khac 00: Xem tai lieu
                string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
                //vnp_SecureHash: MD5 cua du lieu tra ve
                String vnp_SecureHash = Request.QueryString["vnp_SecureHash"];
                bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, vnp_HashSecret);
                if (checkSignature)
                {

                    if (vnp_ResponseCode == "00")
                    {
                        //Thanh toan thanh cong
                        log.InfoFormat("Thanh toan thanh cong, OrderId={0}, VNPAY TranId={1}", orderId, vnpayTranId);
                    }
                    else
                    {
                        //Thanh toan khong thanh cong. Ma loi: vnp_ResponseCode
                        //  displayMsg.InnerText = "Có lỗi xảy ra trong quá trình xử lý.Mã lỗi: " + vnp_ResponseCode;
                        log.InfoFormat("Thanh toan loi, OrderId={0}, VNPAY TranId={1},ResponseCode={2}", orderId,
                            vnpayTranId, vnp_ResponseCode);
                    }


                    System.Data.DataSet ds = UpdPaymentTransactionByAgent("{"
                        + "strUserGUID:null"
                        + ",strPaymentTransactionCode:'" + orderId + "'"
                        + ",strRespondCode:'" + vnp_ResponseCode + "'"
                        + ",dblAmount:'" + vnpay.GetResponseData("vnp_Amount") + "'"
                        + ",strPayDate:'" + vnpay.GetResponseData("vnp_PayDate") + "'"
                        + "}");

                    System.Data.DataRow dr = ds.Tables[ds.Tables.Count - 1].Rows[0];

                    if (!String.IsNullOrEmpty(dr["strEmailsSendTo"].ToString()))
                    {
                        App_Start.CMSService.SendEmail("", Convert.ToString(dr["strEmailsSendTo"]), Convert.ToString(dr["strEmailsCC"]), Convert.ToString(dr["strEmailsBCC"]), dr["strSubject"].ToString(), dr["strBody"].ToString(), true);
                    }
                    returnContent = "{\"RspCode\":\""+ dr["strRespondCode"] + "\",\"Message\":\"" + dr["strRespondName"] + "\"}";
                }
                else
                {
                    log.InfoFormat("Invalid signature, InputData={0}", Request.RawUrl);
                    returnContent = "{\"RspCode\":\"97\",\"Message\":\"Invalid signature\"}";
                }
            }
            else
            {
                returnContent = "{\"RspCode\":\"99\",\"Message\":\"Input data required\"}";
            }


            Response.ClearContent();
            Response.Write(returnContent);
            Response.End();
        }
        public System.Data.DataSet UpdPaymentTransactionByAgent(string strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return bus.ActionBooking(strJson);
        }
    }
}