using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Marketplace.AvailableAddOn 
{

    /// <summary>
    /// Fetch an instance of an Extension for the Available Add-on.
    /// </summary>
    public class FetchAvailableAddOnExtensionOptions : IOptions<AvailableAddOnExtensionResource> 
    {
        /// <summary>
        /// The available_add_on_sid
        /// </summary>
        public string PathAvailableAddOnSid { get; }
        /// <summary>
        /// The unique Extension Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchAvailableAddOnExtensionOptions
        /// </summary>
        ///
        /// <param name="pathAvailableAddOnSid"> The available_add_on_sid </param>
        /// <param name="pathSid"> The unique Extension Sid </param>
        public FetchAvailableAddOnExtensionOptions(string pathAvailableAddOnSid, string pathSid)
        {
            PathAvailableAddOnSid = pathAvailableAddOnSid;
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
    /// Retrieve a list of Extensions for the Available Add-on.
    /// </summary>
    public class ReadAvailableAddOnExtensionOptions : ReadOptions<AvailableAddOnExtensionResource> 
    {
        /// <summary>
        /// The available_add_on_sid
        /// </summary>
        public string PathAvailableAddOnSid { get; }
    
        /// <summary>
        /// Construct a new ReadAvailableAddOnExtensionOptions
        /// </summary>
        ///
        /// <param name="pathAvailableAddOnSid"> The available_add_on_sid </param>
        public ReadAvailableAddOnExtensionOptions(string pathAvailableAddOnSid)
        {
            PathAvailableAddOnSid = pathAvailableAddOnSid;
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