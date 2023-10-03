using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Ent.CM
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
            public string strCompanyGUID { get; set; }

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
            public int intTotalRecords { get; set; }
            public string strWhere { get; set; }
            public string strOrder { get; set; }
            public string dtmDateFrom { get; set; }
            public string dtmDateTo { get; set; }
            public string strTourGUID { get; set; }
            public string strOrderBookingGUID { get; set; }
            public string strGuideBookingGUID { get; set; }
            public string strUserGUID { get; set; }
            public int intTotalPax { get; set; }
            public string dtmDateStart { get; set; }
            public Boolean IsPromotion { get; set; }
            public Boolean IsTransferTMS { get; set; }
            public int intType { get; set; }
            public int intTypeGet { get; set; }
            public string strCombocode { get; set; }

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
            public string strDataRow6 { get; set; }
            public string strDataRow7 { get; set; }
            public string strDataRow8 { get; set; }
            public string strDataRow9 { get; set; }
        }

        public class entGuideModel
        {
            public string strGuideGUID { get; set; }
            public string strGuideLicenceNo { get; set; }
        }

        public class entSystemPost
        {
            public string strComboCode { get; set; }
            public string strWhere { get; set; }
            public string strTableName { get; set; }
            public string strFeildSelect { get; set; }

        }
        public class entXML
        {
            public string strXML1 { get; set; }
            public string strXML2 { get; set; }
            public string strXML3 { get; set; }
            public string strXML4 { get; set; }
            public string strXML5 { get; set; }
            public string strXML6 { get; set; }
            public string strXML7 { get; set; }
            public string strXML8 { get; set; }
            public string strXML9 { get; set; }
            public string strTravellerSurveyGUID { get; set; }
            public string strGuideBookingGUID { get; set; }
            public string strXML10 { get; set; }
            public string strPNGClientGUID { get; set; }
            public string strGuideGUID { get; set; }
            public string strRemark { get; set; }
        }
    }
}
