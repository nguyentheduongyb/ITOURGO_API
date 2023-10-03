using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.CM;
using B2B.Ent.CM;

namespace B2B.Bus.CM
{
    public class busCommond
    {

        //------------------MrHieu(26/07/2019)
        public System.Data.DataSet ActionMember(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionMember(strJson, sf.GetMethod().Name);
        }
        //------------------END(26/07/2019)
        public System.Data.DataSet ActionMenu(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionMenu(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionHelper(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionHelper(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionGuide(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionGuide(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataSet ActionInfoSupplier(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionInfoSupplier(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionTraveller(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionTraveller(strJson, sf.GetMethod().Name);
        }

        public System.Data.DataSet ActionTemplate(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionTemplate(strJson, sf.GetMethod().Name);
        }

        //-------------------MrHieu(06/06/2019)
        public System.Data.DataSet GetListItemInPanel(string strXml)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.GetListItemInPanel(strXml, sf.GetMethod().Name);
        }
        //-------------------MrHieu(06/06/2019)

        //-------------------MrHieu(25/06/2019)
        public System.Data.DataSet GetListItemInUser(string strXml)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.GetListItemInUser(strXml, sf.GetMethod().Name);
        }
        //-------------------END(25/06/2019)

        public System.Data.DataSet ActionMenuMapEx(string strJson, string strSP)
        {
            datCommond dat = new datCommond();
            return dat.ActionMenuMap(strJson, strSP);
        }
        public System.Data.DataSet ActionSrcIndex(string strJson)
        {
            var st = new System.Diagnostics.StackTrace();
            var sf = st.GetFrame(1);
            datCommond dat = new datCommond();
            return dat.ActionSrcIndex(strJson, sf.GetMethod().Name);
        }
        public System.Data.DataTable GetSQLDataByTableConfig(string strTableName, string strFeildSelect, string strWhere)
        {
            datCommond dat = new datCommond();
            return dat.GetSQLDataByTableConfig(strTableName, strFeildSelect, strWhere);
        }

        public System.Data.DataSet GetDllByCode(string strDDLCode)
        {
            datCommond dat = new datCommond();
            return dat.GetDDLByCode(strDDLCode);
        }
        public System.Data.DataSet GetDllByCode(string strDDLCode, string strWhere)
        {
            datCommond dat = new datCommond();
            return dat.GetDDLByCode(strDDLCode, strWhere);
        }
    }
}
