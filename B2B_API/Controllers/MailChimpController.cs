using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MailChimp.Net;
using MailChimp.Net.Core;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace B2B_API.Controllers
{
    [RoutePrefix("api/mailchimp")]
    public class MailChimpController : ApiController
    {

        // GET: MailChimp
        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //ServicePointManager.Expect100Continue = true;
        //ServicePointManager.DefaultConnectionLimit = 9999;
        private static readonly MailChimpManager Manager = new MailChimpManager("465f8a1f8ef933bfad05e19fffe7a55e-us10");

        private string list_ID = "6763b91eec";

        [Route("GetAllCampaigns")]
        [HttpPost]
        public HttpResponseMessage GetAllCampaigns(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllCampaigns(ent.strJson).Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.Campaign>> _GetAllCampaigns(string _strJson)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            int intCurPage = Convert.ToInt32(routes_list["intCurPage"]);
            int intPageSize = Convert.ToInt32(routes_list["intPageSize"]);

            var options = new CampaignRequest
            {
                SortField = CampaignSortField.CreateTime,
                SortOrder = CampaignSortOrder.DESC
            };

            options.Offset = (intCurPage - 1) * intPageSize;
            options.Limit = intPageSize;

            IEnumerable<MailChimp.Net.Models.Campaign> model = await Manager.Campaigns.GetAllAsync(options).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }

        [Route("GetAllLists")]
        [HttpPost]
        public HttpResponseMessage GetAllLists()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllLists().Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.List>> _GetAllLists()
        {
            var options = new ListRequest
            {
                //SortOrder = CampaignSortOrder.DESC
            };
            IEnumerable<MailChimp.Net.Models.List> model = await Manager.Lists.GetAllAsync(options).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }
        [Route("GetAllAutomations")]
        [HttpPost]
        public HttpResponseMessage GetAllAutomations()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllAutomations().Result);
        }
        public async Task<MailChimp.Net.Models.ApiInfo> _GetAllAutomations()
        {
            var options = new QueryableBaseRequest
            {
                //SortOrder = CampaignSortOrder.DESC
            };
            MailChimp.Net.Models.ApiInfo model = await Manager.Api.GetInfoAsync().ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }

        [Route("GetAllListResponse")]
        [HttpPost]
        public HttpResponseMessage GetAllListResponse()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllListResponse().Result);
        }
        public async Task<ListResponse> _GetAllListResponse()
        {
            var options = new QueryableBaseRequest
            {
                //SortOrder = CampaignSortOrder.DESC
            };
            ListResponse model = await Manager.Lists.GetResponseAsync().ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }
        [Route("GetAllMembers")]
        [HttpPost]
        public HttpResponseMessage GetAllMembers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllMembers().Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.Member>> _GetAllMembers()
        {
            var options = new QueryableBaseRequest
            {
                //SortOrder = CampaignSortOrder.DESC
            };
            IEnumerable<MailChimp.Net.Models.Member> model = await Manager.Members.GetAllAsync(list_ID).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }


        [Route("AddOrUpdateMemberAsync")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdateMemberAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _AddOrUpdateMemberAsync(ent.strJson).Result);
        }
        public async Task<MailChimp.Net.Models.Member> _AddOrUpdateMemberAsync(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strEmailAddress = Convert.ToString(routes_list["strEmail"]);
            string strFirstName = Convert.ToString(routes_list["strFirstName"]);
            string strLastName = Convert.ToString(routes_list["strLastName"]);
            string strPhoneNumber = Convert.ToString(routes_list["strPhoneNumber"]);
            string strBirthDay = Convert.ToString(routes_list["strBirthDay"]);
            string strAddress = Convert.ToString(routes_list["strAddress"]);
            string strCountryCode = Convert.ToString(routes_list["strCountryCode"]);
            bool IsSubscribed = Convert.ToBoolean(routes_list["IsSubscribed"]);

            var options = new MailChimp.Net.Models.Member
            {
                EmailAddress = strEmailAddress
            };
            MailChimp.Net.Models.Member model = await Manager.Members.AddOrUpdateAsync(list_ID, options).ConfigureAwait(continueOnCapturedContext: false);


            var options2 = new MailChimp.Net.Models.Member
            {
                EmailAddress = strEmailAddress,
                MergeFields = new Dictionary<string, object>
                {
                    { "FNAME", strFirstName },
                    { "LNAME", strLastName },
                    { "PHONE", strPhoneNumber },
                    { "BIRTHDAY", strBirthDay },
                    { "ADDRESS",  new Dictionary<string, object>
                        {
                            { "addr1", strAddress },
                            { "addr2", "" },
                            { "city", "." },
                            { "state", "." },
                            { "zip", "." },
                            { "country", Country(strCountryCode) },
                        } 
                    },
                },
                TimestampSignup = DateTime.UtcNow.ToString("s"),
                Status = (IsSubscribed? MailChimp.Net.Models.Status.Subscribed: MailChimp.Net.Models.Status.Unsubscribed),
            };
            await Manager.Members.AddOrUpdateAsync(list_ID, options2).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }

        [Route("AddOrUpdListMemberAsync")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdListMemberAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            _AddOrUpdListMemberAsync(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _AddOrUpdListMemberAsync(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strArr = Convert.ToString(routes_list["strArr"]);


            var list_routes_list_item = Newtonsoft.Json.JsonConvert.DeserializeObject<List<IDictionary<string, object>>>(strArr);

            foreach (var routes_list_item in list_routes_list_item)
            {

                try
                {
                    string strEmailAddress = Convert.ToString(routes_list_item["strEmail"]);
                    string strFirstName = Convert.ToString(routes_list_item["strFirstName"]);
                    string strLastName = Convert.ToString(routes_list_item["strLastName"]);
                    string strPhoneNumber = Convert.ToString(routes_list_item["strPhoneNumber"]);
                    string strBirthDay = Convert.ToString(routes_list_item["strBirthDay"]);
                    string strAddress = Convert.ToString(routes_list_item["strAddress"]);
                    string strCountryCode = Convert.ToString(routes_list_item["strCountryCode"]);
                    bool IsSubscribed = Convert.ToBoolean(routes_list_item["IsSubscribed"]);

                    var options = new MailChimp.Net.Models.Member
                    {
                        EmailAddress = strEmailAddress
                    };
                    Manager.Members.AddOrUpdateAsync(list_ID, options).Wait();


                    var options2 = new MailChimp.Net.Models.Member
                    {
                        EmailAddress = strEmailAddress,
                        MergeFields = new Dictionary<string, object>
                        {
                            { "FNAME", strFirstName },
                            { "LNAME", strLastName },
                            { "PHONE", strPhoneNumber },
                            { "BIRTHDAY", strBirthDay },
                            { "ADDRESS",  new Dictionary<string, object>
                                {
                                    { "addr1", strAddress },
                                    { "addr2", "" },
                                    { "city", "." },
                                    { "state", "." },
                                    { "zip", "." },
                                    { "country", Country(strCountryCode) },
                                }
                            },
                        },
                        TimestampSignup = DateTime.UtcNow.ToString("s"),
                        Status = (IsSubscribed ? MailChimp.Net.Models.Status.Subscribed : MailChimp.Net.Models.Status.Unsubscribed),
                    };
                    Manager.Members.AddOrUpdateAsync(list_ID, options2).Wait(); ;

                    UpdContactForIsOnMailTrimp("{"
                        + "strUserGUID: '" + Convert.ToString(routes_list_item["strUserGUID"]) + "' "
                        + ", strContactGUID: '" + Convert.ToString(routes_list_item["strContactGUID"]) + "' "
                        + ", IsOnMailTrimp: 1"
                        + "}");
                }
                catch (Exception e)
                {
                    String a = e.Message;
                }

            }

           
        }

        private void UpdContactForIsOnMailTrimp(string _strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            bus.ActionClient(_strJson);
        }

        [Route("AddOrUpdListTag")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdListTag(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            _AddOrUpdListTag(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _AddOrUpdListTag(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strArr = Convert.ToString(routes_list["strArr"]);


            var list_routes_list_item = Newtonsoft.Json.JsonConvert.DeserializeObject<List<IDictionary<string, object>>>(strArr);

            foreach (var routes_list_item in list_routes_list_item)
            {
                string strEmail = Convert.ToString(routes_list_item["strEmail"]);
                string strName = Convert.ToString(routes_list_item["strName"]);
                bool IsActive = Convert.ToBoolean(routes_list_item["IsActive"]);

                try
                {
                    MailChimp.Net.Models.Tags tags = new MailChimp.Net.Models.Tags();
                    tags.MemberTags.Add(new MailChimp.Net.Models.Tag()
                    {
                        Name = strName,
                        Status = (IsActive ? "active" : "inactive")
                    });
                    Manager.Members.AddTagsAsync(list_ID, strEmail, tags).Wait();

                    UpdContactUsedForIsChanged("{"
                        + "strUserGUID: '" + Convert.ToString(routes_list_item["strUserGUID"]) + "' "
                        + ", strContactGUID: '" + Convert.ToString(routes_list_item["strContactGUID"]) + "' "
                        + ", intContactTagID: " + Convert.ToString(routes_list_item["intContactTagID"]) + " "
                        + ", IsChanged: 0"
                        + "}");
                }
                catch (Exception e)
                {
                    String a = e.Message;
                }
                finally
                {
                    //mgr = null;
                }
            }
        }
        private void UpdContactUsedForIsChanged(string _strJson)
        {
            B2B.Bus.SL.busCommond bus = new B2B.Bus.SL.busCommond();
            bus.ActionClient(_strJson);
        }


        [Route("SendAsyncCampaigns")]
        [HttpPost]
        public HttpResponseMessage SendAsyncCampaigns(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            _SendAsyncCampaigns(Convert.ToString(routes_list["campaignId"]));
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _SendAsyncCampaigns(string _campaignId)
        {
            try
            {
                Manager.Campaigns.SendAsync(_campaignId).Wait();
            }
            catch (Exception e)
            {
                String a = e.Message;
            }

        }

        [Route("ReplicateCampaignAsync")]
        [HttpPost]
        public HttpResponseMessage ReplicateCampaignAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            _ReplicateCampaignAsync(Convert.ToString(routes_list["campaignId"]));
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _ReplicateCampaignAsync(string _campaignId)
        {
            try
            {
                Manager.Campaigns.ReplicateCampaignAsync(_campaignId).Wait();
            }
            catch (Exception e)
            {
                String a = e.Message;
            }

        }

        [Route("GetContentCampaignAsync")]
        [HttpPost]
        public HttpResponseMessage GetContentCampaignAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

            return Request.CreateResponse(HttpStatusCode.OK, _GetContentCampaignAsync(Convert.ToString(routes_list["campaignId"])).Result);
        }
        public async Task<MailChimp.Net.Models.Content> _GetContentCampaignAsync(string _campaignId)
        {
            MailChimp.Net.Models.Content model = await Manager.Content.GetAsync(_campaignId).ConfigureAwait(continueOnCapturedContext: false);
            //MailChimp.Net.Models.Campaign model = await Manager.Templates.GetAllAsync().ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }



        [Route("AddOrUpdateCampaignAsync")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdateCampaignAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _AddOrUpdateCampaignAsync(ent.strJson).Result);
        }
        public async Task<MailChimp.Net.Models.Campaign> _AddOrUpdateCampaignAsync(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string campaignID = Convert.ToString(routes_list["campaignId"]);
            string segmentId = Convert.ToString(routes_list["segmentId"]);
            string title = Convert.ToString(routes_list["title"]);
            string subject_line = Convert.ToString(routes_list["subject_line"]);
            string from_email = Convert.ToString(routes_list["from_email"]);
            string from_name = Convert.ToString(routes_list["from_name"]);
            string html = Convert.ToString(routes_list["html"]);

            try
            {

                // convert to utc and round up to nearest 15 mins
                //if (sendTime.Kind != DateTimeKind.Utc)
                //    sendTime = sendTime.ToUniversalTime();
                //sendTime = sendTime.RoundUp(TimeSpan.FromMinutes(15));

                MailChimp.Net.Models.Campaign newCampaign = new MailChimp.Net.Models.Campaign();
                newCampaign.Id = campaignID;
                newCampaign.Type = CampaignType.Regular;
                newCampaign.Settings = new MailChimp.Net.Models.Setting();
                newCampaign.Settings.Title = title;
                newCampaign.Settings.SubjectLine = subject_line;
                newCampaign.Settings.ReplyTo = from_email;
                newCampaign.Settings.FromName = from_name;
                newCampaign.Recipients = new MailChimp.Net.Models.Recipient();
                newCampaign.Recipients.ListId = list_ID;
                if (!string.IsNullOrEmpty(segmentId))
                {
                    newCampaign.Recipients.SegmentOptions = new MailChimp.Net.Models.SegmentOptions
                    {
                        SavedSegmentId = Convert.ToInt32(segmentId)
                    };
                }

                newCampaign = await Manager.Campaigns.AddOrUpdateAsync(newCampaign).ConfigureAwait(continueOnCapturedContext: false);

                //campaignID = newCampaign.Id;
                //ContentRequest content = new ContentRequest();
                //content.Html = emailText;

                //mgr.Content.AddOrUpdateAsync(campaignID, content);

                //mgr.Campaigns.ScheduleAsync(newCampaign.Id, new CampaignScheduleRequest()
                //{ ScheduleTime = sendTime.ToString("o") });

                //mgr.Campaigns.SendAsync(campaignID);
                var options = new MailChimp.Net.Core.ContentRequest
                {
                    Html = html
                };
                await Manager.Content.AddOrUpdateAsync(newCampaign.Id, options).ConfigureAwait(continueOnCapturedContext: false);

                return newCampaign;
            }
            finally
            {
                //mgr = null;
            }
        }


        [Route("DeleteCampaignAsync")]
        [HttpPost]
        public HttpResponseMessage DeleteCampaignAsync(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            _DeleteCampaignAsync(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _DeleteCampaignAsync(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string campaignId = Convert.ToString(routes_list["campaignId"]);

            Manager.Campaigns.DeleteAsync(campaignId).Wait();

        }


        [Route("GetAllSegments")]
        [HttpPost]
        public HttpResponseMessage GetAllSegments(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllSegments(ent.strJson).Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.ListSegment>> _GetAllSegments(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strType = Convert.ToString(routes_list["strType"]);

            int intCurPage = Convert.ToInt32(routes_list["intCurPage"]);
            int intPageSize = Convert.ToInt32(routes_list["intPageSize"]);

            var options = new ListSegmentRequest();

            options.Offset = (intCurPage - 1) * intPageSize;
            options.Limit = intPageSize;

            if (!string.IsNullOrEmpty(strType))
            {
                options.Type = strType;
            }

            IEnumerable<MailChimp.Net.Models.ListSegment> model = await Manager.ListSegments.GetAllAsync(list_ID, options).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }


        [Route("AddOrUpdSegment")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdSegment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _AddOrUpdSegment(ent.strJson).Result);
        }
        public async Task<MailChimp.Net.Models.ListSegment> _AddOrUpdSegment(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string id = Convert.ToString(routes_list["id"]);
            string strName = Convert.ToString(routes_list["strName"]);
            string strMatch = Convert.ToString(routes_list["strMatch"]);
            string strArrCon = Convert.ToString(routes_list["arrCon"]);

            try
            {

                var list_routes_list_item = Newtonsoft.Json.JsonConvert.DeserializeObject<List<IDictionary<string, object>>>(strArrCon);

                List<MailChimp.Net.Models.Condition> list = new List<MailChimp.Net.Models.Condition>();

                foreach (var routes_list_item in list_routes_list_item)
                {
                    string strType = Convert.ToString(routes_list_item["strType"]);
                    string strOperator = Convert.ToString(routes_list_item["strOperator"]);
                    string strField = Convert.ToString(routes_list_item["strField"]);
                    string strValue = Convert.ToString(routes_list_item["strValue"]);
                    string strExtra = Convert.ToString(routes_list_item["strExtra"]);

                    list.Add(
                        new MailChimp.Net.Models.Condition
                        {
                            Type = ConditionType(strType),
                            Field = strField,
                            Operator = Operator(strOperator),
                            Value = strValue,
                            Extra = strExtra
                        }
                    );
                }

                MailChimp.Net.Core.Segment newCampaign = new MailChimp.Net.Core.Segment();
                newCampaign.Name = strName;
                newCampaign.EmailAddresses = null;
                newCampaign.Options = new MailChimp.Net.Models.SegmentOptions
                {
                    Match = Match(strMatch),
                    Conditions = list
                };
                MailChimp.Net.Models.ListSegment model;
                if (!string.IsNullOrEmpty(id))
                {
                    model = await Manager.ListSegments.UpdateAsync(list_ID, id, newCampaign).ConfigureAwait(continueOnCapturedContext: false);
                }
                else
                {
                    model = await Manager.ListSegments.AddAsync(list_ID, newCampaign).ConfigureAwait(continueOnCapturedContext: false);
                }
                return model;
            }
            finally
            {
                //mgr = null;
            }
        }

        [Route("AddOrUpdTag")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdTag(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            _AddOrUpdTag(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        //[Route("AddOrUpdListTag")]
        //[HttpPost]
        //public HttpResponseMessage AddOrUpdListTag(B2B.Ent.SL.entCommond.entFilterData ent)
        //{

        //    var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //    var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(ent.strJson);

        //    var arrList = routes_list["arrList"];


        //    var arrListObj = arrList<List<IDictionary<string, object>>>;


        //    _AddOrUpdTag(ent.strJson);
        //    return Request.CreateResponse(HttpStatusCode.OK, "");
        //}
        public void _AddOrUpdTag(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strEmail = Convert.ToString(routes_list["strEmail"]);
            string strName = Convert.ToString(routes_list["strName"]);
            bool IsActive = Convert.ToBoolean(routes_list["IsActive"]);

            try
            {
                MailChimp.Net.Models.Tags tags = new MailChimp.Net.Models.Tags();
                tags.MemberTags.Add(new MailChimp.Net.Models.Tag()
                {
                    Name = strName,
                    Status = (IsActive? "active" : "inactive")
                });
                Manager.Members.AddTagsAsync(list_ID, strEmail, tags).Wait();
            }
            finally
            {
                //mgr = null;
            }
        }


        [Route("GetAllTagsByMember")]
        [HttpPost]
        public HttpResponseMessage GetAllTagsByMember(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllTagsByMember(ent.strJson).Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.MemberTag>> _GetAllTagsByMember(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string strEmail = Convert.ToString(routes_list["strEmail"]);;

            try
            {
                Manager.Members.GetTagsAsync(list_ID, strEmail).Wait();

                IEnumerable<MailChimp.Net.Models.MemberTag> model = await Manager.Members.GetTagsAsync(list_ID, strEmail).ConfigureAwait(continueOnCapturedContext: false);
                return model;
            }
            finally
            {
                //mgr = null;
            }
        }


        [Route("DelSegment")]
        [HttpPost]
        public HttpResponseMessage DelSegment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            _DelSegment(ent.strJson);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
        public void _DelSegment(string _strJson)
        {

            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string id = Convert.ToString(routes_list["id"]);

            Manager.ListSegments.DeleteAsync(list_ID, id).Wait();

        }


        [Route("GetAllMembersBySegment")]
        [HttpPost]
        public HttpResponseMessage GetAllMembersBySegment(B2B.Ent.SL.entCommond.entFilterData ent)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _GetAllMembersBySegment(ent.strJson).Result);
        }
        public async Task<IEnumerable<MailChimp.Net.Models.Member>> _GetAllMembersBySegment(string _strJson)
        {
            var json_serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>)json_serializer.DeserializeObject(_strJson);

            string segmentId = Convert.ToString(routes_list["segmentId"]);
            int intCurPage = Convert.ToInt32(routes_list["intCurPage"]);
            int intPageSize = Convert.ToInt32(routes_list["intPageSize"]);

            var options = new QueryableBaseRequest
            {
                Offset = (intCurPage - 1) * intPageSize,
                Limit = intPageSize
                //SortOrder = CampaignSortOrder.DESC
            };


            IEnumerable<MailChimp.Net.Models.Member> model = await Manager.ListSegments.GetAllMembersAsync(list_ID, segmentId, options).ConfigureAwait(continueOnCapturedContext: false);

            return model;
        }


        private MailChimp.Net.Models.ConditionType ConditionType(string _str)
        {
            MailChimp.Net.Models.ConditionType type = new MailChimp.Net.Models.ConditionType();

            if (_str == "Aim")//---"aim"(Campaign Activity)
                type = MailChimp.Net.Models.ConditionType.Aim;
            if (_str == "automation")//--- "automation"(Automation Activity)
                type = MailChimp.Net.Models.ConditionType.Automation;
            if (_str == "poll")
                type = MailChimp.Net.Models.ConditionType.CampaignPoll;
            if (_str == "conversation")//-- "conversation"(Conversations Activity)
                type = MailChimp.Net.Models.ConditionType.Conversation;
            if (_str == "timestamp_opt")
                type = MailChimp.Net.Models.ConditionType.Timestamp;
            if (_str == "info_changed")
                type = MailChimp.Net.Models.ConditionType.InfoChanged;
            if (_str == "ecomm_date")
                type = MailChimp.Net.Models.ConditionType.EcommDate;
            if (_str == "email_client")//---- "email_client"
                type = MailChimp.Net.Models.ConditionType.EmailClient;
            if (_str == "Language")// -- "language"
                type = MailChimp.Net.Models.ConditionType.Language;
            if (_str == "Mandrill")
                type = MailChimp.Net.Models.ConditionType.Mandrill;
            if (_str == "rating")//---- "rating"(Contact Rating)
                type = MailChimp.Net.Models.ConditionType.MemberRating;
            if (_str == "source")//---"source"(Signup Source)
                type = MailChimp.Net.Models.ConditionType.SignupSource;
            if (_str == "survey_monkey")
                type = MailChimp.Net.Models.ConditionType.SurveyMonkey;
            if (_str == "gmonkey")//----VIPs
                type = MailChimp.Net.Models.ConditionType.VIP;
            if (_str == "ecomm_cat")
                type = MailChimp.Net.Models.ConditionType.EcommCategory;
            if (_str == "EcommNumber")
                type = MailChimp.Net.Models.ConditionType.EcommNumber;
            if (_str == "ecomm_prod")
                type = MailChimp.Net.Models.ConditionType.EcommProduct;
            if (_str == "ecomm_spent_avg")
                type = MailChimp.Net.Models.ConditionType.EcommSpentAverage;
            if (_str == "ecomm_orders")
                type = MailChimp.Net.Models.ConditionType.EcommOrders;
            if (_str == "ecomm_prod_all")
                type = MailChimp.Net.Models.ConditionType.EcommAllProducts;
            if (_str == "ecomm_avg_ord")
                type = MailChimp.Net.Models.ConditionType.EcommAverageOrder;
            if (_str == "ecomm_purchased")
                type = MailChimp.Net.Models.ConditionType.EcommPurchased;
            if (_str == "ecomm_spent_one")
                type = MailChimp.Net.Models.ConditionType.EcommSpentOne;
            if (_str == "ecomm_spent_all")
                type = MailChimp.Net.Models.ConditionType.EcommSpentAll;
            if (_str == "ecomm_store")
                type = MailChimp.Net.Models.ConditionType.EcommStore;
            if (_str == "goal")
                type = MailChimp.Net.Models.ConditionType.GoalActivity;
            if (_str == "goal_last_visited")
                type = MailChimp.Net.Models.ConditionType.GoalTimestamp;
            if (_str == "fuzzy_segment")
                type = MailChimp.Net.Models.ConditionType.FuzzySegment;
            if (_str == "StaticSegment")//--- "static_segment"(Tags)
                type = MailChimp.Net.Models.ConditionType.StaticSegment;
            if (_str == "IPGeoCountryState")//--- "ipgeo"(LOcation)
                type = MailChimp.Net.Models.ConditionType.IPGeoCountryState;
            if (_str == "ipgeo")
                type = MailChimp.Net.Models.ConditionType.IPGeo;
            if (_str == "IPGeoIn")//---
                type = MailChimp.Net.Models.ConditionType.IPGeoIn;
            if (_str == "IPGeoInZip")
                type = MailChimp.Net.Models.ConditionType.IPGeoInZip;
            if (_str == "IPGeoUnknown")
                type = MailChimp.Net.Models.ConditionType.IPGeoUnknown;
            if (_str == "IPGeoZip")
                type = MailChimp.Net.Models.ConditionType.IPGeoZip;
            if (_str == "social_age")
                type = MailChimp.Net.Models.ConditionType.SocialAge;
            if (_str == "social_gender")
                type = MailChimp.Net.Models.ConditionType.SocialGender;
            if (_str == "social_influence")
                type = MailChimp.Net.Models.ConditionType.SocialInfluence;
            if (_str == "social_network")
                type = MailChimp.Net.Models.ConditionType.SocialNetwork;
            if (_str == "AddressMerge")//---"ADDRESS"
                type = MailChimp.Net.Models.ConditionType.AddressMerge;
            if (_str == "ZipMerge")
                type = MailChimp.Net.Models.ConditionType.ZipMerge;
            if (_str == "BirthdayMerge")//---- "BIRTHDAY"
                type = MailChimp.Net.Models.ConditionType.BirthdayMerge;
            if (_str == "Date")//---- "info_changed"  --- "timestamp_opt"
                type = MailChimp.Net.Models.ConditionType.Date;
            if (_str == "Interests")
                type = MailChimp.Net.Models.ConditionType.Interests;
            if (_str == "TextMerge")//FirstName:FNAME -- "PHONE" --- "LNAME" --- 
                type = MailChimp.Net.Models.ConditionType.TextMerge;
            if (_str == "SelectMerge")
                type = MailChimp.Net.Models.ConditionType.SelectMerge;
            if (_str == "EmailAddress")//--- "EMAIL"
                type = MailChimp.Net.Models.ConditionType.EmailAddress;
            if (_str == "DateMerge")
                type = MailChimp.Net.Models.ConditionType.DateMerge;

            return type;
        }

        private MailChimp.Net.Models.Operator Operator(string _str)
        {

            MailChimp.Net.Models.Operator type = new MailChimp.Net.Models.Operator();
            if (_str == "open")
                type = MailChimp.Net.Models.Operator.Open;
            if (_str == "click")
                type = MailChimp.Net.Models.Operator.Click;
            if (_str == "sent")
                type = MailChimp.Net.Models.Operator.Sent;
            if (_str == "noopen")
                type = MailChimp.Net.Models.Operator.NotOpened;
            if (_str == "noclick")
                type = MailChimp.Net.Models.Operator.NotClicked;
            if (_str == "nosent")
                type = MailChimp.Net.Models.Operator.NotSent;
            if (_str == "started")
                type = MailChimp.Net.Models.Operator.Started;
            if (_str == "completed")
                type = MailChimp.Net.Models.Operator.Completed;
            if (_str == "not_started")
                type = MailChimp.Net.Models.Operator.NotStarted;
            if (_str == "not_completed")
                type = MailChimp.Net.Models.Operator.NotCompleted;
            if (_str == "member")
                type = MailChimp.Net.Models.Operator.Member;
            if (_str == "notmember")
                type = MailChimp.Net.Models.Operator.NonMember;
            if (_str == "greater")
                type = MailChimp.Net.Models.Operator.Greater;
            if (_str == "less")
                type = MailChimp.Net.Models.Operator.Less;
            if (_str == "is")
                type = MailChimp.Net.Models.Operator.Is;
            if (_str == "not")
                type = MailChimp.Net.Models.Operator.Not;
            if (_str == "blank")
                type = MailChimp.Net.Models.Operator.Blank;
            if (_str == "blank_not")
                type = MailChimp.Net.Models.Operator.NotBlank;
            if (_str == "contains")
                type = MailChimp.Net.Models.Operator.Contains;
            if (_str == "notcontain")
                type = MailChimp.Net.Models.Operator.DoesNotContain;
            if (_str == "starts")
                type = MailChimp.Net.Models.Operator.Starts;
            if (_str == "ends")
                type = MailChimp.Net.Models.Operator.Ends;
            if (_str == "client_is")
                type = MailChimp.Net.Models.Operator.ClientIs;
            if (_str == "client_not")
                type = MailChimp.Net.Models.Operator.ClientIsNot;
            if (_str == "source_is")
                type = MailChimp.Net.Models.Operator.SourceIs;
            if (_str == "source_not")
                type = MailChimp.Net.Models.Operator.SourceIsNot;
            if (_str == "goal_not")
                type = MailChimp.Net.Models.Operator.GoalNot;
            if (_str == "goal_notcontain")
                type = MailChimp.Net.Models.Operator.GoalDoesNotContain;
            if (_str == "fuzzy_is")
                type = MailChimp.Net.Models.Operator.FuzzyIs;
            if (_str == "fuzzy_not")
                type = MailChimp.Net.Models.Operator.FuzzyIsNot;
            if (_str == "static_is")
                type = MailChimp.Net.Models.Operator.StaticIs;
            if (_str == "static_not")
                type = MailChimp.Net.Models.Operator.StatisIsNot;
            if (_str == "ipgeocountry")
                type = MailChimp.Net.Models.Operator.IPGeoCountry;
            if (_str == "ipgeonotcountry")
                type = MailChimp.Net.Models.Operator.IPGeoNotCountry;
            if (_str == "ipgeostate")
                type = MailChimp.Net.Models.Operator.IPGeoState;
            if (_str == "ipgeonotstate")
                type = MailChimp.Net.Models.Operator.IPGeoNotState;
            if (_str == "ipgeoin")
                type = MailChimp.Net.Models.Operator.IPGeoIn;
            if (_str == "ipgeonotin")
                type = MailChimp.Net.Models.Operator.IPGeoNotIn;
            if (_str == "ipgeoinzip")
                type = MailChimp.Net.Models.Operator.IPGeoInZip;
            if (_str == "ipgeounknown")
                type = MailChimp.Net.Models.Operator.IPGeoUnknown;
            if (_str == "ipgeoiszip")
                type = MailChimp.Net.Models.Operator.IPGeoIsZip;
            if (_str == "ipgeonotzip")
                type = MailChimp.Net.Models.Operator.IPGeoIsNotZip;
            if (_str == "follow")
                type = MailChimp.Net.Models.Operator.Follow;
            if (_str == "notfollow")
                type = MailChimp.Net.Models.Operator.NotFollow;
            if (_str == "interestcontains")
                type = MailChimp.Net.Models.Operator.InterestContains;
            if (_str == "interestcontainsall")
                type = MailChimp.Net.Models.Operator.InterestContainsAll;
            if (_str == "interestnotcontains")
                type = MailChimp.Net.Models.Operator.InterestNotContains;
            if (_str == "date_within")
                type = MailChimp.Net.Models.Operator.DateWithin;
            if (_str == "date_notwithin")
                type = MailChimp.Net.Models.Operator.DateNotWithin;
            if (_str == "within")
                type = MailChimp.Net.Models.Operator.Within;
            if (_str == "notwithin")
                type = MailChimp.Net.Models.Operator.NotWithin;

            return type;
        }

        private MailChimp.Net.Models.Match Match(string _str)
        {
            var match = new MailChimp.Net.Models.Match();
            if(_str == "all")
            {
                match = MailChimp.Net.Models.Match.All;
            }
            if (_str == "any")
            {
                match = MailChimp.Net.Models.Match.Any;
            }
            if (_str == "empty")
            {
                match = MailChimp.Net.Models.Match.Empty;
            }
            return match;
        }

        private int Country(string _str)
        {
            int intCountry = 0;
            if (_str == "VN")
            {
                intCountry = 168;
            }
            if (_str == "US")
            {
                intCountry = 164;
            }

            if (_str == "UK")
            {
                intCountry = 262;
            }

            if (intCountry == 0)
                intCountry = 168;

            return intCountry;
        }
    }
}