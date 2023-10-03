using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.AB;

namespace B2B.Bus.AB
{
    public class busApiTour
    {

        //------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionAHBooking(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.ActionBooking(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet GetListTourPublishInTopByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListTourPublishInTopByPUB(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListCompanyDestinationForHmPgTour(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListCompanyDestinationForHmPgTour(ent, sf.GetMethod().Name);
        }
        

        public System.Data.DataSet GetListTourPublishByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListTourPublishByPUB(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetDetailTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetDetailTourByPUB(ent, sf.GetMethod().Name);
        }
        
        public System.Data.DataSet GetListTourDayByPtn(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListTourDayByPtn(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListImageFile(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListImageFile(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListTourPaymentTerm(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListTourPaymentTerm(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListTourCancellationPolicy(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListTourCancellationPolicy(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListPriceItemTourByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListPriceItemTourByPUB(ent, sf.GetMethod().Name);
        }
        public System.Data.DataSet GetListPaxBookingTourForBkByPUB(B2B.Ent.AB.entApiTour.entFilterData ent)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datApiTour dat = new datApiTour();
            return dat.GetListPaxBookingTourForBkByPUB(ent, sf.GetMethod().Name);
        }

        
    }
}
