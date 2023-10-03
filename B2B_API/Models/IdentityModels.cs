using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using TMS.Base;
using B2B_API.Providers.Entities;

namespace B2B_API.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class TMSUser : IdentityUser
    {
        public TMSUser()
        {
            strHostAccess = "";
        }
        public string strUserGUID { get; set; }
        public string strNameDisplay { get; set; }

        public string strAvata { get; set; }
        public string strGuideLicenceNo { get; set; }
        public bool IsLogin { get; set; }
        public int intStatus { get; set; }
        public string strAuthenMode { get; set; }
        public string strRemoteGUID { get; set; }
        public string strHostAccess { get; set; }
        public string strMess { get; set; }
        public string ClientId { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public static TMSUser GetUserLogin(int intMemberTypeID,string strUserName, string strPassword)
        {
            TMSUser ent = new TMSUser();
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            System.Data.SqlClient.SqlParameter p_intMemberTypeID = new System.Data.SqlClient.SqlParameter("@intMemberTypeID", intMemberTypeID);
            System.Data.SqlClient.SqlParameter p_strUserName = new System.Data.SqlClient.SqlParameter("@strUserName", strUserName);
            System.Data.SqlClient.SqlParameter p_strPassword = new System.Data.SqlClient.SqlParameter("@strPassword", strPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "SPMB_GetUserLogin", p_intMemberTypeID, p_strUserName, p_strPassword);
                System.Data.DataTable t = new System.Data.DataTable();
                t = ds.Tables[0];

                if (t.Rows.Count > 0)
                {
                    ent.Id = t.Rows[0]["strMemberGUID"].ToString();
                    ent.Email = t.Rows[0]["strEmail"].ToString();
                    ent.strUserGUID = t.Rows[0]["strMemberGUID"].ToString();
                    ent.strNameDisplay = t.Rows[0]["strFullName"].ToString();
                    ent.strAvata = t.Rows[0]["strAvatar"].ToString();
                    ent.IsLogin = true;

                    ent.ClientId = AuthenticationType.APPUser;
                    ent.intStatus = 1;
                }
                else
                {
                    ent.IsLogin = false;
                    ent.strMess = ds.Tables[1].Rows[0]["intRtn"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                ent.IsLogin = false;
                ent.strMess = ex.Message;
            }

            return ent;
        }

        public static TMSUser GetTHUserLogin(string strUserName, string strPassword)
        {
            TMSUser ent = new TMSUser();
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            System.Data.SqlClient.SqlParameter p_strUserName = new System.Data.SqlClient.SqlParameter("@strUserName", strUserName);
            System.Data.SqlClient.SqlParameter p_strPassword = new System.Data.SqlClient.SqlParameter("@strPassword", strPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "SPTH_GetUserLogin", p_strUserName, p_strPassword);
                System.Data.DataTable t = new System.Data.DataTable();
                t = ds.Tables[0];

                if (t.Rows.Count > 0)
                {
                    ent.Id = t.Rows[0]["strMemberGUID"].ToString();
                    ent.Email = t.Rows[0]["strEmail"].ToString();
                    ent.strUserGUID = t.Rows[0]["strMemberGUID"].ToString();
                    ent.strNameDisplay = t.Rows[0]["strFullName"].ToString();
                    ent.strAvata = t.Rows[0]["strAvatar"].ToString();
                    ent.IsLogin = true;

                    ent.ClientId = AuthenticationType.APPTHUser;
                    ent.intStatus = 1;
                }
                else
                {
                    ent.IsLogin = false;
                    ent.strMess = "Invalid login information!";
                }
            }
            catch (System.Exception ex)
            {
                ent.IsLogin = false;
                ent.strMess = ex.Message;
            }

            return ent;
        }

        public static TMSUser GetPngUserLogin(string strUserName, string strPassword)
        {
            TMSUser ent = new TMSUser();
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            System.Data.SqlClient.SqlParameter p_strUserName = new System.Data.SqlClient.SqlParameter("@strUserName", strUserName);
            System.Data.SqlClient.SqlParameter p_strPassword = new System.Data.SqlClient.SqlParameter("@strPassword", strPassword);
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "SPCM_GetUserLogin", p_strUserName, p_strPassword);
                System.Data.DataTable t = new System.Data.DataTable();
                t = ds.Tables[0];

                if (t.Rows.Count > 0)
                {
                    ent.Id = t.Rows[0]["strMemberGUID"].ToString();
                    ent.Email = t.Rows[0]["strEmail"].ToString();
                    ent.strUserGUID = t.Rows[0]["strMemberGUID"].ToString();
                    ent.strNameDisplay = t.Rows[0]["strFullName"].ToString();
                    ent.strAvata = t.Rows[0]["strAvatar"].ToString();
                    ent.IsLogin = true;

                    ent.ClientId = AuthenticationType.APPPngUser;
                    ent.intStatus = 1;
                }
                else
                {
                    ent.IsLogin = false;
                    ent.strMess = "Invalid login information!";
                }
            }
            catch (System.Exception ex)
            {
                ent.IsLogin = false;
                ent.strMess = ex.Message;
            }

            return ent;
        }

        public static TMSUser GetClientAuthenData(string strKeyAccessToken, string strRemoteURL)
        {
            TMSUser ent = new TMSUser();
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            System.Data.SqlClient.SqlParameter p_strKeyAccessToken = new System.Data.SqlClient.SqlParameter("@strKeyAccessToken", strKeyAccessToken);
            System.Data.DataSet ds = new System.Data.DataSet();
            //ds = SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "SPSS_GetClientAuthenData", p_strKeyAccessToken);
            ds = SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "SPMB_GetMemberAppkeyAuthen", p_strKeyAccessToken);
            System.Data.DataTable t = new System.Data.DataTable();
            t = ds.Tables[0];

            if (t.Rows.Count > 0)
            {
                //ent.Id = t.Rows[0]["SS91_PNGClientGUID"].ToString();
                //ent.Email = t.Rows[0]["SS91_KeyAccessToken"].ToString();
                //ent.strUserGUID = t.Rows[0]["SS91_PNGClientGUID"].ToString();
                //ent.strNameDisplay = t.Rows[0]["SS91_PNGClientName"].ToString();
                //ent.strHostAccess = t.Rows[0]["SS91_HostAccess"].ToString();
                //ent.strRemoteGUID = t.Rows[0]["SS91_PNGClientGUID"].ToString();
                ent.Id = t.Rows[0]["MB03_CompanyGUID"].ToString();
                ent.Email = t.Rows[0]["MB91_KeyAccessToken"].ToString();
                ent.strUserGUID = t.Rows[0]["MB03_CompanyGUID"].ToString();
                ent.strNameDisplay = t.Rows[0]["MB03_CompanyName"].ToString();
                ent.strHostAccess = t.Rows[0]["MB93_HostAccess"].ToString();
                ent.strRemoteGUID = t.Rows[0]["MB91_MemberAppKeyGUID"].ToString();

                ent.ClientId = AuthenticationType.APPUserKey;


                int intIndex = 0; 

                if(strRemoteURL.IndexOf("localhost:1600") == -1 && strRemoteURL.IndexOf("localhost:1300") == -1)
                {
                    intIndex = ent.strHostAccess.IndexOf(strRemoteURL);
                }

                if (intIndex > -1)
                {
                    ent.IsLogin = true;
                }
                else
                {
                    ent.IsLogin = false;
                    ent.strMess = "Host remote unlicensed access to the server.";


                }
            }
            else
            {
                ent.IsLogin = false;
                ent.strMess = "Application key not permission access server.";
            }
            return ent;
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}