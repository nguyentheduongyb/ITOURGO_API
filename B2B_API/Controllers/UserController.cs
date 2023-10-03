using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

using B2B.Bus.CM;
using B2B_API.App_Start;
using B2B_API.Filter;
using B2B.Ent.CM;
using System.Text;
using System.Security.Cryptography;

namespace TMS_API.Controllers
{
    [Authorize]
    // [CMSMemberUserFilter] //Bảo bật ứng dụng.
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {

        [HttpPost]
        [Route("UpdLinkGroupType")]
        public HttpResponseMessage UpdLinkGroupType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListGroupTypeCompany")]
        public HttpResponseMessage GetListGroupTypeCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddGroupTypeCompany")]
        public HttpResponseMessage AddGroupTypeCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdGroupTypeCompany")]
        public HttpResponseMessage UpdGroupTypeCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelGroupTypeCompany")]
        public HttpResponseMessage DelGroupTypeCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [Route("GetMemberDetail")]
        [HttpGet]
        public HttpResponseMessage GetMemberDetail(HttpRequestMessage Request)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            busUser bus = new busUser();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.GetMemberDetail(User.Identity.Name)));
        }


        [HttpPost]
        [Route("AddLoginHistory")]
        public HttpResponseMessage AddLoginHistory(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddClientPriceLevel")]
        public HttpResponseMessage AddClientPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckAgentRegisterByEmailByAgentHost")]
        public HttpResponseMessage GetCheckAgentRegisterByEmailByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetCheckAgentRegisterByTaxCodeByAgentHost")]
        public HttpResponseMessage GetCheckAgentRegisterByTaxCodeByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPriceLevelForSeasonPrice")]
        public HttpResponseMessage GetListPriceLevelForSeasonPrice(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAgentHostFee")]
        public HttpResponseMessage GetListAgentHostFee(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddAgentHostFee")]
        public HttpResponseMessage AddAgentHostFee(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdAgentHostFee")]
        public HttpResponseMessage UpdAgentHostFee(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAgentHostFee")]
        public HttpResponseMessage DelAgentHostFee(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCompanyInfo")]
        public HttpResponseMessage UpdCompanyInfo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdCompanyForIsContractSigned")]
        public HttpResponseMessage UpdCompanyForIsContractSigned(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompanyLogo")]
        public HttpResponseMessage UpdCompanyLogo(entCompany ent)
        {
            busUser bus = new busUser();
            string strResult = "0";
            strResult = bus.UpdCompanyLogo(ent);
            return Request.CreateResponse(HttpStatusCode.OK, strResult);
        }

        [HttpPost]
        [Route("UpdMemberInfo")]
        public HttpResponseMessage UpdMemberInfo(entUser ent)
        {
            busUser bus = new busUser();
            string strResult = "0";
            strResult = bus.UpdMemberInfo(ent);
            return Request.CreateResponse(HttpStatusCode.OK, strResult);
        }

        [HttpPost]
        [Route("UpdMemberAvartar")]
        public HttpResponseMessage UpdMemberAvartar(entUser ent)
        {
            busUser bus = new busUser();
            string strResult = "0";
            strResult = bus.UpdMemberAvartar(ent);
            return Request.CreateResponse(HttpStatusCode.OK, strResult);
        }

        [HttpPost]
        [Route("UpdMemberPassword")]
        public HttpResponseMessage UpdMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strMemberGUID = Convert.ToString(routes_list["strMemberGUID"]);
            string strNewPassword = CMSService.Encrypt(Convert.ToString(routes_list["strNewPassword"]));
            string strOldPassword = CMSService.Encrypt(Convert.ToString(routes_list["strOldPassword"]));

            var strJson = "{strMemberGUID:'" + strMemberGUID + "', strNewPassword:'" + strNewPassword + "', strOldPassword:'" + strOldPassword + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(strJson)));
        }

        [HttpPost]
        [Route("CheckMemberPassword")]
        public HttpResponseMessage CheckMemberPassword(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            string strMemberGUID = Convert.ToString(routes_list["strMemberGUID"]);
            string strPassword = Convert.ToString(routes_list["strPassword"]);
            strPassword = CMSService.Encrypt(strPassword);

            var strJson = "{strMemberGUID:'" + strMemberGUID + "', strPassword:'" + strPassword + "'}";

            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(strJson)));
        }

        [HttpPost]
        [Route("EncryptPassword")]
        public HttpResponseMessage EncryptPassword(entUser ent)
        {
            var passwordEnt = CMSService.Encrypt(ent.strPassword);
            return Request.CreateResponse(HttpStatusCode.OK, passwordEnt);
        }

        
        [HttpPost]
        [Route("GetListCompanyBankAccount")]
        public HttpResponseMessage GetListCompanyBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        //-------------MrHieu(25/09/2019)(1)
        [HttpPost]
        [Route("GetListCompanyPartner")]
        public HttpResponseMessage GetListCompanyPartner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListCompanyOwner")]
        public HttpResponseMessage GetListCompanyOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAgentHostNoAddByAgent")]
        public HttpResponseMessage GetListAgentHostNoAddByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMemberRegisterByAgentHost")]
        public HttpResponseMessage AddMemberRegisterByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterMemberRegisterByAgentHost")]
        public HttpResponseMessage GetFilterMemberRegisterByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        
        [HttpPost]
        [Route("UpdMemberRegisterForPriceLevelByAgentHost")]
        public HttpResponseMessage UpdMemberRegisterForPriceLevelByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListMember")]
        public HttpResponseMessage GetListMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        //------------MrHIeu(20/12/2019)
        [HttpPost]
        [Route("AddMember")]
        public HttpResponseMessage AddMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdMember")]
        public HttpResponseMessage UpdMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelMember")]
        public HttpResponseMessage DelMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        //------------MrHIeu-END(20/12/2019)


        [HttpPost]
        [Route("AddCompanyPartner")]
        public HttpResponseMessage AddCompanyPartner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        
        [HttpPost]
        [Route("UpdCompanyPartner")]
        public HttpResponseMessage UpdCompanyPartner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        [HttpPost]
        [Route("AddPartnerPriceLevel")]
        public HttpResponseMessage AddPartnerPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        //-------------END(25/09/2019)(1)

        [HttpPost]
        [Route("AddCompanyTopup")]
        public HttpResponseMessage AddCompanyTopup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCompanyCurrencyByAd")]
        public HttpResponseMessage GetListCompanyCurrencyByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        [HttpPost]
        [Route("GetListCompanyCurrencyByPtn")]
        public HttpResponseMessage GetListCompanyCurrencyByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCompanyCurrency")]
        public HttpResponseMessage AddCompanyCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompanyCurrency")]
        public HttpResponseMessage UpdCompanyCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCompanyCurrency")]
        public HttpResponseMessage DelCompanyCurrency(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListExchangeRateByAd")]
        public HttpResponseMessage GetListExchangeRateByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddExchangeRate")]
        public HttpResponseMessage AddExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdExchangeRate")]
        public HttpResponseMessage UpdExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelExchangeRate")]
        public HttpResponseMessage DelExchangeRate(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCompanyDestinationByAd")]
        public HttpResponseMessage GetListCompanyDestinationByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCompanyDestinationByPtn")]
        public HttpResponseMessage GetListCompanyDestinationByPtn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCompanyDestination")]
        public HttpResponseMessage AddCompanyDestination(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompanyDestination")]
        public HttpResponseMessage UpdCompanyDestination(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCompanyDestination")]
        public HttpResponseMessage DelCompanyDestination(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListClientMarketByAd")]
        public HttpResponseMessage GetListClientMarketByAd(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddClientMarket")]
        public HttpResponseMessage AddClientMarket(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdClientMarket")]
        public HttpResponseMessage UpdClientMarket(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelClientMarket")]
        public HttpResponseMessage DelClientMarket(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListMemberByB2BAdmin")]
        public HttpResponseMessage GetListMemberByB2BAdmin(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCompanyLanguageByOwn")]
        public HttpResponseMessage GetListCompanyLanguageByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddCompanyLanguageByOwn")]
        public HttpResponseMessage AddCompanyLanguageByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompanyLanguageByOwn")]
        public HttpResponseMessage UpdCompanyLanguageByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelCompanyLanguageByOwn")]
        public HttpResponseMessage DelCompanyLanguageByOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // Tien (14/07/2020)
        [HttpPost]
        [Route("AddAllianceMember")]
        public HttpResponseMessage AddAllianceMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddAllianceOwn")]
        public HttpResponseMessage AddAllianceOwn(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterAllianceOwner")]
        public HttpResponseMessage GetFilterAllianceOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("AddTourToAllianceOwner")]
        public HttpResponseMessage AddTourToAllianceOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterServiceInAllianceOwner")]
        public HttpResponseMessage GetFilterServiceInAllianceOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        // END (14/07/2020)

        // Tien (15/07/2020)
        [HttpPost]
        [Route("GetListCompanyToAllience")]
        public HttpResponseMessage GetListCompanyToAllience(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListAllianceMember")]
        public HttpResponseMessage GetListAllianceMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAlliance")]
        public HttpResponseMessage DelAlliance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAllianceMember")]
        public HttpResponseMessage DelAllianceMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelAllianceServices")]
        public HttpResponseMessage DelAllianceServices(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // END (15/07/2020)

        // Tien (16/07/2020)
        [HttpPost]
        [Route("GetFilterTourFromAllianceOwner")]
        public HttpResponseMessage GetFilterTourFromAllianceOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOtherCompanyOwner")]
        public HttpResponseMessage GetListOtherCompanyOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddOtherOwnerPriceLevel")]
        public HttpResponseMessage AddOtherOwnerPriceLevel(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdOtherOwnerCompany")]
        public HttpResponseMessage UpdOtherOwnerCompany(entCompany ent)
        {
            busUser bus = new busUser();
            string strResult = "0";
            strResult = bus.UpdCompanyLogo(ent);
            return Request.CreateResponse(HttpStatusCode.OK, strResult);
        }

        // END (16/07/2020)


        // Tien (17/07/2020)

        [HttpPost]
        [Route("GetFilterMemberRegister")]
        public HttpResponseMessage GetFilterMemberRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        // End (17/07/2020)

        // Tien (18/07/2020)

        [HttpPost]
        [Route("GetListUserInCompanyOwner")]
        public HttpResponseMessage GetListUserInCompanyOwner(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        // End (18/07/2020)


        // Tien (20/07/2020)

        [HttpPost]
        [Route("AddUserInCompany")]
        public HttpResponseMessage AddUserInCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterCompanyBankAccount")]
        public HttpResponseMessage GetFilterCompanyBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCompanyBankAccount")]
        public HttpResponseMessage AddCompanyBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdCompanyBankAccount")]
        public HttpResponseMessage UpdCompanyBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("DelCompanyBankAccount")]
        public HttpResponseMessage DelCompanyBankAccount(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (20/07/2020)

        // Tien (22/07/2020)

        [HttpPost]
        [Route("GetMemberDetailProfile")]
        public HttpResponseMessage GetMemberDetailProfile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdMemberInfoProfile")]
        public HttpResponseMessage UpdMemberInfoProfile(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        // End (22/07/2020)

        // Tien (23/07/2020)


        [HttpPost]
        [Route("GetListCompanyAgentByCompanyTypeID")]
        public HttpResponseMessage GetListCompanyAgentByCompanyTypeID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        // End (23/07/2020)


        // Tien (27/07/2020)
        [HttpPost]
        [Route("GetListDestinationAddToCompany")]
        public HttpResponseMessage GetListDestinationAddToCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (27/07/2020)


        // Tien (29/07/2020)

        [HttpPost]
        [Route("AddPaxGroupType")]
        public HttpResponseMessage AddPaxGroupType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListPaxConfigByGroupTypeGUID")]
        public HttpResponseMessage GetListPaxConfigByGroupTypeGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddCompanyPaxGroup")]
        public HttpResponseMessage AddCompanyPaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddPaxConfig")]
        public HttpResponseMessage AddPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("UpdPaxConfig")]
        public HttpResponseMessage UpdPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("DelPaxConfig")]
        public HttpResponseMessage DelPaxConfig(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListCompanyPaxGroup")]
        public HttpResponseMessage GetListCompanyPaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("DelCompanyPaxGroup")]
        public HttpResponseMessage DelCompanyPaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCateByCompanyGUID")]
        public HttpResponseMessage GetListCateByCompanyGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListAllCompanyPaxGroup")]
        public HttpResponseMessage GetListAllCompanyPaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListPaxGroup")]
        public HttpResponseMessage GetListPaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        // End (27/07/2020)

        // Mr Tien (31/07/2020)
        [HttpPost]
        [Route("GetListAllienceFromMember")]
        public HttpResponseMessage GetListAllienceFromMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListTourOnTop")]
        public HttpResponseMessage GetListTourOnTop(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetListCateByAllienceCompanyGUID")]
        public HttpResponseMessage GetListCateByAllienceCompanyGUID(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListCompanyAlliencePaxGroup")]
        public HttpResponseMessage GetListCompanyAlliencePaxGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (31/07/2020)


        // Mr Tien (11/08/2020)

        [HttpPost]
        [Route("GetFilterPartnerOfCompany")]
        public HttpResponseMessage GetFilterPartnerOfCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("GetFilterMemberOfCompany")]
        public HttpResponseMessage GetFilterMemberOfCompany(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetListOnWebContact")]
        public HttpResponseMessage GetListOnWebContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddOnWebContactTo")]
        public HttpResponseMessage AddOnWebContactTo(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("DelOnWebContact")]
        public HttpResponseMessage DelOnWebContact(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMemberDirectRegister")]
        public HttpResponseMessage AddMemberDirectRegister(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("GetFilterMemberInAgentHost")]
        public HttpResponseMessage GetFilterMemberInAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (10/08/2020) 
        [HttpPost]
        [Route("GetListPaxConfigAlliance")]
        public HttpResponseMessage GetListPaxConfigAlliance(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (13/08/2020)

        // End (10/08/2020) 
        [HttpPost]
        [Route("UpdStatusRequestBooking")]
        public HttpResponseMessage UpdStatusRequestBooking(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        // End (24/08/2020)

        [HttpPost]
        [Route("AddRegisterMemberToAgent")]
        public HttpResponseMessage AddRegisterMemberToAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListAgentImportToAgentHost")]
        public HttpResponseMessage GetListAgentImportToAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListMemberImportToAgentHost")]
        public HttpResponseMessage GetListMemberImportToAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("AddAgentHostToAgent")]
        public HttpResponseMessage AddAgentHostToAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("GetListAgentHostSentRequestByAgent")]
        public HttpResponseMessage GetListAgentHostSentRequestByAgent(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdActiveAccountMember")]
        public HttpResponseMessage UpdActiveAccountMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        // End (31/08/2020)
        [HttpPost]
        [Route("UpdAcceptAgentByAgentHost")]
        public HttpResponseMessage UpdAcceptAgentByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("UpdAcceptDirectByAgentHost")]
        public HttpResponseMessage UpdAcceptDirectByAgentHost(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        // End (05/09/2020)

        [HttpPost]
        [Route("UpdPaxGroupType")]
        public HttpResponseMessage UpdPaxGroupType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }



        [HttpPost]
        [Route("DelPaxGroupType")]
        public HttpResponseMessage DelPaxGroupType(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        // End (14/09/2020)

        
        [HttpPost]
        [Route("GetDetailCompanyTopup")]
        public HttpResponseMessage GetDetailCompanyTopup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("UpdMemberByManagement")]
        public HttpResponseMessage UpdMemberByManagement(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }


        [HttpPost]
        [Route("AddMemberSupplier")]
        public HttpResponseMessage AddMemberSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }
        [HttpPost]
        [Route("DelMemberSupplier")]
        public HttpResponseMessage DelMemberSupplier(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        
        [HttpPost]
        [Route("GetListMemberGroup")]
        public HttpResponseMessage GetListMemberGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

        [HttpPost]
        [Route("AddMemberGroup")]
        public HttpResponseMessage AddMemberGroup(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            B2B.Bus.CM.busCommond bus = new B2B.Bus.CM.busCommond();
            return Request.CreateResponse(HttpStatusCode.OK, CMSService.ConvertDataSetToArray(bus.ActionMember(ent.strJson)));
        }

    }
}
