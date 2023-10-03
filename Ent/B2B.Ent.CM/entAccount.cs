using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace B2B.Ent.CM
{
    public class entCompany
    {
        public string strCompanyGUID { get; set; }
        public string strCompanyName { get; set; }
        public string strCompanyPhone { get; set; }
        public string strCompanyEmail { get; set; }
        public string strCompanyFax { get; set; }
        public string strCompanyAddr { get; set; }
        public string strCompanyWeb { get; set; }
        public string strCompanyLogo { get; set; }
        public string strMemberGUID { get; set; }
    }
    public class entUser
    {
        public string strMemberGUID { get; set; }
        public string strFirstName { get; set; }
        public string strLastName { get; set; }
        public string strFullName { get; set; }
        public string strPhone { get; set; }
        public string strEmail { get; set; }
        public string strContactAddr { get; set; }
        public string strAvatar { get; set; }
        public string strPassword { get; set; }
        public string strOldPassword { get; set; }
        public string strNewPassword { get; set; }
    }
}
