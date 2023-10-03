using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using TMS.Base;
using B2B.Ent.SL;

namespace B2B.Dat.SL
{
    public class datTour
    {
        //mypro
        public string GetHTMLOverviewProgramForGuide(entCommond.entGuideModal ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", ent.strGuideGUID);
            SqlParameter p_strGuideBookingGUID = new SqlParameter("strGuideBookingGUID", ent.strGuideBookingGUID);
            SqlParameter p_strGuideProgramGUID = new SqlParameter("strGuideProgramGUID", ent.strGuideProgramGUID);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetHTMLOverviewProgramForGuide"
                                                        , p_strGuideGUID
                                                        , p_strGuideBookingGUID
                                                        , p_strGuideProgramGUID
                                                        , p_strUserGUID);
                return GenderHTMLBasic(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //mypro,page guide pay
        public string UpdGuideBookingPaid(entCommond.entGuideModal ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strGuideBookingGUID = new SqlParameter("strGuideBookingGUID", ent.strGuideBookingGUID);
            SqlParameter p_IsPaid = new SqlParameter("IsPaid", ent.IsPaid);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_UpdGuideBookingPaid"
                                                        , p_strGuideBookingGUID
                                                        , p_IsPaid
                                                        , p_strUserGUID);
                return ds.Tables[ds.Tables.Count - 1].Rows[0][0].ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //mypro,page guide pay
        public string UpdGuideServiceActual(entCommond.entGuideModal ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", ent.strGuideGUID);
            SqlParameter p_strGuidePaymentServiceGUID = new SqlParameter("strGuidePaymentServiceGUID", ent.strGuidePaymentServiceGUID);
            SqlParameter p_intActualQuantity = new SqlParameter("intActualQuantity", ent.intActualQuantity);
            SqlParameter p_dblActualPriceUnit = new SqlParameter("dblActualPriceUnit", ent.dblActualPriceUnit);
            SqlParameter p_dblActualPriceTotal = new SqlParameter("dblActualPriceTotal", ent.dblActualPriceTotal);
            SqlParameter p_strServiceName = new SqlParameter("strServiceName", ent.strServiceName);
            SqlParameter p_strActualRemarkForGuide = new SqlParameter("strActualRemarkForGuide", ent.strActualRemarkForGuide);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_UpdGuideServiceActual"
                                                        , p_strGuideGUID
                                                        , p_strGuidePaymentServiceGUID
                                                        , p_intActualQuantity
                                                        , p_dblActualPriceUnit
                                                        , p_dblActualPriceTotal
                                                        , p_strActualRemarkForGuide
                                                        , p_strServiceName
                                                        , p_strUserGUID);
                return ds.Tables[ds.Tables.Count - 1].Rows[0][0].ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //mypro,page guide pay
        public DataSet GetListBookingGuidePayment(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", strGuideGUID);
            SqlParameter p_strGuideBookingGUID = new SqlParameter("strGuideBookingGUID", strGuideBookingGUID);
            SqlParameter p_intLangID = new SqlParameter("intLangID", intLangID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetListBookingGuidePayment", p_strGuideBookingGUID, p_strGuideGUID, p_intLangID);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //mypro,page guide pay
        public string GetListGuideBooking(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_intCurrPage = new SqlParameter("intCurrPage", intCurrPage);
            SqlParameter p_intPageSize = new SqlParameter("intPageSize", intPageSize);
            SqlParameter p_intTotalRecords = new SqlParameter("intTotalRecords", intTotalRecords);
            SqlParameter p_dtmDateFrom = new SqlParameter("dtmDateFrom", dtmDateFrom);
            SqlParameter p_dtmDateTo = new SqlParameter("dtmDateTo", dtmDateTo);
            SqlParameter p_strWhere = new SqlParameter("strWhere", strWhere);
            SqlParameter p_intType = new SqlParameter("intType", intType);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", strUserGUID);
            p_intTotalRecords.Direction = ParameterDirection.Output;
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetListGuideBooking", p_intCurrPage, p_intPageSize, p_intTotalRecords, p_dtmDateFrom
                    , p_dtmDateTo, p_strWhere, p_intType, p_strUserGUID);
                intTotalRecords = Convert.ToInt64(p_intTotalRecords.Value);
                return GenderTableHTML(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //dash
        public System.Data.DataSet GetDashBoardByGuideBooking(DateTime? dtmDateFrom, DateTime? dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_dtmDateFrom = new SqlParameter("dtmDateFrom", dtmDateFrom);
            SqlParameter p_dtmDateTo = new SqlParameter("dtmDateTo", dtmDateTo);
            SqlParameter p_strWhere = new SqlParameter("strWhere", strWhere);
            SqlParameter p_intType = new SqlParameter("intType", intType);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", strUserGUID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetDashBoardByGuideBooking", p_dtmDateFrom, p_dtmDateTo, p_strWhere, p_intType, p_strUserGUID);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
        public System.Data.DataSet GetTourDetail(string strTourGUID, int intTypeID, string strUserGUID)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            SqlParameter p_strTourGUID = new SqlParameter("@strTourGUID", strTourGUID);
            SqlParameter p_intTypeID = new SqlParameter("@intTypeID", intTypeID);
            SqlParameter p_strUserGUID = new SqlParameter("@strUserGUID", strUserGUID);
            System.Data.DataSet ds = new System.Data.DataSet();
            return SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPBT_GetTourDetail", p_strTourGUID, p_intTypeID, p_strUserGUID);
        }
       

        public string DelTour(entCommond.entTour ent)
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlParameter p_strTourGUID = new SqlParameter("strTourGUID", ent.strTourGUID);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            try
            {
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPBT_DelTour"
                                                        , p_strTourGUID
                                                        , p_strUserGUID);
                return ds.Tables[ds.Tables.Count - 1].Rows[0][0].ToString().Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public string GenderTableHTML(DataTable t)
        {
            string strHTML = "<table class='table table-bordered table-responsive table-hover'><thead><tr>";

            for (int i = 0; i < t.Columns.Count; i++)
            {
                if (t.Columns[i].ColumnName.ToString() != "No")
                {
                    strHTML = strHTML + "<th>" + t.Columns[i].ColumnName.ToString() + "</th>";
                }

            }
            strHTML = strHTML + "</tr></thead><tbody>";

            for (int i = 0; i < t.Rows.Count; i++)
            {
                strHTML = strHTML + "<tr>";
                if (t.Rows[i][1].ToString() != "" || (i == 0 & t.Rows[i][1].ToString() == ""))
                {
                    strHTML = strHTML + "<td rowspan='" + GetCountSubHotelItem(t, i, 1).ToString() + "'>" + t.Rows[i][1].ToString() + "</td>";
                }
                if (t.Rows[i][2].ToString() != "" || (i == 0 & t.Rows[i][2].ToString() == ""))
                {
                    strHTML = strHTML + "<td rowspan='" + GetCountSubHotelItem(t, i, 2).ToString() + "'>" + t.Rows[i][2].ToString() + "</td>";
                }
                for (int j = 3; j < t.Columns.Count; j++)
                {
                    if (t.Rows[i][j].ToString() == "0")
                    {
                        strHTML = strHTML + "<td>N/A</td>";
                    }
                    else { strHTML = strHTML + "<td>" + t.Rows[i][j].ToString() + "</td>"; }

                }
                strHTML = strHTML + "</tr>";
            }
            if (t.Rows.Count == 0)
            {
                strHTML = strHTML + "<tr><td style='text-align: left;' colspan='" + (t.Columns.Count + 1).ToString() + "'>No data...</td></tr>";
            }
            strHTML = strHTML + "</tbody></table>";
            return strHTML;
        }

        public string GenderHTMLBasic(DataTable t)
        {
            string strHTML = "";
            for (int i = 0; i < t.Rows.Count; i++)
            {
                for (int j = 0; j < t.Columns.Count; j++)
                {
                    strHTML += t.Rows[i][j].ToString();
                }
            }
            return strHTML;
        }

        private int GetCountSubHotelItem(System.Data.DataTable t, int intRowIndex, int intColumnIndex)
        {
            int intReturn = 1;
            for (int m = intRowIndex + 1; m < t.Rows.Count; m++)
            {
                if (t.Rows[m][intColumnIndex].ToString() == "")
                {
                    intReturn = intReturn + 1;
                }
                else
                {
                    break;
                }
            }
            return intReturn;
        }
        // public static string ConvertTableToString(DataTable dt)
        // {
        //     string strHTML = "";
        //     for (int r = 0; r < dt.Rows.Count; r++){
        //         for (int c = 0; c < dt.Columns.Count; c++){
        //             strHTML += dt.Rows[r][c].ToString();
        //         }
        //     }
        //     return strHTML;
        // }
    }
}
