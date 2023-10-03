using B2B.Ent.SL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TMS.Base;

namespace B2B.Dat.SL
{
    public class datCommond
    {
        SqlConnection sqlConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        //-------------------MrHieu(10/07/2019)
        public System.Data.DataSet ActionBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOB_", strFct_Name);
        }
        public System.Data.DataSet ActionPayBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPPA_", strFct_Name);
        }
        public System.Data.DataSet ActionRcvBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPRA_", strFct_Name);
        }
        public System.Data.DataSet ActionAHBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPAB_", strFct_Name);
        }
        public System.Data.DataSet ActionTour(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPBT_", strFct_Name);
        }
        //-------------------END(10/07/2019)

        //------------------MrHieu(16/07/2019)
        public System.Data.DataSet ActionRequest(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPBR_", strFct_Name);
        }
        public System.Data.DataSet ActionCountry(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPMC_", strFct_Name);
        }
        public System.Data.DataSet ActionCommon(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPCM_", strFct_Name);
        }
        public System.Data.DataSet ActionSupplier(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPBS_", strFct_Name);
        }
        //------------------END(16/07/2019)

        //------------------MrHieu(24/07/2019)
        public System.Data.DataSet ActionChannelPrice(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPCP_", strFct_Name);
        }
        //------------------END(24/07/2019)

        public System.Data.DataSet ActionPriceSupp(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPPS_", strFct_Name);
        }

        public System.Data.DataSet ActionNews(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIN_", strFct_Name);
        }
        public System.Data.DataSet ActionClient(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPPC_", strFct_Name);
        }

        public System.Data.DataSet ActionStoreSupplier(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPSP_", strFct_Name);
        }

        //------------------MrTien(10/08/2019)

        public System.Data.DataSet ActionVoucher(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPVC_", strFct_Name);
        }


        public System.Data.DataSet ActionNotify(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPNF_", strFct_Name);
        }


        public System.Data.DataSet ActionSystem(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPSS_", strFct_Name);
        }

        public System.Data.DataSet ActionAllotment(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPAL_", strFct_Name);
        }

        public System.Data.DataSet ActionLog(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPLG_", strFct_Name);
        }

        public System.Data.DataSet ActionSaleReq(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPSR_", strFct_Name);
        }
        public System.Data.DataSet ActionTourBase(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPTB_", strFct_Name);
        }
        public System.Data.DataSet ActionMenuMap(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPDM_", strFct_Name);
        }

        public System.Data.DataSet ActionGuide(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPGD_", strFct_Name);
        }
        public System.Data.DataSet ActionCart(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOC_", strFct_Name);
        }

        public System.Data.DataSet ActionAgtHostBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOH_", strFct_Name);
        }

        public System.Data.DataSet ActionReportBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOR_", strFct_Name);
        }

        public System.Data.DataSet ActionAgtBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOA_", strFct_Name);
        }

        public System.Data.DataSet ActionChannel(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPCN_", strFct_Name);
        }
        //------------------END(10/08/2019)

        public System.Data.DataSet GetListEmailConfig(string strJson)
        {
            return GetActionSP(strJson, "SPMS_", "GetListEmailConfig");
        }


        public DataSet GetActionSP(string strJson, string strPreSP, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand(strPreSP + strFct_Name, sqlConn);

            var json_serializer = new JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(strJson);
            DataTable d = new DataTable();
            foreach (var record in routes_list)
            {
                sqlComm.Parameters.AddWithValue("@" + record.Key, record.Value ?? DBNull.Value);
            }

            sqlComm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public static DataTable GetComboboxByCode(string strCombocode, string strWhere = null)
        {
            if (strWhere == "") { strWhere = null; }
            string strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            //var json_serializer = new JavaScriptSerializer();
            //var routes_list = json_serializer.DeserializeObject(strWhere);
            DataSet ds = new DataSet();

            SqlParameter p_strCombocode = new SqlParameter("strCombocode", strCombocode);
            SqlParameter p_strWhere = new SqlParameter("strWhere", strWhere);
            try
            {
                ds = SqlHelper.ExecuteDataset(strConnect, CommandType.StoredProcedure, "SPCM_GetComboboxByCode", p_strCombocode, p_strWhere);
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
