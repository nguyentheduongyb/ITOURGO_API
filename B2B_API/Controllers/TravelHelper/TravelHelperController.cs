using B2B.Ent.SL;
using B2B_API.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers.TravelHelper
{
    [Authorize]
    [RoutePrefix("api/travelhelper")]
    public class TravelHelperController : ApiController
    {

        [HttpPost]
        [Route("AddB2BLogVideoHistory")]
        public HttpResponseMessage AddB2BLogVideoHistory(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }


        [HttpPost]
        [Route("GetDetailTravelB2BHelperFileByShow")]
        public HttpResponseMessage GetDetailTravelB2BHelperFileByShow(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTravelb2bHelper")]
        public HttpResponseMessage GetListTravelb2bHelper(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTravelHelperMainModule")]
        public HttpResponseMessage GetListTravelHelperMainModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTravelHelperMainModule")]
        public HttpResponseMessage AddTravelHelperMainModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdTravelHelperMainModule")]
        public HttpResponseMessage UpdTravelHelperMainModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }


        [HttpPost]
        [Route("DelTravelHelperMainModule")]
        public HttpResponseMessage DelTravelHelperMainModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListTravelHelperSubModuleForB2B")]
        public HttpResponseMessage GetListTravelHelperSubModuleForB2B(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTravelHelperSubModuleForB2B")]
        public HttpResponseMessage AddTravelHelperSubModuleForB2B(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTravelHelperSubModuleForB2B")]
        public HttpResponseMessage UpdTravelHelperSubModuleForB2B(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTravelHelperSubModuleForB2B")]
        public HttpResponseMessage DelTravelHelperSubModuleForB2B(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListTravel2b2HelperFile")]
        public HttpResponseMessage GetListTravel2b2HelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("AddTravelb2bHelperFile")]
        public HttpResponseMessage AddTravelb2bHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTravelb2bHelperFile")]
        public HttpResponseMessage UpdTravelb2bHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }


        [HttpPost]
        [Route("DelTravelb2bHelperFile")]
        public HttpResponseMessage DelTravelb2bHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }





        [HttpPost]
        [Route("GetListTravelHelper")]
        public HttpResponseMessage GetListTravelHelper(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTravelHelperSubsystem")]
        public HttpResponseMessage GetListTravelHelperSubsystem(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTravelHelperSubModule")]
        public HttpResponseMessage GetListTravelHelperSubModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTravelHelperSubModule")]
        public HttpResponseMessage AddTravelHelperSubModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTravelHelperSubModule")]
        public HttpResponseMessage UpdTravelHelperSubModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTravelHelperSubModule")]
        public HttpResponseMessage DelTravelHelperSubModule(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTravelHelperFile")]
        public HttpResponseMessage GetListTravelHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTravelHelperFile")]
        public HttpResponseMessage AddTravelHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("UpdTravelHelperFile")]
        public HttpResponseMessage UpdTravelHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }
        [HttpPost]
        [Route("DelTravelHelperFile")]
        public HttpResponseMessage DelTravelHelperFile(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTMSMember")]
        public HttpResponseMessage GetListTMSMember(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddTMSMember")]
        public HttpResponseMessage AddTMSMember(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdTMSMember")]
        public HttpResponseMessage UpdTMSMember(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("DelTMSMember")]
        public HttpResponseMessage DelTMSMember(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCompany")]
        public HttpResponseMessage GetListCompany(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCompany")]
        public HttpResponseMessage AddCompany(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompany")]
        public HttpResponseMessage UpdCompany(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCompany")]
        public HttpResponseMessage DelCompany(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCompanyLink")]
        public HttpResponseMessage GetListCompanyLink(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCompanyLink")]
        public HttpResponseMessage AddCompanyLink(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCompanyLink")]
        public HttpResponseMessage DelCompanyLink(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("AddLogHistory")]
        public HttpResponseMessage AddLogHistory(entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionHelper(ent.strJson)));
        }

        [HttpPost]
        [Route("UploadFiles")]
        public HttpResponseMessage UploadFiles()
        {
            var context = System.Web.HttpContext.Current;
            string path = "UpLoad/";
            if (!string.IsNullOrEmpty(context.Request.QueryString["path"]))
            {
                path += context.Request.QueryString["path"] + "/";
            }

            if (!System.IO.Directory.Exists(GetPath(path)))
            {
                System.IO.Directory.CreateDirectory(GetPath(path));
            }

            string pathReturn = "[";
            if (context.Request.Files.Count > 0)
            {
                System.Web.HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    System.Web.HttpPostedFile file = files[i];

                    string strFileName = System.Guid.NewGuid().ToString().Replace("-", "");
                    strFileName = path + strFileName + System.IO.Path.GetExtension(file.FileName);

                    file.SaveAs(GetPath(strFileName));

                    pathReturn += (i == 0 ? "" : ",") + "\"" + strFileName + "\"";
                }
            }
            pathReturn += "]";
            return Request.CreateResponse(HttpStatusCode.OK, pathReturn);
        }

        [HttpPost]
        [Route("DelFile")]
        public HttpResponseMessage DelFile(entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            if (System.IO.File.Exists(System.IO.Path.Combine(GetPath(routes_list["strPath"].ToString()), routes_list["strFileName"].ToString())))    
            {    
                System.IO.File.Delete(System.IO.Path.Combine(GetPath(routes_list["strPath"].ToString()), routes_list["strFileName"].ToString()));  
            }  
            return Request.CreateResponse(HttpStatusCode.OK,"");
        }

        private string GetPath(string path)
        {
            return System.Web.Hosting.HostingEnvironment.MapPath("~/" + path);
        }
    }
}
