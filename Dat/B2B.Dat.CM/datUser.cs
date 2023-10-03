using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Base;
using B2B.Ent.CM;

namespace B2B.Dat.CM
{
    public class datUser
    {
        //private SqlParameter p_strCompanyPhone;

        public System.Data.DataSet GetMemberDetail(string strMemberGUID)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            SqlParameter p_strUserGUID = new SqlParameter("@strMemberGUID", strMemberGUID);
            System.Data.DataSet ds = new System.Data.DataSet();
            return SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_GetMemberDetail", p_strUserGUID);
        }

        public string UpdCompanyInfo(entCompany ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strCompanyGUID = new SqlParameter("@strCompanyGUID", ent.strCompanyGUID);
            SqlParameter p_strCompanyName = new SqlParameter("@strCompanyName", ent.strCompanyName);
            SqlParameter p_strCompanyPhone = new SqlParameter("@strCompanyPhone", ent.strCompanyPhone);
            SqlParameter p_strCompanyEmail = new SqlParameter("@strCompanyEmail", ent.strCompanyEmail);
            SqlParameter p_strCompanyFax = new SqlParameter("@strCompanyFax", ent.strCompanyFax);
            SqlParameter p_strCompanyAddr = new SqlParameter("@strCompanyAddr", ent.strCompanyAddr);
            SqlParameter p_strCompanyWeb = new SqlParameter("@strCompanyWeb", ent.strCompanyWeb);
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_UpdCompanyInfo", p_strCompanyGUID, p_strCompanyName
                    , p_strCompanyPhone, p_strCompanyEmail, p_strCompanyFax, p_strCompanyAddr, p_strCompanyWeb, p_strMemberGUID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string UpdCompanyLogo(entCompany ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strCompanyGUID = new SqlParameter("@strCompanyGUID", ent.strCompanyGUID);
            SqlParameter p_strCompanyLogo = new SqlParameter("@strCompanyLogo", ent.strCompanyLogo);
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_UpdCompanyLogo", p_strCompanyGUID, p_strCompanyLogo, p_strMemberGUID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string UpdMemberInfo(entUser ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            SqlParameter p_strFirstName = new SqlParameter("@strFirstName", ent.strFirstName);
            SqlParameter p_strLastName = new SqlParameter("@strLastName", ent.strLastName);
            SqlParameter p_strFullName = new SqlParameter("@strFullName", ent.strFullName);
            SqlParameter p_strPhone = new SqlParameter("@strPhone", ent.strPhone);
            SqlParameter p_strEmail = new SqlParameter("@strEmail", ent.strEmail);
            SqlParameter p_strContactAddr = new SqlParameter("@strContactAddr", ent.strContactAddr);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_UpdMemberInfo", p_strMemberGUID, p_strFirstName, p_strLastName
                    , p_strFullName, p_strPhone, p_strEmail, p_strContactAddr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string UpdMemberAvartar(entUser ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            SqlParameter p_strAvatar = new SqlParameter("@strAvatar", ent.strAvatar);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_UpdMemberAvartar", p_strMemberGUID, p_strAvatar);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string UpdMemberPassword(entUser ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            SqlParameter p_strOldPassword = new SqlParameter("@strOldPassword", ent.strOldPassword);
            SqlParameter p_strNewPassword = new SqlParameter("@strNewPassword", ent.strNewPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_UpdMemberPassword", p_strMemberGUID, p_strOldPassword, p_strNewPassword);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string CheckMemberPassword(entUser ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            SqlParameter p_strPassword = new SqlParameter("@strPassword", ent.strPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_CheckMemberPassword", p_strMemberGUID, p_strPassword);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public string SetPasswordDirectMember(entUser ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strMemberGUID = new SqlParameter("@strMemberGUID", ent.strMemberGUID);
            SqlParameter p_strPassword = new SqlParameter("@strPassword", ent.strPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMB_SetPasswordDirectMember", p_strMemberGUID, p_strPassword);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }
        //public System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        //{
        //    string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        //    SqlParameter p_strTableName = new SqlParameter("@strTableName", strTableName);
        //    SqlParameter p_strFeildSelect = new SqlParameter("@strFeildSelect", strFeildSelect);
        //    SqlParameter p_strWhere = new SqlParameter("@strWhere", strWhere);
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    try
        //    {
        //        ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPCM_GetSQLDataByTableConfig", p_strTableName, p_strFeildSelect, p_strWhere);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return ds.Tables[0];
        //}
    }
}
