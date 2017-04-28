using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;

namespace Twilio.Rest.IpMessaging.V2.Service.Channel 
{

    /// <summary>
    /// FetchMemberOptions
    /// </summary>
    public class FetchMemberOptions : IOptions<MemberResource> 
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
        /// Construct a new FetchMemberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
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
    /// CreateMemberOptions
    /// </summary>
    public class CreateMemberOptions : IOptions<MemberResource> 
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
        /// The identity
        /// </summary>
        public string Identity { get; }
        /// <summary>
        /// The role_sid
        /// </summary>
        public string RoleSid { get; set; }

        /// <summary>
        /// Construct a new CreateMemberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="identity"> The identity </param>
        public CreateMemberOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadMemberOptions
    /// </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource> 
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
        /// The identity
        /// </summary>
        public List<string> Identity { get; set; }

        /// <summary>
        /// Construct a new ReadMemberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        public ReadMemberOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteMemberOptions
    /// </summary>
    public class DeleteMemberOptions : IOptions<MemberResource> 
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
        /// Construct a new DeleteMemberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
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
    /// UpdateMemberOptions
    /// </summary>
    public class UpdateMemberOptions : IOptions<MemberResource> 
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
        /// The role_sid
        /// </summary>
        public string RoleSid { get; set; }
        /// <summary>
        /// The last_consumed_message_index
        /// </summary>
        public int? LastConsumedMessageIndex { get; set; }

        /// <summary>
        /// Construct a new UpdateMemberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathChannelSid"> The channel_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
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
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }

            return p;
        }
    }

}