using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.AB;

namespace B2B.Bus.AB
{
    public class busApiCommon
    {

        //------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionAHBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionAHBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionPayBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionPayBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionRcvBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionRcvBooking(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionTour(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionTour(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionTour_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionTour_Json(data, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionTourBase_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionTourBase_Json(data, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionDeal_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionDeal_Json(data, sf.GetMethod().Name);
        }
        //-------------------END(10/07/2019)
        //------------------MrHieu(16/07/2019)
        public System.Data.DataSet ActionRequest(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionRequest(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionCountry(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionCountry(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionCommon(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionCommon(strJson, sf.GetMethod().Name);
        }
        //------------------END(16/07/2019)

        //-------------------MrHieu(20/06/2019)
        public System.Data.DataSet ActionSupplier(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionSupplier(strJson, sf.GetMethod().Name);
        }
        //-------------------MrHieu(20/06/2019)
        public System.Data.DataSet ActionStoreSupplier(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionStoreSupplier(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionStoreSupplier_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionStoreSupplier_Json(data, sf.GetMethod().Name);
        }
        //------------------MrHieu(24/07/2019)
        public System.Data.DataSet ActionChannelPrice(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionChannelPrice(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionPriceSupp(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionPriceSupp(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionPriceSupp_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionPriceSupp_Json(data, sf.GetMethod().Name);
        }
        //------------------END(24/07/2019)

        public System.Data.DataSet ActionNews(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionNews(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionClient(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionClient(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionNotify(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionNotify(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionSystem(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionSystem(strJson, sf.GetMethod().Name);
        }

        //------------------MrTien(10/08/2019)

        public System.Data.DataSet ActionVoucher(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionVoucher(strJson, sf.GetMethod().Name);
        }

        //------------------END(10/08/2019)

        public System.Data.DataSet ActionAllotment(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionAllotment(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionLog(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionLog(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionGuide(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionGuide(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionGuide_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionGuide_Json(data, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionMember(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionMember(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionMember_Json(B2B.Ent.AB.entApiCommon.entJson data)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiCommon dat = new datApiCommon();
            return dat.ActionMember_Json(data, sf.GetMethod().Name);
        }

    }
}
