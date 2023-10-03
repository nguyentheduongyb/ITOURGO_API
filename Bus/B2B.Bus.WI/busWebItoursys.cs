using B2B.Dat.WI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Bus.WI
{
    public class busWebItoursys
    {

        //------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionNews(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebItoursys dat = new datWebItoursys();
            return dat.ActionNews(strJson, sf.GetMethod().Name);
        }
        //------------------END(26/07/2019)
        public System.Data.DataSet ActionMenu(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebItoursys dat = new datWebItoursys();
            return dat.ActionMenu(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionGallery(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebItoursys dat = new datWebItoursys();
            return dat.ActionGallery(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionSupport(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebItoursys dat = new datWebItoursys();
            return dat.ActionSupport(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionAdvertise(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datWebItoursys dat = new datWebItoursys();
            return dat.ActionAdvertise(strJson, sf.GetMethod().Name);
        }
        
        public System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        {
            datWebItoursys dat = new datWebItoursys();
            return dat.GetSQLDataByTableConfig(strTableName, strFeildSelect, strWhere);
        }

        public System.Data.DataSet GetDllByCode(string strDDLCode)
        {
            datWebItoursys dat = new datWebItoursys();
            return dat.GetDDLByCode(strDDLCode);
        }
        public System.Data.DataSet GetDllByCode(string strDDLCode, string strWhere)
        {
            datWebItoursys dat = new datWebItoursys();
            return dat.GetDDLByCode(strDDLCode, strWhere);
        }
    }
}
