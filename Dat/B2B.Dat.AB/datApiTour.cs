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
    public class datApiTour
    {
        SqlConnection sqlConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        string strPreSP = "SPBT_";
        //-------------------MrHieu(10/07/2019)
        public System.Data.DataSet ActionBooking(string strJson, string strFct_Name)
        {
            return GetActionSP(strJson, "SPOB_", strFct_Name);
        }

        //------------------END(10/08/2019)
        public System.Data.DataSet GetListTourPublishInTopByPUB(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand(strPreSP + strFct_Name, sqlConn);
            
            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyPartnerGUID", ent.strCompanyPartnerGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyOwnerGUID", ent.strCompanyOwnerGUID);
            sqlComm.Parameters.AddWithValue("@strPriceLevelGUID", ent.strPriceLevelGUID);
            sqlComm.Parameters.AddWithValue("@intLangID", ent.intLangID);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListCompanyDestinationForHmPgTour(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPMB_" + strFct_Name, sqlConn);

            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyOwnerGUID", ent.strCompanyOwnerGUID);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public System.Data.DataSet GetListTourPublishByPUB(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);

            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyOwnerGUID", ent.strCompanyOwnerGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyPartnerGUID", ent.strCompanyPartnerGUID);
            sqlComm.Parameters.AddWithValue("@strPriceLevelGUID", ent.strPriceLevelGUID);
            sqlComm.Parameters.AddWithValue("@intLangID", ent.intLangID);
            sqlComm.Parameters.AddWithValue("@intCateID", ent.intCateID);
            sqlComm.Parameters.AddWithValue("@strNoOfDayRange", ent.strNoOfDayRange);
            sqlComm.Parameters.AddWithValue("@strFilterServiceName", ent.strFilterServiceName);
            sqlComm.Parameters.AddWithValue("@dtmFilterDateStart", ent.dtmFilterDateStart);
            sqlComm.Parameters.AddWithValue("@dtmFilterDateValidFrom", ent.dtmFilterDateValidFrom);
            sqlComm.Parameters.AddWithValue("@dtmFilterDateValidTo", ent.dtmFilterDateValidTo);
            sqlComm.Parameters.AddWithValue("@strListEasiaCateID", ent.strListEasiaCateID);
            sqlComm.Parameters.AddWithValue("@strListTransportOptionID", ent.strListTransportOptionID);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@strPriceFromRange", ent.strPriceFromRange);
            sqlComm.Parameters.AddWithValue("@intCurrencyView", ent.intCurrencyView);
            sqlComm.Parameters.AddWithValue("@strLocationCode", ent.strLocationCode);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public System.Data.DataSet GetDetailTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);
            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strServiceNameUrl", ent.strServiceNameUrl);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListTourDayByPtn(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);
            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourDayGUID", ent.strTourDayGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListImageFile(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);

            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@strTourImageFileGUID", ent.strTourImageFileGUID);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListTourPaymentTerm(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);

            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourPaymentTermGUID", ent.strTourPaymentTermGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@IsActive", ent.IsActive);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListTourCancellationPolicy(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);
            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourCancellationPolicyGUID", ent.strTourCancellationPolicyGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@IsActive", ent.IsActive);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListPriceItemTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);

            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourPriceItemGUID", ent.strTourPriceItemGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@intNoOfAdult", ent.intNoOfAdult);
            sqlComm.Parameters.AddWithValue("@xmlNoOfChild", ent.xmlNoOfChild);
            sqlComm.Parameters.AddWithValue("@intNoOfSGLSup", ent.intNoOfSGLSup);
            sqlComm.Parameters.AddWithValue("@intNoOfTPLRec", ent.intNoOfTPLRec);
            sqlComm.Parameters.AddWithValue("@dtmFilterDateFrom", ent.dtmFilterDateFrom);
            sqlComm.Parameters.AddWithValue("@dtmFilterDateTo", ent.dtmFilterDateTo);
            sqlComm.Parameters.AddWithValue("@strCompanyOwnerGUID", ent.strCompanyOwnerGUID);
            sqlComm.Parameters.AddWithValue("@IsHasPriceKid", ent.IsHasPriceKid);
            sqlComm.Parameters.AddWithValue("@intCateID", ent.intCateID);
            sqlComm.Parameters.AddWithValue("@intEasiaCateID", ent.intEasiaCateID);
            sqlComm.Parameters.AddWithValue("@intJoinTypeID", ent.intJoinTypeID);
            sqlComm.Parameters.AddWithValue("@intTransportOptionID", ent.intTransportOptionID);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public System.Data.DataSet GetListPaxBookingTourForBkByPUB(B2B.Ent.AB.entApiTour.entFilterData ent, string strFct_Name)
        {
            SqlCommand sqlComm = new SqlCommand("SPBT_" + strFct_Name, sqlConn);
            sqlComm.Parameters.AddWithValue("@strUserGUID", ent.strUserGUID);
            sqlComm.Parameters.AddWithValue("@strTourGUID", ent.strTourGUID);
            sqlComm.Parameters.AddWithValue("@strCompanyOwnerGUID", ent.strCompanyOwnerGUID);
            sqlComm.Parameters.AddWithValue("@strPaxBookingTourCode", ent.strPaxBookingTourCode);
            sqlComm.Parameters.AddWithValue("@intEasiaCateID", ent.intEasiaCateID);
            sqlComm.Parameters.AddWithValue("@intTransportOptionID", ent.intTransportOptionID);
            sqlComm.Parameters.AddWithValue("@intNoOfAdult", ent.intNoOfAdult);
            sqlComm.Parameters.AddWithValue("@strListNoOfChild", ent.strListNoOfChild);
            sqlComm.Parameters.AddWithValue("@intNoOfSGLSup", ent.intNoOfSGLSup);
            sqlComm.Parameters.AddWithValue("@intNoOfTPLRec", ent.intNoOfTPLRec);
            sqlComm.Parameters.AddWithValue("@IsHasPriceKid", ent.IsHasPriceKid);
            sqlComm.Parameters.AddWithValue("@dtmDateValidFrom", ent.dtmDateValidFrom);
            sqlComm.Parameters.AddWithValue("@dtmDateValidTo", ent.dtmDateValidTo);
            sqlComm.Parameters.AddWithValue("@intCurPage", ent.intCurPage);
            sqlComm.Parameters.AddWithValue("@intPageSize", ent.intPageSize);
            sqlComm.Parameters.AddWithValue("@strOrder", ent.strOrder);
            sqlComm.Parameters.AddWithValue("@tblsReturn", ent.tblsReturn);

            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
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
