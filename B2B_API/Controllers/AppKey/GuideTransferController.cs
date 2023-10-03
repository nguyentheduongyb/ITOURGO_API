using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using B2B.Ent.CM;
using B2B.Bus.CM;
using B2B_API.Filter;
using B2B_API.App_Start;
namespace TMS_API.Controllers.AppKey
{
    [Authorize]
    [RoutePrefix("api/appkeys/guide")]
    public class GuideTransferController : ApiController
    {
        //9 API
        [HttpPost]
        [Route("UpdGuideBookingStatus")]
        public HttpResponseMessage UpdGuideBookingStatus(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.UpdGuideBookingStatus(ent.strGuideBookingGUID, ent.IsTransferTMS, ent.strUserGUID);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("GetGuideBookingTransferDataConfig")]
        public HttpResponseMessage GetGuideBookingTransferDataConfig(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataSet ds = bus.GetGuideBookingTransferDataConfig(ent.strGuideBookingGUID, ent.strUserGUID);
            entCommond.entXML entReturn = new entCommond.entXML();
            if (ds.Tables.Count > 0)
                entReturn.strXML1 = CMSService.ConvertTableToString(ds.Tables[0]);
            if (ds.Tables.Count > 1)
                entReturn.strXML2 = CMSService.ConvertTableToString(ds.Tables[1]);
            if (ds.Tables.Count > 2)
                entReturn.strXML3 = CMSService.ConvertTableToString(ds.Tables[2]);
            if (ds.Tables.Count > 3)
                entReturn.strXML4 = CMSService.ConvertTableToString(ds.Tables[3]);
            if (ds.Tables.Count > 4)
                entReturn.strXML5 = CMSService.ConvertTableToString(ds.Tables[4]);
            if (ds.Tables.Count > 5)
                entReturn.strXML6 = CMSService.ConvertTableToString(ds.Tables[5]);
            if (ds.Tables.Count > 6)
                entReturn.strXML7 = CMSService.ConvertTableToString(ds.Tables[6]);
            if (ds.Tables.Count > 7)
                entReturn.strXML8 = CMSService.ConvertTableToString(ds.Tables[7]);
            if (ds.Tables.Count > 8)
                entReturn.strXML9 = CMSService.ConvertTableToString(ds.Tables[8]);
            return request.CreateResponse(HttpStatusCode.OK, entReturn);
        }


        [HttpPost]
        [Route("GetListGuideBookingTransferTMS")]
        public HttpResponseMessage GetListGuideBookingTransferTMS(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            long intTotal = 0;
            entCommond.entDataReturn entReturn = new entCommond.entDataReturn
            {
                strDataRow1 = bus.GetListGuideBookingTransferTMS(ent.intCurrPage, ent.intPageSize, ref intTotal, ent.dtmDateFrom, ent.dtmDateTo, ent.strWhere, ent.intType, ent.strUserGUID),
                intTotalRecode = Convert.ToInt32(intTotal)
            };
            return request.CreateResponse(HttpStatusCode.OK, entReturn);
        }

        //[Route("GetListAll")]
        //[HttpGet]
        //public IEnumerable<string> GetListAll()
        //{
        //    //Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
        //    return new string[] { "value1", "value2" };
        //}
        [Route("SendActiveEmail")]
        [HttpPost]
        public HttpResponseMessage SendActiveEmail(HttpRequestMessage request, entCommond.entGuideModel ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.GetHTMLSendEmailActiveUser(User.Identity.Name, ent.strGuideGUID);
            string strMess = ds.Tables[0].Rows[0]["strMess"].ToString();
            if (strMess == "1")
            {
                string strSendMailStatus = "";//CMSService.SendMail(ds.Tables[0].Rows[0]["GD01_Email1"].ToString(), "", ds.Tables[0].Rows[0]["strMailTitle"].ToString(), ds.Tables[0].Rows[0]["strHTML"].ToString());
                return Request.CreateResponse(HttpStatusCode.OK, strSendMailStatus);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, strMess);
            }
        }
        [Route("GetGuideDetailByGuideLicenceNo")]
        [HttpPost]
        public HttpResponseMessage GetGuideDetailByGuideLicenceNo(HttpRequestMessage request, entCommond.entGuideModel ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.GetGuideDetailByGuideLicenceNo(ent.strGuideLicenceNo);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }
        [Route("GetCheckGuideLicence")]
        [HttpGet]
        public HttpResponseMessage GetCheckGuideLicence(HttpRequestMessage request, string strGuideLicenceNo)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = CMSService.GetSQLDataByTableConfig("GD01", "GD01_GuideLicenceNo AS strGuideLicenceNo,GD01_GuideGUID AS strAPIGuideGUID,IsEnable,CONVERT(NVARCHAR(20),LastLogin,106)+' '+CONVERT(NVARCHAR(20),LastLogin,108) AS LastLogin", " WHERE GD01.GD01_GuideLicenceNo='" + strGuideLicenceNo + "'");
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(dt));
        }
        [Route("AddOrUpdGuideFromTMS")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdGuideFromTMS(HttpRequestMessage request, entCommond.entXML ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataTable dt = new System.Data.DataTable();
            ent.strPNGClientGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddOrUpdGuideFromTMS(ent);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[0]));
        }
        [Route("AddOrUpdGuideProgramFromTMS")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdGuideProgramFromTMS(HttpRequestMessage request, entCommond.entXML ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataTable dt = new System.Data.DataTable();
            ent.strPNGClientGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddOrUpdGuideProgramFromTMS(ent);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[0]));
        }
        [Route("AddOrUpdGuidePaymentFromTMS")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdGuidePaymentFromTMS(HttpRequestMessage request, entCommond.entXML ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataTable dt = new System.Data.DataTable();
            ent.strPNGClientGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddOrUpdGuidePaymentFromTMS(ent);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[0]));
        }

        protected void DeleteFilePatch(string strFilePatch)
        {
            strFilePatch = System.Web.Hosting.HostingEnvironment.MapPath("~/" + strFilePatch);
            if (System.IO.File.Exists(strFilePatch) == true)
            {
                try
                {
                    System.IO.File.Delete(strFilePatch);
                }
                catch (Exception)
                {
                }
            }
        }
        protected entConnectB2B.entPostImage DownloadServiceImage(entConnectB2B.entPostImage ArrTB11, string strServerSavePath, string strDBSavePath)
        {
            entConnectB2B.entPostImage ent = new B2B.Ent.CM.entConnectB2B.entPostImage();
            string strFileName = "";
            if (ArrTB11.strImage1 == null)
            {
                ArrTB11.strImage1 = "";
            }
            if (ArrTB11.strImage2 == null)
            {
                ArrTB11.strImage2 = "";
            }
            if (ArrTB11.strImage3 == null)
            {
                ArrTB11.strImage3 = "";
            }
            if (ArrTB11.strImage4 == null)
            {
                ArrTB11.strImage4 = "";
            }
            if (ArrTB11.strImage1 != "")
            {
                strFileName = DownloadTourImageFromURL(ArrTB11.strImage1, strServerSavePath);
                if (strFileName.Length > 0)
                {
                    ent.strImage1 = strDBSavePath + strFileName;
                }
            }
            if (ArrTB11.strImage2 != "")
            {
                strFileName = DownloadTourImageFromURL(ArrTB11.strImage2, strServerSavePath);
                if (strFileName.Length > 0)
                {
                    ent.strImage2 = strDBSavePath + strFileName;
                }
            }
            if (ArrTB11.strImage3 != "")
            {
                strFileName = DownloadTourImageFromURL(ArrTB11.strImage3, strServerSavePath);
                if (strFileName.Length > 0)
                {
                    ent.strImage3 = strDBSavePath + strFileName;
                }
            }
            if (ArrTB11.strImage4 != "")
            {
                strFileName = DownloadTourImageFromURL(ArrTB11.strImage4, strServerSavePath);
                if (strFileName.Length > 0)
                {
                    ent.strImage4 = strDBSavePath + strFileName;
                }
            }
            return ent;
        }
        protected string DownloadTourImageFromURL(string strFileURL, string strServerSavePath)
        {
            try
            {
                string strFileName = System.Guid.NewGuid().ToString().Replace("-", "");
                string[] filesplit = strFileURL.Split('.');

                string strFileType = filesplit[filesplit.Length - 1];
                strFileName = strFileName + "." + strFileType;
                byte[] content;
                HttpWebRequest requestcontent = (HttpWebRequest)WebRequest.Create(strFileURL);
                WebResponse response = requestcontent.GetResponse();

                System.IO.Stream stream = response.GetResponseStream();

                using (System.IO.BinaryReader br = new System.IO.BinaryReader(stream))
                {
                    content = br.ReadBytes(500000);
                    br.Close();
                }
                response.Close();

                System.IO.FileStream fs = new System.IO.FileStream(strServerSavePath + strFileName, System.IO.FileMode.Create);
                System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs);
                try
                {
                    bw.Write(content);
                }
                finally
                {
                    fs.Close();
                    bw.Close();
                }
                return strFileName;
            }
            catch (Exception)
            {

                return "";
            }

        }
        protected string CreateFolderTourAttach()
        {
            string strDay = DateTime.Now.Day.ToString();
            if ((DateTime.Now.Day < 10))
                strDay = "0" + DateTime.Now.Day.ToString();
            string strMonth = DateTime.Now.Month.ToString();
            if ((DateTime.Now.Month < 10))
                strMonth = "0" + DateTime.Now.Month.ToString();


            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.Web.Hosting.HostingEnvironment.MapPath("~/Upload/TourAttach/" + DateTime.Now.Year.ToString().Trim() + "/" + strMonth.Trim()));
            System.IO.DirectoryInfo dj = new System.IO.DirectoryInfo(System.Web.Hosting.HostingEnvironment.MapPath("~/Upload/TourAttach/" + DateTime.Now.Year.ToString().Trim() + "/" + strMonth.Trim()) + "/" + strDay.ToString());
            try
            {
                if (di.Exists)
                {
                    if (!dj.Exists)
                        dj.Create();
                }
                else
                {
                    di.Create();
                    dj.Create();
                }
                return System.Web.Hosting.HostingEnvironment.MapPath("~/Upload/TourAttach/" + DateTime.Now.Year.ToString().Trim() + "/" + strMonth.Trim() + "/" + strDay.ToString().Trim());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
