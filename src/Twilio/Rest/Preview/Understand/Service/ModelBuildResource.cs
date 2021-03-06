/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// ModelBuildResource
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

namespace Twilio.Rest.Preview.Understand.Service 
{

    public class ModelBuildResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Enqueued = new StatusEnum("enqueued");
            public static readonly StatusEnum Building = new StatusEnum("building");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
        }

        private static Request BuildFetchRequest(FetchModelBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Services/" + options.PathServiceSid + "/ModelBuilds/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Fetch(FetchModelBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> FetchAsync(FetchModelBuildOptions options, 
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
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchModelBuildOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> FetchAsync(string pathServiceSid, 
                                                                                       string pathSid, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchModelBuildOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadModelBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Services/" + options.PathServiceSid + "/ModelBuilds",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ResourceSet<ModelBuildResource> Read(ReadModelBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ModelBuildResource>.FromJson("model_builds", response.Content);
            return new ResourceSet<ModelBuildResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ModelBuildResource>> ReadAsync(ReadModelBuildOptions options, 
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ModelBuildResource>.FromJson("model_builds", response.Content);
            return new ResourceSet<ModelBuildResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ResourceSet<ModelBuildResource> Read(string pathServiceSid, 
                                                           int? pageSize = null, 
                                                           long? limit = null, 
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadModelBuildOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ModelBuildResource>> ReadAsync(string pathServiceSid, 
                                                                                                   int? pageSize = null, 
                                                                                                   long? limit = null, 
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadModelBuildOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ModelBuildResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ModelBuildResource> NextPage(Page<ModelBuildResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ModelBuildResource> PreviousPage(Page<ModelBuildResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }

        private static Request BuildCreateRequest(CreateModelBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Services/" + options.PathServiceSid + "/ModelBuilds",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Create(CreateModelBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> CreateAsync(CreateModelBuildOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Create(string pathServiceSid, 
                                                Uri statusCallback = null, 
                                                string uniqueName = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new CreateModelBuildOptions(pathServiceSid){StatusCallback = statusCallback, UniqueName = uniqueName};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> CreateAsync(string pathServiceSid, 
                                                                                        Uri statusCallback = null, 
                                                                                        string uniqueName = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateModelBuildOptions(pathServiceSid){StatusCallback = statusCallback, UniqueName = uniqueName};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateModelBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Services/" + options.PathServiceSid + "/ModelBuilds/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Update(UpdateModelBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> UpdateAsync(UpdateModelBuildOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static ModelBuildResource Update(string pathServiceSid, 
                                                string pathSid, 
                                                string uniqueName = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateModelBuildOptions(pathServiceSid, pathSid){UniqueName = uniqueName};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<ModelBuildResource> UpdateAsync(string pathServiceSid, 
                                                                                        string pathSid, 
                                                                                        string uniqueName = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateModelBuildOptions(pathServiceSid, pathSid){UniqueName = uniqueName};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteModelBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/understand/Services/" + options.PathServiceSid + "/ModelBuilds/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static bool Delete(DeleteModelBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteModelBuildOptions options, 
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
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ModelBuild </returns> 
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteModelBuildOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteModelBuildOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ModelBuildResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ModelBuildResource object represented by the provided JSON </returns> 
        public static ModelBuildResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ModelBuildResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
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
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ModelBuildResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ModelBuildResource()
        {

        }
    }

}