using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2B_API.Providers.Entities
{
    public enum ApplicationTypes
    {
        JavaScript = 0,
        NativeConfidential = 1
    };
    public class AuthenticationType
    {
        public static string APPUser = "APP_USER"; //Xac thuc MB01
        public static string APPTHUser = "APP_TH_USER"; //Xac thuc TH51
        public static string APPPngUser = "APP_PNG_USER"; //Xac thuc CM07
        public static string APPUserKey = "APP_TMS_KEY"; //Xac thuc MB03
    };
}