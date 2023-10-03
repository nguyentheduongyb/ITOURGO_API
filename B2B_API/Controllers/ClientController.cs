using B2B.Bus.CM;
using B2B.Dat.SL;
using B2B.Ent.CM;
using B2B.Ent.SL;
using B2B_API.App_Start;
using B2B_API.Filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace B2B_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/client")]
    public class ClientController : ApiController
    {

        [HttpPost]
        [Route("UpdClientForIsEnable")]
        public HttpResponseMessage UpdClientForIsEnable(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListContactUsedForSync")]
        public HttpResponseMessage GetListContactUsedForSync(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }
        

        [HttpPost]
        [Route("GetListContactForTag")]
        public HttpResponseMessage GetListContactForTag(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("DelContactTag")]
        public HttpResponseMessage DelContactTag(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }


        [HttpPost]
        [Route("DelContactUsed")]
        public HttpResponseMessage DelContactUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListContactTag")]
        public HttpResponseMessage GetListContactTag(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListContactUsed")]
        public HttpResponseMessage GetListContactUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("AddContactUsed")]
        public HttpResponseMessage AddContactUsed(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListClientForNoAddByAgentHost")]
        public HttpResponseMessage GetListClientForNoAddByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdClientForOrder")]
        public HttpResponseMessage UpdClientForOrder(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdContactForIsOnMailTrimp")]
        public HttpResponseMessage UpdContactForIsOnMailTrimp(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListClient")]
        public HttpResponseMessage GetListClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("AddClient")]
        public HttpResponseMessage AddClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdClient")]
        public HttpResponseMessage UpdClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdClientForAssignWeb")]
        public HttpResponseMessage UpdClientForAssignWeb(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("DelClient")]
        public HttpResponseMessage DelClient(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListContact")]
        public HttpResponseMessage GetListContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("AddContact")]
        public HttpResponseMessage AddContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdContact")]
        public HttpResponseMessage UpdContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }



        [HttpPost]
        [Route("DelContact")]
        public HttpResponseMessage DelContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionClient(ent.strJson)));
        }

        [HttpPost]
        [Route("AddContactForImport")]
        public HttpResponseMessage AddContactForImport(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strFile_Data = Convert.ToString(routes_list["strFile_Data"]);
            string strFile_Name = Convert.ToString(routes_list["strFile_Name"]);

            Dictionary<string, object> objFile_Mapping = (Dictionary<string, object>)routes_list["objFile_Mapping"];
            //object objFile_Mapping = routes_list["objFile_Mapping"];


            string path = "";
            path = "UpLoad/";
            if (!System.IO.Directory.Exists(CMSService.GetPath(path)))
            {
                System.IO.Directory.CreateDirectory(CMSService.GetPath(path));
            }


            string strFileName = System.IO.Path.GetFileNameWithoutExtension(strFile_Name) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + System.IO.Path.GetExtension(strFile_Name);
            string strPathFileName = CMSService.GetPath(path + strFileName);

            Byte[] bytes = Convert.FromBase64String(strFile_Data);
            System.IO.File.WriteAllBytes(strPathFileName, bytes);


            DataTable ArrListData = new DataTable();

            var dbConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + strPathFileName + ";" + "Extended Properties=\"Excel 8.0;HDR=Yes\"");

            dbConnection.Open();
            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand("select * from [Sheet1$]");
                cmd.Connection = dbConnection;
                var dbAdapter1 = new System.Data.OleDb.OleDbDataAdapter(cmd);
                dbAdapter1.Fill(ArrListData);
                cmd.Parameters.Clear();
                cmd.Cancel();
                cmd.Dispose();
            }
            finally
            {
                dbConnection.Close();
                System.IO.File.Delete(strPathFileName);
            }


            DataTable ArrListRtn = new DataTable();

            foreach (var record in routes_list)
            {
                if (!record.Key.Contains("File_"))
                {
                    ArrListRtn.Columns.Add(record.Key);
                }
            }

            foreach (var record in objFile_Mapping)
            {
                ArrListRtn.Columns.Add(record.Value.ToString());
            }

            foreach (DataRow dr in ArrListData.Rows)
            {
                var IsAdd = false;
                foreach (DataColumn dc in ArrListData.Columns)
                {
                    if (!string.IsNullOrEmpty(dr[dc].ToString()))
                    {
                        IsAdd = true;
                    }
                }

                if (IsAdd)
                {
                    DataRow dtRow = ArrListRtn.NewRow();

                    foreach (var record in routes_list)
                    {
                        if (!record.Key.Contains("File_"))
                        {
                            //ArrListRtn.Columns.Add(record.Key);
                            dtRow[record.Key] = record.Value;
                        }
                    }
                    foreach (var record in objFile_Mapping)
                    {

                        //ArrListRtn.Columns.Add(Value);

                        dtRow[record.Value.ToString()] = dr[record.Key];
                    }

                    ArrListRtn.Rows.Add(dtRow);
                }
                

            }

            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();

            foreach (DataRow dr in ArrListRtn.Rows)
            {

                var strJson = "";
                strJson += "{";
                foreach (DataColumn dc in ArrListRtn.Columns)
                {
                    var intIndex = dc.Ordinal;
                    strJson += (intIndex == 0 ? "" : ",") + dc.ColumnName + ": '" + dr[dc] + "'";
                }
                strJson += "}";
                bus.ActionClient(strJson);
            }


            return Request.CreateResponse(HttpStatusCode.OK, "");
        }

    }

}
