using Aspose.Words;
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
    public partial class ExportWord : System.Web.UI.Page
    {

        //private sta


        protected void Page_Load(object sender, EventArgs e)
        {

            var vnpayData = Request.QueryString;
            var strJson = "";
            var strSP = Request.QueryString["type"];

            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            var strFileName = "";


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

            try
            {
                B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
                if (Request.QueryString["act"] == "TourBase")
                {
                    ds = bus.ActionTourBaseEx(strJson, Request.QueryString["type"]);
                }
                if (Request.QueryString["act"] == "Supplier")
                {
                    ds = bus.ActionStoreSupplierEx(strJson, Request.QueryString["type"]);
                }
                if (Request.QueryString["act"] == "PriceSupp")
                {
                    ds = bus.ActionPriceSuppEx(strJson, Request.QueryString["type"]);
                }
                if (Request.QueryString["act"] == "Guide")
                {
                    ds = bus.ActionGuideEx(strJson, Request.QueryString["type"]);
                }
                if (Request.QueryString["act"] == "Booking")
                {
                    ds = bus.ActionBookingEx(strJson, Request.QueryString["type"]);
                }
                dt = ds.Tables[0];
            }
            catch (Exception)
            {
                ds = GetHTMLCustomizeTourForExport(strJson);
                dt = ds.Tables[0];
            }

            try
            {
                strFileName = ds.Tables[1].Rows[0]["strFileExportName"].ToString();
            }
            catch (Exception) { }

            try
            {
                strSP = ds.Tables[1].Rows[0]["strSP"].ToString();
            }
            catch (Exception) { }

            var strHtml = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strHtml += dt.Rows[i][0].ToString();
            }
            pnTourPrice.InnerHtml = strHtml;

            string strLinkPath = "Data\\FileTemplate";
            string strLinkName = "TEMPLATE_WORD.doc";
            Document doc = new Document(GetPath(strLinkPath + "\\" + strLinkName));
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.PageSetup.PaperSize = PaperSize.A4;
            builder.InsertHtml(pnTourPrice.InnerHtml);
            NodeCollection paragraphs = doc.GetChildNodes(Aspose.Words.NodeType.Paragraph, true);

            foreach (Paragraph paragraph in paragraphs)
            {
                paragraph.ParagraphFormat.SpaceAfterAuto = false;
                paragraph.ParagraphFormat.SpaceAfter = 0;
            }
            //doc.Range.Replace(new System.Text.RegularExpressions.Regex(ControlChar.LineBreak), new ReplaceEvaluator(AddressOf ReplaceActionPerformed), false);

            ParagraphFormat paragraphFormat = builder.ParagraphFormat;
            paragraphFormat.SpaceAfter = 0;
            paragraphFormat.SpaceBefore = 0;
            paragraphFormat.SpaceAfterAuto = true;
            paragraphFormat.SpaceBeforeAuto = true;
            paragraphFormat.LineSpacing = 0;
            paragraphFormat.LineSpacingRule = LineSpacingRule.AtLeast;

            doc.Save(strFileName + ".doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
        }
        public System.Data.DataSet GetHTMLCustomizeTourForExport(string strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            return bus.ActionTourBase(strJson);
        }

        private string GetPath(string path)
        {
            return System.Web.Hosting.HostingEnvironment.MapPath("~/" + path);
        }
    }
}