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
    //[Authorize]
    [RoutePrefix("api/appkeys/tour")]
    public class TourTransferController : ApiController
    {


        public class GetTest_Par
        {
            public string strJson { get; set; }
            public int OptionalParam2 { get; set; }
        }

        [HttpPost]
        [Route("GetTest")]
        public HttpResponseMessage GetTest(GetTest_Par ent)
        {

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();


            return Request.CreateResponse(HttpStatusCode.OK, GetDetailMember(ent.strJson));
        }

        public string GetDetailMember(string _strJson)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return CMSService.ConvertDataSetToArray(bus.ActionMember(_strJson));
        }




        //13 api
        [HttpPost]
        [Route("AddModuleProductionFromTMSXML")]
        public HttpResponseMessage AddModuleProductionFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddModuleProductionFromTMSXML(ent);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string strDay = DateTime.Now.Day.ToString();
                if ((DateTime.Now.Day < 10))
                    strDay = "0" + DateTime.Now.Day.ToString();
                string strMonth = DateTime.Now.Month.ToString();
                if ((DateTime.Now.Month < 10))
                    strMonth = "0" + DateTime.Now.Month.ToString();
                string strDBSavePath = "Upload/TourAttach/" + DateTime.Now.Year.ToString() + "/" + strMonth + "/" + strDay + "/";

                var strUrlHostImages = System.Web.HttpContext.Current.Request.UrlReferrer.Scheme + "://" + System.Web.HttpContext.Current.Request.UrlReferrer.Authority + '/';
                var strXml = "<strTourGUID>" + ds.Tables[ds.Tables.Count - 2].Rows[i]["strTourGUID"].ToString() + "</strTourGUID>";
                strXml += "<strImageUrl>" + strDBSavePath + DownloadTourImageFromURL(strUrlHostImages + ds.Tables[ds.Tables.Count - 2].Rows[i]["strImage"].ToString(), CreateFolderTourAttach() + "/") + "</strImageUrl>";
                //strXml += "<strImageUrl>" + System.Web.HttpContext.Current.Request.UrlReferrer.Scheme + "://" + System.Web.HttpContext.Current.Request.UrlReferrer.Authority+ "</strImageUrl>";
                //---------------MrHieu(20/06/2019)
                entCommond.entXML ent2 = new entCommond.entXML
                {
                    strXML1 = strXml
                };
                UpdLinkImages(ent2);
                //---------------END(20/06/2019)
            }
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("UpdOrderBookingStatus")]
        public HttpResponseMessage UpdOrderBookingStatus(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.UpdOrderBookingStatus(ent.strOrderBookingGUID, ent.IsTransferTMS, ent.strUserGUID);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("GetBookingTransferDataConfig")]
        public HttpResponseMessage GetBookingTransferDataConfig(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataSet ds = bus.GetBookingTransferDataConfig(ent.strOrderBookingGUID, ent.strUserGUID);
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
        [Route("GetListBookingTransferTMS")]
        public HttpResponseMessage GetListBookingTransferTMS(HttpRequestMessage request, entCommond.entFilterData ent)
        {
            busConnectB2B bus = new busConnectB2B();
            long intTotal = 0;
            entCommond.entDataReturn entReturn = new entCommond.entDataReturn
            {
                strDataRow1 = bus.GetListBookingTransferTMS(ent.intCurrPage, ent.intPageSize, ref intTotal, ent.dtmDateFrom, ent.dtmDateTo, ent.strWhere, ent.intType, ent.strUserGUID),
                intTotalRecode = Convert.ToInt32(intTotal)
            };
            return request.CreateResponse(HttpStatusCode.OK, entReturn);
        }

        [HttpPost]
        [Route("AddClientContactFromTMSXML")]
        public HttpResponseMessage AddClientContactFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddClientContactFromTMSXML(ent);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("AddSupplierFromTMSXML")]
        public HttpResponseMessage AddSupplierFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddSupplierFromTMSXML(ent);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("AddTourBaseToBookingFromTMSXML")]
        public HttpResponseMessage AddTourBaseToBookingFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddTourBaseToBookingFromTMSXML(ent);

            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("AddTourBaseFromTMSXML")]
        public HttpResponseMessage AddTourBaseFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddTourBaseFromTMSXML(ent);

            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }

        [HttpPost]
        [Route("AddServiceItemTourFromTMSXML")]
        public HttpResponseMessage AddServiceItemTourFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strUserGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddServiceItemTourFromTMSXML(ent);

            InsertImageTMS(ds.Tables[0]);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }
        //----------------MrHieu(12/06/2019)(1)
        [HttpPost]
        [Route("AddSetTourFixFromTMSXML")]
        public HttpResponseMessage AddSetTourFixFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strCompanyGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddSetTourFixFromTMSXML(ent);

            InsertImageTMS(ds.Tables[0]);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }
        //----------------END(12/06/2019)(1)
        //----------------MrHieu(13/06/2019)(1)
        [HttpPost]
        [Route("AddSetTourFromTMSXML")]
        public HttpResponseMessage AddSetTourFromTMSXML(HttpRequestMessage request, entCommond.entDataPost ent)
        {
            busConnectB2B bus = new busConnectB2B();
            ent.strCompanyGUID = User.Identity.Name;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = bus.AddSetTourFromTMSXML(ent);

            InsertImageTMS(ds.Tables[0]);
            return request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertTableToJsonObject(ds.Tables[ds.Tables.Count - 1]));
        }
        //----------------END(13/06/2019)(1)
        [HttpPut]
        [Route("UpdModuleDayImages")]
        public string UpdModuleDayImages([FromBody]List<entConnectB2B.entPostImage> ent)
        {

            string strServerSavePath = CreateFolderTourAttach() + "/";

            string strDay = DateTime.Now.Day.ToString();
            if ((DateTime.Now.Day < 10))
                strDay = "0" + DateTime.Now.Day.ToString();
            string strMonth = DateTime.Now.Month.ToString();
            if ((DateTime.Now.Month < 10))
                strMonth = "0" + DateTime.Now.Month.ToString();
            string strDBSavePath = "Upload/TourAttach/" + DateTime.Now.Year.ToString() + "/" + strMonth + "/" + strDay + "/";
            busConnectB2B bus = new busConnectB2B();
            System.Data.DataSet ds = new System.Data.DataSet();
            for (int i = 0; i < ent.Count; i++)
            {
                entConnectB2B.entPostImage ArrTB11 = new B2B.Ent.CM.entConnectB2B.entPostImage();
                ArrTB11 = DownloadServiceImage(ent[i], strServerSavePath, strDBSavePath);
                ds = bus.UpdTourDayImages(ArrTB11);
                System.Data.DataRow ArrRow = ds.Tables[0].Rows[0];
                if (ArrRow["strImage1"].ToString().Length > 0)
                {
                    DeleteFilePatch(ArrRow["strImage1"].ToString());
                }
                if (ArrRow["strImage2"].ToString().Length > 0)
                {
                    DeleteFilePatch(ArrRow["strImage2"].ToString());
                }
                if (ArrRow["strImage3"].ToString().Length > 0)
                {
                    DeleteFilePatch(ArrRow["strImage3"].ToString());
                }
                if (ArrRow["strImage4"].ToString().Length > 0)
                {
                    DeleteFilePatch(ArrRow["strImage4"].ToString());
                }
            }
            return "1";
        }

        private void UpdLinkImages(entCommond.entXML ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            //bus.GetTourList(ent.strXML1);
        }

        private void InsertImageTMS(System.Data.DataTable dt)
        {

            foreach (System.Data.DataRow dr in dt.Rows)
            {
                DownloadImage(dr["strUrlImgOld"].ToString(), dr["strPathImgNew"].ToString(), dr["strFileImgNew"].ToString());
            }
        }
        protected void DownloadImage(string strUrlImgOld, string strPathImgNew, string strFileImgNew)
        {
            try
            {
                string strFileUrl = System.Web.HttpContext.Current.Request.UrlReferrer.Scheme + "://" + System.Web.HttpContext.Current.Request.UrlReferrer.Authority + '/' + strUrlImgOld;

                if (strPathImgNew != null)
                {

                    if (!System.IO.Directory.Exists(CMSService.GetPath(strPathImgNew)))
                    {
                        System.IO.Directory.CreateDirectory(CMSService.GetPath(strPathImgNew));
                    }

                    byte[] content;
                    HttpWebRequest requestcontent = (HttpWebRequest)WebRequest.Create(strFileUrl);
                    WebResponse response = requestcontent.GetResponse();

                    System.IO.Stream stream = response.GetResponseStream();

                    using (System.IO.BinaryReader br = new System.IO.BinaryReader(stream))
                    {
                        content = br.ReadBytes(10000000);
                        br.Close();
                    }
                    response.Close();

                    System.IO.FileStream fs = new System.IO.FileStream(CMSService.GetPath(strPathImgNew) + strFileImgNew, System.IO.FileMode.Create);
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

                }
            }
            catch (Exception)
            {
            }

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
