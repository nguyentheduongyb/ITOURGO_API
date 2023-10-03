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
    public class datConnectB2B
    {
        string strConn = "";
        public datConnectB2B()
        {
            strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }


        #region TOUR------------------------------------------
        public System.Data.DataSet AddModuleProductionFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPBR_AddModuleProductionFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }

        public System.Data.DataSet UpdOrderBookingStatus(string strOrderBookingGUID,Boolean IsTransferTMS, string strUserGUID)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strOrderBookingGUID = new SqlParameter("@strOrderBookingGUID", strOrderBookingGUID);
            SqlParameter p_IsTransferTMS = new SqlParameter("@IsTransferTMS", IsTransferTMS);
            SqlParameter p_strUserGUID = new SqlParameter("@strUserGUID", strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPOB_UpdOrderBookingStatus", p_strOrderBookingGUID, p_IsTransferTMS, p_strUserGUID);
            return ds;
        }
        public System.Data.DataSet GetBookingTransferDataConfig(string strOrderBookingGUID, string strUserGUID)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strOrderBookingGUID = new SqlParameter("@strOrderBookingGUID", strOrderBookingGUID);
            SqlParameter p_strUserGUID = new SqlParameter("@strUserGUID", strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPOB_GetBookingTransferDataConfig", p_strOrderBookingGUID, p_strUserGUID);
            return ds;
        }
        public string GetListBookingTransferTMS(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
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
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPOB_GetListBookingTransferTMS", p_intCurrPage, p_intPageSize, p_intTotalRecords, p_dtmDateFrom
                    , p_dtmDateTo, p_strWhere, p_intType, p_strUserGUID);
                intTotalRecords = Convert.ToInt64(p_intTotalRecords.Value);
                return GenderHTMLBasic(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public System.Data.DataSet AddClientContactFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPMK_AddClientContactFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }
        public System.Data.DataSet AddSupplierFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPSP_AddSupplierFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }

        public System.Data.DataSet AddTourBaseToBookingFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTB_AddTourBaseToBookingFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }

        public System.Data.DataSet AddTourBaseFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTB_AddTourBaseFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }
        public System.Data.DataSet AddServiceItemTourFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strUserGUID = new SqlParameter("strCompanyGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTB_AddServiceItemTourFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strUserGUID);
            return ds;
        }
        //----------------MrHieu(12/06/2019)(1)
        public System.Data.DataSet AddSetTourFixFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strCompanyGUID = new SqlParameter("strCompanyGUID", ent.strCompanyGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTM_AddSetTourFixFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strCompanyGUID);
            return ds;
        }
        //----------------END(12/06/2019)(1)
        //----------------MrHieu(13/06/2019)(1)
        public System.Data.DataSet AddSetTourFromTMSXML(entCommond.entDataPost ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strDataRow1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strDataRow2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strDataRow3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strDataRow4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strDataRow5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strDataRow6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strDataRow7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strDataRow8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strDataRow9);
            SqlParameter p_strCompanyGUID = new SqlParameter("strCompanyGUID", ent.strCompanyGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTM_AddSetTourFromTMSXML", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strCompanyGUID);
            return ds;
        }
        //----------------END(13/06/2019)(1)
        public System.Data.DataSet UpdTourDayImages(entConnectB2B.entPostImage ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strTourDayGUID = new SqlParameter("strTourDayGUID", ent.strTourDayGUID);
            SqlParameter p_strImage1 = new SqlParameter("strImage1", ent.strImage1);
            SqlParameter p_strImage2 = new SqlParameter("strImage2", ent.strImage2);
            SqlParameter p_strImage3 = new SqlParameter("strImage3", ent.strImage3);
            SqlParameter p_strImage4 = new SqlParameter("strImage4", ent.strImage4);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTB_UpdTourDayImages", p_strTourDayGUID, p_strImage1, p_strImage2, p_strImage3, p_strImage4, p_strUserGUID);
            return ds;
        }

        public System.Data.DataSet UpdTourDayImagesByServiceItemGUID(entConnectB2B.entPostImage ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strServiceItemGUID = new SqlParameter("strServiceItemGUID", ent.strServiceItemGUID);
            SqlParameter p_strImage1 = new SqlParameter("strImage1", ent.strImage1);
            SqlParameter p_strImage2 = new SqlParameter("strImage2", ent.strImage2);
            SqlParameter p_strImage3 = new SqlParameter("strImage3", ent.strImage3);
            SqlParameter p_strImage4 = new SqlParameter("strImage4", ent.strImage4);
            SqlParameter p_strUserGUID = new SqlParameter("strUserGUID", ent.strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPTB_UpdTourDayImagesByServiceItemGUID", p_strServiceItemGUID, p_strImage1, p_strImage2, p_strImage3, p_strImage4, p_strUserGUID);
            return ds;
        }
        #endregion


        #region GUIDE-----------------------------------------
        public System.Data.DataSet UpdGuideBookingStatus(string strGuideBookingGUID, Boolean IsTransferTMS, string strUserGUID)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strGuideBookingGUID = new SqlParameter("@strGuideBookingGUID", strGuideBookingGUID);
            SqlParameter p_IsTransferTMS = new SqlParameter("@IsTransferTMS", IsTransferTMS);
            SqlParameter p_strUserGUID = new SqlParameter("@strUserGUID", strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_UpdGuideBookingStatus", p_strGuideBookingGUID, p_IsTransferTMS, p_strUserGUID);
            return ds;
        }
        public System.Data.DataSet GetGuideBookingTransferDataConfig(string strGuideBookingGUID, string strUserGUID)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strGuideBookingGUID = new SqlParameter("@strGuideBookingGUID", strGuideBookingGUID);
            SqlParameter p_strUserGUID = new SqlParameter("@strUserGUID", strUserGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetGuideBookingTransferDataConfig", p_strGuideBookingGUID, p_strUserGUID);
            return ds;
        }   
        public string GetListGuideBookingTransferTMS(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
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
                var ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetListGuideBookingTransferTMS", p_intCurrPage, p_intPageSize, p_intTotalRecords, p_dtmDateFrom
                    , p_dtmDateTo, p_strWhere, p_intType, p_strUserGUID);
                intTotalRecords = Convert.ToInt64(p_intTotalRecords.Value);
                return GenderHTMLBasic(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }
        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(bytes);
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }
        public static string Encrypt(string cleanString)
        {
            byte[] encodedPassword = new System.Text.UnicodeEncoding().GetBytes(cleanString);
            // need MD5 to calculate the hash
            var hash = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            return BitConverter.ToString(hash);
        }
        public System.Data.DataSet GetHTMLSendEmailActiveUser(string strPNGClientGUID, string strGuideGUID)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            string strPassword = GetRandomAlphanumericString(10);
            SqlParameter p_strPassword = new SqlParameter("strPassword", Encrypt(strPassword));
            SqlParameter p_strPasDisplay = new SqlParameter("strPasDisplay", strPassword);
            SqlParameter p_strPNGClientGUID = new SqlParameter("strPNGClientGUID", strPNGClientGUID);
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", strGuideGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetHTMLSendEmailActiveUser", p_strGuideGUID, p_strPNGClientGUID, p_strPassword, p_strPasDisplay);
            return ds;
        }
        public System.Data.DataSet GetGuideDetailByGuideLicenceNo(string strGuideLicenceNo)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strGuideLicenceNo = new SqlParameter("strGuideLicenceNo", strGuideLicenceNo);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_GetGuideDetailByGuideLicenceNo", p_strGuideLicenceNo);
            return ds;
        }
        public System.Data.DataSet AddOrUpdGuideFromTMS(entCommond.entXML ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strXML1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strXML2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strXML3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strXML4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strXML5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strXML6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strXML7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strXML8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strXML9);
            SqlParameter p_strPNGClientGUID = new SqlParameter("strPNGClientGUID", ent.strPNGClientGUID);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_AddOrUpdGuideFromTMS", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strPNGClientGUID);
            return ds;
        }
        public System.Data.DataSet AddOrUpdGuideProgramFromTMS(entCommond.entXML ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strXML1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strXML2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strXML3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strXML4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strXML5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strXML6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strXML7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strXML8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strXML9);
            SqlParameter p_strPNGClientGUID = new SqlParameter("strPNGClientGUID", ent.strPNGClientGUID);
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", ent.strGuideGUID);
            SqlParameter p_strRemark = new SqlParameter("strRemark", ent.strRemark);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_AddOrUpdGuideProgramFromTMS", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strPNGClientGUID, p_strGuideGUID, p_strRemark);
            return ds;
        }
        public System.Data.DataSet AddOrUpdGuidePaymentFromTMS(entCommond.entXML ent)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlParameter p_strXML1 = new SqlParameter("strXML1", ent.strXML1);
            SqlParameter p_strXML2 = new SqlParameter("strXML2", ent.strXML2);
            SqlParameter p_strXML3 = new SqlParameter("strXML3", ent.strXML3);
            SqlParameter p_strXML4 = new SqlParameter("strXML4", ent.strXML4);
            SqlParameter p_strXML5 = new SqlParameter("strXML5", ent.strXML5);
            SqlParameter p_strXML6 = new SqlParameter("strXML6", ent.strXML6);
            SqlParameter p_strXML7 = new SqlParameter("strXML7", ent.strXML7);
            SqlParameter p_strXML8 = new SqlParameter("strXML8", ent.strXML8);
            SqlParameter p_strXML9 = new SqlParameter("strXML9", ent.strXML9);

            SqlParameter p_strPNGClientGUID = new SqlParameter("strPNGClientGUID", ent.strPNGClientGUID);
            SqlParameter p_strGuideGUID = new SqlParameter("strGuideGUID", ent.strGuideGUID);
            SqlParameter p_strRemark = new SqlParameter("strRemark", ent.strRemark);
            ds = SqlHelper.ExecuteDataset(strConn, CommandType.StoredProcedure, "SPGD_AddOrUpdGuidePaymentFromTMS", p_strXML1, p_strXML2, p_strXML3, p_strXML4, p_strXML5, p_strXML6, p_strXML7, p_strXML8, p_strXML9, p_strPNGClientGUID, p_strGuideGUID, p_strRemark);
            return ds;
        }
        #endregion

        public string GenderHTMLBasic(DataTable t)
        {
            string strHTML = "<table class='png_gridtable' cellspacing='0' rules='all' border='1' style='width:99%; border-collapse:collapse;'><thead><tr>";

            for (int i = 0; i < t.Columns.Count; i++)
            {
                strHTML = strHTML + "<th>" + t.Columns[i].ColumnName.ToString() + "</th>";

            }
            strHTML = strHTML + "</tr></thead><tbody>";

            for (int i = 0; i < t.Rows.Count; i++)
            {
                strHTML = strHTML + "<tr>";
                for (int j = 0; j < t.Columns.Count; j++)
                {
                    strHTML = strHTML + "<td>" + t.Rows[i][j].ToString() + "</td>";
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
    }
}
