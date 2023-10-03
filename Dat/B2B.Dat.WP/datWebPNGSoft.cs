using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TMS.Base;

namespace B2B.Dat.WP
{
    public class datWebPNGSoft
    {
        SqlConnection sqlConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB_WP"].ConnectionString);

        public System.Data.DataSet ActionMenu(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIM_", strFct_Name);
        }
        public System.Data.DataSet ActionNews(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIN_", strFct_Name);
        }
        public System.Data.DataSet ActionGallery(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIG_", strFct_Name);
        }
        public System.Data.DataSet ActionSupport(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIS_", strFct_Name);
        }
        public System.Data.DataSet ActionAdvertise(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPAD_", strFct_Name);
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


        public System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strTableName = new SqlParameter("@strTableName", strTableName);
            SqlParameter p_strFeildSelect = new SqlParameter("@strFeildSelect", strFeildSelect);
            SqlParameter p_strWhere = new SqlParameter("@strWhere", strWhere);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPCM_GetSQLDataByTableConfig", p_strTableName, p_strFeildSelect, p_strWhere);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0];
        }
        public DataSet GetDDLByCode(string strDDLCode)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strDDLCode = new SqlParameter("@strDDLCode", strDDLCode);

            DataSet ds;
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMC_GetDDlByCode", p_strDDLCode);
            return ds;
        }
        public DataSet GetDDLByCode(string strDDLCode, string strWhere)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strDDLCode = new SqlParameter("@strDDLCode", strDDLCode);
            SqlParameter p_strWhere = new SqlParameter("@strWhere", strWhere);

            DataSet ds;
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMC_GetDDlByCodeWhere", p_strDDLCode, p_strWhere);
            return ds;
        }
    }
}
