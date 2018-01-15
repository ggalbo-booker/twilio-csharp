/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// UserBindingResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.IpMessaging.V2.Service.User 
{

    public class UserBindingResource : Resource 
    {
        public sealed class BindingTypeEnum : StringEnum 
        {
            private BindingTypeEnum(string value) : base(value) {}
            public BindingTypeEnum() {}
            public static implicit operator BindingTypeEnum(string value)
            {
                return new BindingTypeEnum(value);
            }

            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");
        }

        private static Request BuildReadRequest(ReadUserBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Bindings",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static ResourceSet<UserBindingResource> Read(ReadUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<UserBindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<UserBindingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserBindingResource>> ReadAsync(ReadUserBindingOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UserBindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<UserBindingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="bindingType"> The binding_type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static ResourceSet<UserBindingResource> Read(string pathServiceSid, 
                                                            string pathUserSid, 
                                                            List<UserBindingResource.BindingTypeEnum> bindingType = null, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadUserBindingOptions(pathServiceSid, pathUserSid){BindingType = bindingType, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="bindingType"> The binding_type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserBindingResource>> ReadAsync(string pathServiceSid, 
                                                                                                    string pathUserSid, 
                                                                                                    List<UserBindingResource.BindingTypeEnum> bindingType = null, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadUserBindingOptions(pathServiceSid, pathUserSid){BindingType = bindingType, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<UserBindingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<UserBindingResource> NextPage(Page<UserBindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<UserBindingResource> PreviousPage(Page<UserBindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

        private static Request BuildFetchRequest(FetchUserBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Bindings/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static UserBindingResource Fetch(FetchUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<UserBindingResource> FetchAsync(FetchUserBindingOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static UserBindingResource Fetch(string pathServiceSid, 
                                                string pathUserSid, 
                                                string pathSid, 
                                                ITwilioRestClient client = null)
        {
            var options = new FetchUserBindingOptions(pathServiceSid, pathUserSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<UserBindingResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathUserSid, 
                                                                                        string pathSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchUserBindingOptions(pathServiceSid, pathUserSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteUserBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Bindings/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static bool Delete(DeleteUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUserBindingOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns> 
        public static bool Delete(string pathServiceSid, string pathUserSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteUserBindingOptions(pathServiceSid, pathUserSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathUserSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteUserBindingOptions(pathServiceSid, pathUserSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a UserBindingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserBindingResource object represented by the provided JSON </returns> 
        public static UserBindingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UserBindingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The endpoint
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }
        /// <summary>
        /// The identity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The user_sid
        /// </summary>
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }
        /// <summary>
        /// The credential_sid
        /// </summary>
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }
        /// <summary>
        /// The binding_type
        /// </summary>
        [JsonProperty("binding_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserBindingResource.BindingTypeEnum BindingType { get; private set; }
        /// <summary>
        /// The message_types
        /// </summary>
        [JsonProperty("message_types")]
        public List<string> MessageTypes { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private UserBindingResource()
        {

        }
    }

}