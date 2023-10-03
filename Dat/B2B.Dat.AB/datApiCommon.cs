using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace B2B.Dat.AB
{
    public class datApiCommon
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
        public System.Data.DataSet ActionTour_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPBT_", strFct_Name);
        }
        public System.Data.DataSet ActionTourBase_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPTB_", strFct_Name);
        }
        public System.Data.DataSet ActionDeal_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPOD_", strFct_Name);
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
        public System.Data.DataSet ActionPriceSupp_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPPS_", strFct_Name);
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
        public System.Data.DataSet ActionStoreSupplier_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPSP_", strFct_Name);
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

        public System.Data.DataSet ActionGuide(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPGD_", strFct_Name);
        }
        public System.Data.DataSet ActionGuide_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPGD_", strFct_Name);
        }
        public System.Data.DataSet ActionMember(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPMB_", strFct_Name);
        }
        public System.Data.DataSet ActionMember_Json(B2B.Ent.AB.entApiCommon.entJson data, string strFct_Name)
        {
            return GetActionSPByJSON(data, "SPMB_", strFct_Name);
        }

        //------------------END(10/08/2019)


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


        public DataSet GetActionSPByJSON(B2B.Ent.AB.entApiCommon.entJson data, string strPreSP, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand(strPreSP + strFct_Name, sqlConn);
        
            sqlComm.Parameters.AddWithValue("@strCompanyGUID", data.strCompanyGUID);
            sqlComm.Parameters.AddWithValue("@strJson1", data.strJson1);
            sqlComm.Parameters.AddWithValue("@strJson2", data.strJson2);
            sqlComm.Parameters.AddWithValue("@strJson3", data.strJson3);
            sqlComm.Parameters.AddWithValue("@strJson4", data.strJson4);
            sqlComm.Parameters.AddWithValue("@strJson5", data.strJson5);
            if (data.intTotalPrm > 1)
            {
                sqlComm.Parameters.AddWithValue("@strJson6", data.strJson6);
                sqlComm.Parameters.AddWithValue("@strJson7", data.strJson7);
                sqlComm.Parameters.AddWithValue("@strJson8", data.strJson8);
                sqlComm.Parameters.AddWithValue("@strJson9", data.strJson9);
                sqlComm.Parameters.AddWithValue("@strJson10", data.strJson10);
            }
            if (data.intTotalPrm > 2)
            {
                sqlComm.Parameters.AddWithValue("@strJson11", data.strJson11);
                sqlComm.Parameters.AddWithValue("@strJson12", data.strJson12);
                sqlComm.Parameters.AddWithValue("@strJson13", data.strJson13);
                sqlComm.Parameters.AddWithValue("@strJson14", data.strJson14);
                sqlComm.Parameters.AddWithValue("@strJson15", data.strJson15);
            }
            if (data.intTotalPrm > 3)
            {
                sqlComm.Parameters.AddWithValue("@strJson16", data.strJson16);
                sqlComm.Parameters.AddWithValue("@strJson17", data.strJson17);
                sqlComm.Parameters.AddWithValue("@strJson18", data.strJson18);
                sqlComm.Parameters.AddWithValue("@strJson19", data.strJson19);
                sqlComm.Parameters.AddWithValue("@strJson20", data.strJson20);
            }

            sqlComm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
}
