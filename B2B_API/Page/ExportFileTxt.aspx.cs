using Aspose.Words;
using B2B.Bus.CM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B2B_API.Views
{
    public partial class ExportFileTxt : System.Web.UI.Page
    {

        //private sta

        protected void Page_Load(object sender, EventArgs e)
        {

            var vnpayData = Request.QueryString;
            var strJson = "";
            var strSP = Request.QueryString["type"];
            var strFileName = Request.QueryString["cfg_FileName"];
            var intTblPos = Convert.ToInt32(Request.QueryString["cfg_TblPos"]);

            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            strJson = "{";
            foreach (string s in vnpayData)
            {
                if (s != "type" && s != "act" && !s.StartsWith("cfg_"))
                {
                    var str = HttpUtility.HtmlDecode(Request.QueryString[s]);
                    strJson += "," + s + ":" + (str == "null" ? "null" : "\"" + str + "\"");
                }
            }
            strJson += "}";
            strJson = strJson.Replace("{,", "{");

            busCommond bus = new busCommond();
            if (Request.QueryString["act"] == "MenuMap")
            {
                ds = bus.ActionMenuMapEx(strJson, Request.QueryString["type"]);
            }

            if (string.IsNullOrEmpty(Request.QueryString["cfg_TblPos"]))
            {
                intTblPos = 0;
            }

            dt = ds.Tables[intTblPos];

            var strHtml = "";

            if (strFileName.Contains(".json"))
            {
                strHtml = "{\n";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    strHtml += "\t\""+ dt.Rows[i]["strKey"].ToString() + "\": \""+ dt.Rows[i]["strVal"].ToString() + "\""+(dt.Rows.Count == i+1? "" : ",") +"\n";
                }
                strHtml += "}";
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    strHtml += dt.Rows[i][0].ToString()+"\n";
                }
            }

            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Write(strHtml);

            doc.Save(strFileName, SaveFormat.Text, SaveType.OpenInWord, Response);
        }


        private string GetPath(string path)
        {
            return System.Web.Hosting.HostingEnvironment.MapPath("~/" + path);
        }
    }
}