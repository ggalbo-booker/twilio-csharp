/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Send a message from the account used to make the request
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The phone number to receive the message
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The phone number that initiated the message
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// The messaging_service_sid
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The media_url
        /// </summary>
        public List<Uri> MediaUrl { get; set; }
        /// <summary>
        /// URL Twilio will request when the status changes
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The application to use for callbacks
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// The max_price
        /// </summary>
        public decimal? MaxPrice { get; set; }
        /// <summary>
        /// The provide_feedback
        /// </summary>
        public bool? ProvideFeedback { get; set; }
        /// <summary>
        /// The validity_period
        /// </summary>
        public int? ValidityPeriod { get; set; }
        /// <summary>
        /// The max_rate
        /// </summary>
        public string MaxRate { get; set; }
        /// <summary>
        /// The force_delivery
        /// </summary>
        public bool? ForceDelivery { get; set; }
        /// <summary>
        /// The provider_sid
        /// </summary>
        public string ProviderSid { get; set; }
        /// <summary>
        /// The content_retention
        /// </summary>
        public MessageResource.ContentRetentionEnum ContentRetention { get; set; }
        /// <summary>
        /// The address_retention
        /// </summary>
        public MessageResource.AddressRetentionEnum AddressRetention { get; set; }
        /// <summary>
        /// The smart_encoded
        /// </summary>
        public bool? SmartEncoded { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="to"> The phone number to receive the message </param>
        public CreateMessageOptions(Types.PhoneNumber to)
        {
            To = to;
            MediaUrl = new List<Uri>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaUrl != null)
            {
                p.AddRange(MediaUrl.Select(prop => new KeyValuePair<string, string>("MediaUrl", prop.AbsoluteUri.TrimEnd('/'))));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.AbsoluteUri.TrimEnd('/')));
            }

            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }

            if (MaxPrice != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxPrice", MaxPrice.Value.ToString()));
            }

            if (ProvideFeedback != null)
            {
                p.Add(new KeyValuePair<string, string>("ProvideFeedback", ProvideFeedback.Value.ToString().ToLower()));
            }

            if (ValidityPeriod != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidityPeriod", ValidityPeriod.Value.ToString()));
            }

            if (MaxRate != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxRate", MaxRate));
            }

            if (ForceDelivery != null)
            {
                p.Add(new KeyValuePair<string, string>("ForceDelivery", ForceDelivery.Value.ToString().ToLower()));
            }

            if (ProviderSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ProviderSid", ProviderSid.ToString()));
            }

            if (ContentRetention != null)
            {
                p.Add(new KeyValuePair<string, string>("ContentRetention", ContentRetention.ToString()));
            }

            if (AddressRetention != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressRetention", AddressRetention.ToString()));
            }

            if (SmartEncoded != null)
            {
                p.Add(new KeyValuePair<string, string>("SmartEncoded", SmartEncoded.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// Deletes a message record from your account
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The message to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathSid"> The message to delete </param>
        public DeleteMessageOptions(string pathSid)
        {
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
    /// Fetch a message belonging to the account used to make the request
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique message Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathSid"> Fetch by unique message Sid </param>
        public FetchMessageOptions(string pathSid)
        {
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
    /// Retrieve a list of messages belonging to the account used to make the request
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Filter by messages to this number
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Filter by from number
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSentBefore { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSent { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSentAfter { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (DateSent != null)
            {
                p.Add(new KeyValuePair<string, string>("DateSent", Serializers.DateTimeIso8601(DateSent)));
            }
            else
            {
                if (DateSentBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateSent<", Serializers.DateTimeIso8601(DateSentBefore)));
                }

                if (DateSentAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateSent>", Serializers.DateTimeIso8601(DateSentAfter)));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The message to redact
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathSid"> The message to redact </param>
        /// <param name="body"> The body </param>
        public UpdateMessageOptions(string pathSid, string body)
        {
            PathSid = pathSid;
            Body = body;
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

            return p;
        }
    }

}