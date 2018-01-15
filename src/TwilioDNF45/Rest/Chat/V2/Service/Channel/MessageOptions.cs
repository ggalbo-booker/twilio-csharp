/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.Channel 
{

    /// <summary>
    /// FetchMessageOptions
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateMessageOptions
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The from
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// The attributes
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date_created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The last_updated_by
        /// </summary>
        public string LastUpdatedBy { get; set; }
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The media_sid
        /// </summary>
        public string MediaSid { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        public CreateMessageOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (LastUpdatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("LastUpdatedBy", LastUpdatedBy));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaSid", MediaSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadMessageOptions
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The order
        /// </summary>
        public MessageResource.OrderTypeEnum Order { get; set; }

        /// <summary>
        /// Construct a new ReadMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        public ReadMessageOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteMessageOptions
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateMessageOptions
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The attributes
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date_created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The last_updated_by
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (LastUpdatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("LastUpdatedBy", LastUpdatedBy));
            }

            return p;
        }
    }

}