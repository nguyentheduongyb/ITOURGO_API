using B2B.Dat.WP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Bus.WP
{
    public class busWebPNGSoft
    {

        //------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionNews(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.ActionNews(strJson, sf.GetMethod().Name);
        }
        //------------------END(26/07/2019)
        public System.Data.DataSet ActionMenu(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.ActionMenu(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionGallery(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.ActionGallery(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionSupport(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.ActionSupport(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionAdvertise(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.ActionAdvertise(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        {
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.GetSQLDataByTableConfig(strTableName, strFeildSelect, strWhere);
        }

        public System.Data.DataSet GetDllByCode(string strDDLCode)
        {
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.GetDDLByCode(strDDLCode);
        }
        public System.Data.DataSet GetDllByCode(string strDDLCode, string strWhere)
        {
            datWebPNGSoft dat = new datWebPNGSoft();
            return dat.GetDDLByCode(strDDLCode, strWhere);
        }
    }
}
