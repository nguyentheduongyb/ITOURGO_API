using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Ent.SL
{
    public class entCommond
    {
        public class entDataPost
        {
            public string strDataRow1 { get; set; }
            public string strDataRow2 { get; set; }
            public string strDataRow3 { get; set; }
            public string strDataRow4 { get; set; }
            public string strDataRow5 { get; set; }
            public string strDataRow6 { get; set; }
            public string strDataRow7 { get; set; }
            public string strDataRow8 { get; set; }
            public string strDataRow9 { get; set; }
            public string strUserGUID { get; set; }

        }
        public class entFilterData
        {
            public entFilterData()
            {
                strWhere = "";
                IsPromotion = false;
            }
            public int intCurrPage { get; set; }
            public int intPageSize { get; set; }
            public string strWhere { get; set; }
            public DateTime? dtmDateFromEx { get; set; }
            public DateTime? dtmDateToEx { get; set; }
            public string dtmDateFrom { get; set; }
            public string dtmDateTo { get; set; }
            public string strTourGUID { get; set; }
            public string strTourDayGUID { get; set; }
            public string strUserGUID { get; set; }
            public Boolean IsPromotion { get; set; }
            public int intType { get; set; }
            public int intTypeID { get; set; }
            public int intDayOrder { get; set; }
            // -------------MrHieu(10/07/2019)(1)
            public string strJson { get; set; }
            // -------------END(10/07/2019)(1)
        }
        public class entFilterDataChkRemain
        {
            public string strJson { get; set; }
            public string strListSerCode { get; set; }
            public string strQueueCode { get; set; }
            public int intQuantity { get; set; }
        }
        public class entDataReturn
        {

            public int intTotalRecode { get; set; }
            public int intTotalUnRead { get; set; }
            public string strDataRow1 { get; set; }
            public string strDataRow2 { get; set; }
            public string strDataRow3 { get; set; }
            public string strDataRow4 { get; set; }
            public string strDataRow5 { get; set; }
        }
        public class entTour
        {
            public string strTourGUID { get; set; }
            
            public string strUserGUID { get; set; }
            public string strXML { get; set; }
            //public string strListDayID { get; set; }
        }


        public class entGuideModal
        {
            public string strGuideGUID { get; set; }
            public string strGuidePaymentServiceGUID { get; set; }
            public double dblActualPriceUnit { get; set; }
            public int? intActualQuantity { get; set; }
            public int intLangID { get; set; }
            public double dblActualPriceTotal { get; set; }
            public string strRemark { get; set; }
            public string strServiceName { get; set; }
            public string strGuideBookingGUID { get; set; }
            public string strGuideProgramGUID { get; set; }
            public string strActualRemarkForGuide { get; set; }
            public string strUserGUID { get; set; }
            public Boolean IsPaid { get; set; }
        }

        
    }
}
