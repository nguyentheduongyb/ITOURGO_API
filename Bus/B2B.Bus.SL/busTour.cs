using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.SL;
using B2B.Ent.SL;
namespace B2B.Bus.SL
{
    public class busTour
    {
        public string GetHTMLOverviewProgramForGuide(entCommond.entGuideModal ent)
        {
            datTour dat = new datTour();
            return dat.GetHTMLOverviewProgramForGuide(ent);
        }

        public string UpdGuideBookingPaid(entCommond.entGuideModal ent)
        {
            datTour dat = new datTour();
            return dat.UpdGuideBookingPaid(ent);
        }

        public string UpdGuideServiceActual(entCommond.entGuideModal ent)
        {
            datTour dat = new datTour();
            return dat.UpdGuideServiceActual(ent);
        }

        public System.Data.DataSet GetListBookingGuidePayment(string strGuideBookingGUID, string strGuideGUID, int intLangID)
        {
            datTour dat = new datTour();
            return dat.GetListBookingGuidePayment(strGuideBookingGUID, strGuideGUID, intLangID);
        }
       
        public string GetListGuideBooking(int intCurrPage, int intPageSize, ref long intTotalRecords, string dtmDateFrom, string dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            datTour dat = new datTour();
            return dat.GetListGuideBooking(intCurrPage, intPageSize, ref intTotalRecords, dtmDateFrom, dtmDateTo, strWhere, intType, strUserGUID);
        }
        public System.Data.DataSet GetDashBoardByGuideBooking(DateTime? dtmDateFrom, DateTime? dtmDateTo, string strWhere, int intType, string strUserGUID)
        {
            datTour dat = new datTour();
            return dat.GetDashBoardByGuideBooking(dtmDateFrom, dtmDateTo, strWhere, intType, strUserGUID);
        }

        

        public System.Data.DataSet GetTourDetail(string strTourGUID, int intTypeID, string strUserGUID)
        {
            datTour dat = new datTour();
            return dat.GetTourDetail(strTourGUID, intTypeID, strUserGUID);
        }

        public string DelTour(entCommond.entTour ent)
        {
            datTour dat = new datTour();
            return dat.DelTour(ent);
        }
        
    }
}
