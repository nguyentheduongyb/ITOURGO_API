using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using B2B_API.Providers.Entities;

namespace B2B_API.Providers.Entities
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        //public async Task<IdentityResult> RegisterUser(UserModel userModel)
        //{
        //    IdentityUser user = new IdentityUser
        //    {
        //        UserName = userModel.UserName
        //    };

        //    var result = await _userManager.CreateAsync(user, userModel.Password);

        //    return result;
        //}

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }
        //public Client FindClientCode(string strClientCode)
        //{
        //    var client = _ctx.Clients.Where(b => b.Id == strClientCode).FirstOrDefault();

        //    return client;
        //}

        public Client FindClient(string clientId)
        {
            //var client = _ctx.Clients.Find(clientId);

            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            Client client = new Client();

            System.Data.SqlClient.SqlParameter p_1 = new System.Data.SqlClient.SqlParameter("@strID", clientId);
            System.Data.DataSet ds = new System.Data.DataSet();

            ds = TMS.Base.SqlHelper.ExecuteDataset(strConn, System.Data.CommandType.StoredProcedure, "PNG_GetFilterClient", p_1);
            System.Data.DataTable t = new System.Data.DataTable();
            t = ds.Tables[0];

            if (t.Rows.Count > 0)
            {

                client.Id = t.Rows[0]["Id"].ToString();
                client.Secret = t.Rows[0]["Secret"].ToString();
                client.Name = t.Rows[0]["Name"].ToString();
                client.ApplicationType = 0;
                client.Active = Convert.ToBoolean(t.Rows[0]["Active"]);
                client.RefreshTokenLifeTime = Convert.ToInt32(t.Rows[0]["RefreshTokenLifeTime"]);
                client.AllowedOrigin = t.Rows[0]["AllowedOrigin"].ToString();
            }

            return client;
        }

        public async Task<bool> AddRefreshToken(RefreshToken token)
        {


            var existingToken = _ctx.RefreshTokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).SingleOrDefault();

            if (existingToken != null)
            {
                var result = await RemoveRefreshToken(existingToken);
            }

            _ctx.RefreshTokens.Add(token);

            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            if (refreshToken != null)
            {
                _ctx.RefreshTokens.Remove(refreshToken);
                return await _ctx.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            _ctx.RefreshTokens.Remove(refreshToken);
            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _ctx.RefreshTokens.FindAsync(refreshTokenId);

            return refreshToken;
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return _ctx.RefreshTokens.ToList();
        }

        public async Task<IdentityUser> FindAsync(UserLoginInfo loginInfo)
        {
            IdentityUser user = await _userManager.FindAsync(loginInfo);

            return user;
        }

        public async Task<IdentityResult> CreateAsync(IdentityUser user)
        {
            var result = await _userManager.CreateAsync(user);

            return result;
        }

        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login)
        {
            var result = await _userManager.AddLoginAsync(userId, login);

            return result;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}