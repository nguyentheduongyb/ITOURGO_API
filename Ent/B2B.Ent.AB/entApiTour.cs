using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Ent.AB
{
    public class entApiTour
    {
        public class entFilterData
        {
            public string strJson { get; set; }
            public string strCompanyGUID { get; set; }
            public string strUserGUID { get; set; }
            public string strCompanyPartnerGUID { get; set; }
            public string strCompanyOwnerGUID { get; set; }
            public string strPriceLevelGUID { get; set; }
            public string intLangID { get; set; }
            public string intCurPage { get; set; }
            public string intPageSize { get; set; }
            public string strOrder { get; set; }
            public string tblsReturn { get; set; }
            
            public string strTourGUID { get; set; }
            public string intCateID { get; set; }
            public string strNoOfDayRange { get; set; }
            public string strFilterServiceName { get; set; }
            public string dtmFilterDateStart { get; set; }
            public string dtmFilterDateValidFrom { get; set; }
            public string dtmFilterDateValidTo { get; set; }
            public string strListEasiaCateID { get; set; }
            public string strListTransportOptionID { get; set; }
            public string strPriceFromRange { get; set; }
            public string intCurrencyView { get; set; }
            public string strLocationCode { get; set; }
            
            public string strPaxBookingTourCode { get; set; }
            public string intEasiaCateID { get; set; }
            public string intTransportOptionID { get; set; }
            public string intNoOfAdult { get; set; }
            public string strListNoOfChild { get; set; }
            public string intNoOfSGLSup { get; set; }
            public string intNoOfTPLRec { get; set; }
            public string IsHasPriceKid { get; set; }
            public string dtmDateValidFrom { get; set; }
            public string dtmDateValidTo { get; set; }
            
            public string strTourPriceItemGUID { get; set; }
            public string xmlNoOfChild { get; set; }
            public string dtmFilterDateFrom { get; set; }
            public string dtmFilterDateTo { get; set; }
            public string intJoinTypeID { get; set; }
            
            public string strTourCancellationPolicyGUID { get; set; }
            public string IsActive { get; set; }
            public string strTourDayGUID { get; set; }
            public string strTourImageFileGUID { get; set; }
            public string strTourPaymentTermGUID { get; set; }
            public string strServiceNameUrl { get; set; }


        }

        public class entJson
        {
            public string strJson1 { get; set; }
            public string strJson2 { get; set; }
            public string strJson3 { get; set; }
            public string strJson4 { get; set; }
            public string strJson5 { get; set; }
            public string strJson6 { get; set; }
            public string strJson7 { get; set; }
            public string strJson8 { get; set; }
            public string strJson9 { get; set; }
            public string strJson10 { get; set; }
            public string strJson11 { get; set; }
            public string strJson12 { get; set; }
            public string strJson13 { get; set; }
            public string strJson14 { get; set; }
            public string strJson15 { get; set; }
            public string strJson16 { get; set; }
            public string strJson17 { get; set; }
            public string strJson18 { get; set; }
            public string strJson19 { get; set; }
            public string strJson20 { get; set; }
            public int intTotalPrm { get; set; }
            public string strCompanyGUID { get; set; }
            public string strHost { get; set; }
            public string strUserGUID { get; set; }
        }
    }
}
