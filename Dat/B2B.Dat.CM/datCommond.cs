﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TMS.Base;

namespace B2B.Dat.CM
{
    public class datCommond
    {

        SqlConnection sqlConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        //-------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionMember(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPMB_", strFct_Name);
        }
        //-------------------END(26/07/2019)
        public System.Data.DataSet ActionMenu(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIM_", strFct_Name);
        }
        public System.Data.DataSet ActionHelper(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPTH_", strFct_Name);
        }
        public System.Data.DataSet ActionGuide(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPGD_", strFct_Name);
        }

        public System.Data.DataSet ActionInfoSupplier(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPIS_", strFct_Name);
        }
        public System.Data.DataSet ActionTraveller(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPBC_", strFct_Name);
        }


        public System.Data.DataSet ActionTemplate(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPTP_", strFct_Name);
        }

        public System.Data.DataSet ActionMenuMap(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPDM_", strFct_Name);
        }
        public System.Data.DataSet ActionSrcIndex(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPSI_", strFct_Name);
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

        
        //-------------------MrHieu(06/06/2019)
        public System.Data.DataSet GetListItemInPanel(string strXml, string strFct_Name)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            SqlParameter p_strXml = new SqlParameter("@strXml", strXml);
            return SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPIM_" + strFct_Name, p_strXml);
        }
        //-------------------END(06/06/2019)
        //-------------------MrHieu(25/06/2019)
        public System.Data.DataSet GetListItemInUser(string strXml, string strFct_Name)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            SqlParameter p_strXml = new SqlParameter("@strXml", strXml);
            return SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_" + strFct_Name, p_strXml);
        }
        //-------------------END(25/06/2019)
        

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
