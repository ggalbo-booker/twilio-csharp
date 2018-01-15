/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Marketplace.InstalledAddOn 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch an instance of an Extension for the Installed Add-on.
    /// </summary>
    public class FetchInstalledAddOnExtensionOptions : IOptions<InstalledAddOnExtensionResource> 
    {
        /// <summary>
        /// The installed_add_on_sid
        /// </summary>
        public string PathInstalledAddOnSid { get; }
        /// <summary>
        /// The unique Extension Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInstalledAddOnExtensionOptions
        /// </summary>
        /// <param name="pathInstalledAddOnSid"> The installed_add_on_sid </param>
        /// <param name="pathSid"> The unique Extension Sid </param>
        public FetchInstalledAddOnExtensionOptions(string pathInstalledAddOnSid, string pathSid)
        {
            PathInstalledAddOnSid = pathInstalledAddOnSid;
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Update an Extension for an Add-on installation.
    /// </summary>
    public class UpdateInstalledAddOnExtensionOptions : IOptions<InstalledAddOnExtensionResource> 
    {
        /// <summary>
        /// The installed_add_on_sid
        /// </summary>
        public string PathInstalledAddOnSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A Boolean indicating if the Extension will be invoked
        /// </summary>
        public bool? Enabled { get; }

        /// <summary>
        /// Construct a new UpdateInstalledAddOnExtensionOptions
        /// </summary>
        /// <param name="pathInstalledAddOnSid"> The installed_add_on_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="enabled"> A Boolean indicating if the Extension will be invoked </param>
        public UpdateInstalledAddOnExtensionOptions(string pathInstalledAddOnSid, string pathSid, bool? enabled)
        {
            PathInstalledAddOnSid = pathInstalledAddOnSid;
            PathSid = pathSid;
            Enabled = enabled;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of Extensions for the Installed Add-on.
    /// </summary>
    public class ReadInstalledAddOnExtensionOptions : ReadOptions<InstalledAddOnExtensionResource> 
    {
        /// <summary>
        /// The installed_add_on_sid
        /// </summary>
        public string PathInstalledAddOnSid { get; }

        /// <summary>
        /// Construct a new ReadInstalledAddOnExtensionOptions
        /// </summary>
        /// <param name="pathInstalledAddOnSid"> The installed_add_on_sid </param>
        public ReadInstalledAddOnExtensionOptions(string pathInstalledAddOnSid)
        {
            PathInstalledAddOnSid = pathInstalledAddOnSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}