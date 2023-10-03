using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.SL;
using B2B.Ent.SL;

namespace B2B.Bus.SL
{
    public class busCommond
    {
        
        //-------------------MrHieu(10/07/2019)
        public System.Data.DataSet ActionAHBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionAHBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionPayBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionPayBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionRcvBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionRcvBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionTour(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionTour(strJson, sf.GetMethod().Name);
        }
        //-------------------END(10/07/2019)
        //------------------MrHieu(16/07/2019)
        public System.Data.DataSet ActionRequest(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionRequest(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionCountry(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionCountry(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionCommon(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionCommon(strJson, sf.GetMethod().Name);
        }
        //------------------END(16/07/2019)

        //-------------------MrHieu(20/06/2019)
        public System.Data.DataSet ActionSupplier(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionSupplier(strJson, sf.GetMethod().Name);
        }
        //-------------------MrHieu(20/06/2019)
        public System.Data.DataSet ActionStoreSupplier(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionStoreSupplier(strJson, sf.GetMethod().Name);
        }
        //------------------MrHieu(24/07/2019)
        public System.Data.DataSet ActionChannelPrice(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionChannelPrice(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionPriceSupp(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionPriceSupp(strJson, sf.GetMethod().Name);
        }
        //------------------END(24/07/2019)

        public System.Data.DataSet ActionNews(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionNews(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionClient(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionClient(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionNotify(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionNotify(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionSystem(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionSystem(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet GetListEmailConfig(string strJson)
        {
            datCommond dat = new datCommond();
            return dat.GetListEmailConfig(strJson);
        }
        //------------------MrTien(10/08/2019)

        public System.Data.DataSet ActionVoucher(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionVoucher(strJson, sf.GetMethod().Name);
        }

        //------------------END(10/08/2019)

        public System.Data.DataSet ActionAllotment(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionAllotment(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionLog(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionLog(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionSaleReq(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionSaleReq(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionTourBase(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionTourBase(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionMenuMap(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionMenuMap(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionCart(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionCart(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionAgtBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionAgtBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionAgtHostBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionAgtHostBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionReportBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionReportBooking(strJson, sf.GetMethod().Name);
        }


        public System.Data.DataSet ActionTourBaseEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionTourBase(strJson, strSP);
        }

        public System.Data.DataSet ActionCommonEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionCommon(strJson, strSP);
        }
        public System.Data.DataSet ActionStoreSupplierEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionStoreSupplier(strJson, strSP);
        }
        public System.Data.DataSet ActionPriceSuppEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionPriceSupp(strJson, strSP);
        }

        public System.Data.DataSet ActionGuideEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionGuide(strJson, strSP);
        }
        
        public System.Data.DataSet ActionBookingEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionBooking(strJson, strSP);
        }

        public System.Data.DataSet ActionChannel(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionChannel(strJson, sf.GetMethod().Name);
        }
    }
}
