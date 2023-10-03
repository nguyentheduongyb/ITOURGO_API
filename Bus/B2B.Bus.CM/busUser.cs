using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Dat.CM;
using B2B.Ent.CM;
namespace B2B.Bus.CM
{
    public class busUser
    {
        public System.Data.DataSet GetMemberDetail(string strMemberGUID)
        {
            datUser dat = new datUser();
            return dat.GetMemberDetail(strMemberGUID);
        }

        public string UpdCompanyInfo(entCompany ent)
        {
            datUser dat = new datUser();
            return dat.UpdCompanyInfo(ent);
        }

        public string UpdCompanyLogo(entCompany ent)
        {
            datUser dat = new datUser();
            return dat.UpdCompanyLogo(ent);
        }

        public string UpdMemberInfo(entUser ent)
        {
            datUser dat = new datUser();
            return dat.UpdMemberInfo(ent);
        }

        public string UpdMemberAvartar(entUser ent)
        {
            datUser dat = new datUser();
            return dat.UpdMemberAvartar(ent);
        }

        public string UpdMemberPassword(entUser ent)
        {
            datUser dat = new datUser();
            return dat.UpdMemberPassword(ent);
        }

        public string CheckMemberPassword(entUser ent)
        {
            datUser dat = new datUser();
            return dat.CheckMemberPassword(ent);
        }

        public string SetPasswordDirectMember(entUser ent)
        {
            datUser dat = new datUser();
            return dat.SetPasswordDirectMember(ent);
        }
    }
}
