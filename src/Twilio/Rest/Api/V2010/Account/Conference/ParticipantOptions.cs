/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    /// <summary>
    /// Fetch an instance of a participant
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> The call_sid </param>
        public FetchParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
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
    /// Update the properties of this participant
    /// </summary>
    public class UpdateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// Indicates if the participant should be muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// The hold
        /// </summary>
        public bool? Hold { get; set; }
        /// <summary>
        /// The hold_url
        /// </summary>
        public Uri HoldUrl { get; set; }
        /// <summary>
        /// The hold_method
        /// </summary>
        public Twilio.Http.HttpMethod HoldMethod { get; set; }
        /// <summary>
        /// The announce_url
        /// </summary>
        public Uri AnnounceUrl { get; set; }
        /// <summary>
        /// The announce_method
        /// </summary>
        public Twilio.Http.HttpMethod AnnounceMethod { get; set; }

        /// <summary>
        /// Construct a new UpdateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> The call_sid </param>
        public UpdateParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (HoldUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldUrl", HoldUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (HoldMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldMethod", HoldMethod.ToString()));
            }

            if (AnnounceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceUrl", AnnounceUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (AnnounceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceMethod", AnnounceMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateParticipantOptions
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The conference_sid
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The from
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// The to
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The status_callback_event
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// The timeout
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// The record
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// The muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// The beep
        /// </summary>
        public string Beep { get; set; }
        /// <summary>
        /// The start_conference_on_enter
        /// </summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>
        /// The end_conference_on_exit
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// The wait_url
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// The wait_method
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// The early_media
        /// </summary>
        public bool? EarlyMedia { get; set; }
        /// <summary>
        /// The max_participants
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// The conference_record
        /// </summary>
        public string ConferenceRecord { get; set; }
        /// <summary>
        /// The conference_trim
        /// </summary>
        public string ConferenceTrim { get; set; }
        /// <summary>
        /// The conference_status_callback
        /// </summary>
        public Uri ConferenceStatusCallback { get; set; }
        /// <summary>
        /// The conference_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceStatusCallbackMethod { get; set; }
        /// <summary>
        /// The conference_status_callback_event
        /// </summary>
        public List<string> ConferenceStatusCallbackEvent { get; set; }
        /// <summary>
        /// The recording_channels
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The recording_status_callback
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// The recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The sip_auth_username
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The sip_auth_password
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// The region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The conference_recording_status_callback
        /// </summary>
        public Uri ConferenceRecordingStatusCallback { get; set; }
        /// <summary>
        /// The conference_recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceRecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The recording_status_callback_event
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// The conference_recording_status_callback_event
        /// </summary>
        public List<string> ConferenceRecordingStatusCallbackEvent { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="from"> The from </param>
        /// <param name="to"> The to </param>
        public CreateParticipantOptions(string pathConferenceSid, Types.PhoneNumber from, Types.PhoneNumber to)
        {
            PathConferenceSid = pathConferenceSid;
            From = from;
            To = to;
            StatusCallbackEvent = new List<string>();
            ConferenceStatusCallbackEvent = new List<string>();
            RecordingStatusCallbackEvent = new List<string>();
            ConferenceRecordingStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.AbsoluteUri.TrimEnd('/')));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.Value.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Beep != null)
            {
                p.Add(new KeyValuePair<string, string>("Beep", Beep));
            }

            if (StartConferenceOnEnter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartConferenceOnEnter", StartConferenceOnEnter.Value.ToString().ToLower()));
            }

            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString().ToLower()));
            }

            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", WaitUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }

            if (EarlyMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("EarlyMedia", EarlyMedia.Value.ToString().ToLower()));
            }

            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.Value.ToString()));
            }

            if (ConferenceRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecord", ConferenceRecord));
            }

            if (ConferenceTrim != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceTrim", ConferenceTrim));
            }

            if (ConferenceStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallback", ConferenceStatusCallback.AbsoluteUri.TrimEnd('/')));
            }

            if (ConferenceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallbackMethod", ConferenceStatusCallbackMethod.ToString()));
            }

            if (ConferenceStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceStatusCallbackEvent", prop)));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback.AbsoluteUri.TrimEnd('/')));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }

            if (ConferenceRecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallback", ConferenceRecordingStatusCallback.AbsoluteUri.TrimEnd('/')));
            }

            if (ConferenceRecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackMethod", ConferenceRecordingStatusCallbackMethod.ToString()));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            if (ConferenceRecordingStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceRecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackEvent", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// Kick a participant from a given conference
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="pathCallSid"> The call_sid </param>
        public DeleteParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
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
    /// Retrieve a list of participants belonging to the account used to make the request
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The string that uniquely identifies this conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Filter by muted participants
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// The hold
        /// </summary>
        public bool? Hold { get; set; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The string that uniquely identifies this conference </param>
        public ReadParticipantOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}