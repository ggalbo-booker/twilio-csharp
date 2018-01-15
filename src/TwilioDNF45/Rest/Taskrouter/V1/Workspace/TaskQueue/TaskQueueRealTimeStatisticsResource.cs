/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TaskQueueRealTimeStatisticsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue 
{

    public class TaskQueueRealTimeStatisticsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchTaskQueueRealTimeStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskQueues/" + options.PathTaskQueueSid + "/RealTimeStatistics",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueRealTimeStatistics </returns> 
        public static TaskQueueRealTimeStatisticsResource Fetch(FetchTaskQueueRealTimeStatisticsOptions options, 
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueRealTimeStatistics </returns> 
        public static async System.Threading.Tasks.Task<TaskQueueRealTimeStatisticsResource> FetchAsync(FetchTaskQueueRealTimeStatisticsOptions options, 
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
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueRealTimeStatistics </returns> 
        public static TaskQueueRealTimeStatisticsResource Fetch(string pathWorkspaceSid, 
                                                                string pathTaskQueueSid, 
                                                                string taskChannel = null, 
                                                                ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueRealTimeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){TaskChannel = taskChannel};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueRealTimeStatistics </returns> 
        public static async System.Threading.Tasks.Task<TaskQueueRealTimeStatisticsResource> FetchAsync(string pathWorkspaceSid, 
                                                                                                        string pathTaskQueueSid, 
                                                                                                        string taskChannel = null, 
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueRealTimeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){TaskChannel = taskChannel};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TaskQueueRealTimeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueRealTimeStatisticsResource object represented by the provided JSON </returns> 
        public static TaskQueueRealTimeStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueRealTimeStatisticsResource>(json);
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
        /// The activity_statistics
        /// </summary>
        [JsonProperty("activity_statistics")]
        public List<object> ActivityStatistics { get; private set; }
        /// <summary>
        /// The longest_task_waiting_age
        /// </summary>
        [JsonProperty("longest_task_waiting_age")]
        public int? LongestTaskWaitingAge { get; private set; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }
        /// <summary>
        /// The tasks_by_priority
        /// </summary>
        [JsonProperty("tasks_by_priority")]
        public object TasksByPriority { get; private set; }
        /// <summary>
        /// The tasks_by_status
        /// </summary>
        [JsonProperty("tasks_by_status")]
        public object TasksByStatus { get; private set; }
        /// <summary>
        /// The total_available_workers
        /// </summary>
        [JsonProperty("total_available_workers")]
        public int? TotalAvailableWorkers { get; private set; }
        /// <summary>
        /// The total_eligible_workers
        /// </summary>
        [JsonProperty("total_eligible_workers")]
        public int? TotalEligibleWorkers { get; private set; }
        /// <summary>
        /// The total_tasks
        /// </summary>
        [JsonProperty("total_tasks")]
        public int? TotalTasks { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private TaskQueueRealTimeStatisticsResource()
        {

        }
    }

}