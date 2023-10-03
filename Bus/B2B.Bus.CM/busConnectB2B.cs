using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.CM;
using B2B.Ent.CM;
using System.Data;

namespace B2B.Bus.CM
{
    public class busConnectB2B
    {
        #region TOUR------------------------------------------
        public System.Data.DataSet AddModuleProductionFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddModuleProductionFromTMSXML(ent);
        }

        public System.Data.DataSet UpdOrderBookingStatus(string strOrderBookingGUID, Boolean IsTransferTMS, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.UpdOrderBookingStatus(strOrderBookingGUID, IsTransferTMS, strUserGUID);
        }
        public System.Data.DataSet GetBookingTransferDataConfig(string strOrderBookingGUID, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetBookingTransferDataConfig(strOrderBookingGUID, strUserGUID);
        }
        public string GetListBookingTransferTMS(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetListBookingTransferTMS(intCurrPage, intPageSize, ref intTotalRecords, dtmDateFrom, dtmDateTo, strWhere, intType, strUserGUID);
        }
        public System.Data.DataSet AddClientContactFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddClientContactFromTMSXML(ent);
        }
        public System.Data.DataSet AddSupplierFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddSupplierFromTMSXML(ent);
        }
        public System.Data.DataSet AddTourBaseToBookingFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddTourBaseToBookingFromTMSXML(ent);
        }
        public System.Data.DataSet AddTourBaseFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddTourBaseFromTMSXML(ent);
        }
        public System.Data.DataSet AddServiceItemTourFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddServiceItemTourFromTMSXML(ent);
        }
        //----------------MrHieu(12/06/2019)(1)
        public System.Data.DataSet AddSetTourFixFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddSetTourFixFromTMSXML(ent);
        }
        //----------------END(12/06/2019)(1)
        //----------------MrHieu(13/06/2019)(1)
        public System.Data.DataSet AddSetTourFromTMSXML(B2B.Ent.CM.entCommond.entDataPost ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddSetTourFromTMSXML(ent);
        }
        //----------------END(13/06/2019)(1)
        public System.Data.DataSet UpdTourDayImages(entConnectB2B.entPostImage ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.UpdTourDayImages(ent);
        }
        public System.Data.DataSet UpdTourDayImagesByServiceItemGUID(entConnectB2B.entPostImage ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.UpdTourDayImagesByServiceItemGUID(ent);
        }
        #endregion


        #region GUIDE-----------------------------------------
        public System.Data.DataSet UpdGuideBookingStatus(string strGuideBookingGUID, Boolean IsTransferTMS, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.UpdGuideBookingStatus(strGuideBookingGUID, IsTransferTMS, strUserGUID);
        }
        public System.Data.DataSet GetGuideBookingTransferDataConfig(string strGuideBookingGUID, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetGuideBookingTransferDataConfig(strGuideBookingGUID, strUserGUID);
        }
        public string GetListGuideBookingTransferTMS(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetListGuideBookingTransferTMS(intCurrPage, intPageSize, ref intTotalRecords, dtmDateFrom, dtmDateTo, strWhere, intType, strUserGUID);
        }
        //public int UpdTopNotificationIsRead(string strGuideGUID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.UpdTopNotificationIsRead(strGuideGUID);
        //}
        //public System.Data.DataSet GetListGuideExpectedCost(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetListGuideExpectedCost(strGuideBookingGUID, strGuideGUID, intLangID);
        //}
        //public DataSet GetFilterNotification(int intCurrPage, int intPageSize, ref long lngTotalRecords, string strWhere, string strGuideGUID, ref long intTotalUnRead)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetFilterNotification(intCurrPage, intPageSize, ref lngTotalRecords, strWhere, strGuideGUID, ref intTotalUnRead);
        //}
        //public System.Data.DataSet GetListBookingGuidePayment(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetListBookingGuidePayment(strGuideBookingGUID, strGuideGUID, intLangID);
        //}
        //public System.Data.DataSet GetProgramByGuideBookingGUID(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetProgramByGuideBookingGUID(strGuideBookingGUID, strGuideGUID, intLangID);
        //}
        //public System.Data.DataSet GetGuideBookingDetail(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetGuideBookingDetail(strGuideBookingGUID, strGuideGUID, intLangID);
        //}
        //public DataSet GetFilterGuideProgram(int intCurrPage, int intPageSize, ref long lngTotalRecords, string strWhere, string strGuideGUID, string strOrder, int intLangID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.GetFilterGuideProgram(intCurrPage, intPageSize, ref lngTotalRecords, strWhere, strGuideGUID, strOrder, intLangID);
        //}
        //public string DelGuidePaymentService(string strGuidePaymentServiceGUID, string strGuideGUID)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.DelGuidePaymentService(strGuidePaymentServiceGUID, strGuideGUID);
        //}
        //public int AddGuideServiceActual(entCommond.entGuideModel ent)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.AddGuideServiceActual(ent);
        //}
        //public int UpdGuideServiceActual(entCommond.entGuideModel ent)
        //{
        //    datConnectB2B dat = new datConnectB2B();
        //    return dat.UpdGuideServiceActual(ent);
        //}
        public System.Data.DataSet GetHTMLSendEmailActiveUser(string strPNGClientGUID, string strGuideGUID)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetHTMLSendEmailActiveUser(strPNGClientGUID, strGuideGUID);
        }
        public System.Data.DataSet GetGuideDetailByGuideLicenceNo(string strGuideLicenceNo)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.GetGuideDetailByGuideLicenceNo(strGuideLicenceNo);
        }
        public System.Data.DataSet AddOrUpdGuideFromTMS(entCommond.entXML ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddOrUpdGuideFromTMS(ent);
        }
        public System.Data.DataSet AddOrUpdGuideProgramFromTMS(entCommond.entXML ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddOrUpdGuideProgramFromTMS(ent);
        }
        public System.Data.DataSet AddOrUpdGuidePaymentFromTMS(entCommond.entXML ent)
        {
            datConnectB2B dat = new datConnectB2B();
            return dat.AddOrUpdGuidePaymentFromTMS(ent);
        }
        #endregion
    }
}
