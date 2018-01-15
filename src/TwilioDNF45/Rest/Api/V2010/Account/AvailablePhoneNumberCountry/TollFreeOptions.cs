/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry 
{

    /// <summary>
    /// ReadTollFreeOptions
    /// </summary>
    public class ReadTollFreeOptions : ReadOptions<TollFreeResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The country_code
        /// </summary>
        public string PathCountryCode { get; }
        /// <summary>
        /// The area_code
        /// </summary>
        public int? AreaCode { get; set; }
        /// <summary>
        /// The contains
        /// </summary>
        public string Contains { get; set; }
        /// <summary>
        /// The sms_enabled
        /// </summary>
        public bool? SmsEnabled { get; set; }
        /// <summary>
        /// The mms_enabled
        /// </summary>
        public bool? MmsEnabled { get; set; }
        /// <summary>
        /// The voice_enabled
        /// </summary>
        public bool? VoiceEnabled { get; set; }
        /// <summary>
        /// The exclude_all_address_required
        /// </summary>
        public bool? ExcludeAllAddressRequired { get; set; }
        /// <summary>
        /// The exclude_local_address_required
        /// </summary>
        public bool? ExcludeLocalAddressRequired { get; set; }
        /// <summary>
        /// The exclude_foreign_address_required
        /// </summary>
        public bool? ExcludeForeignAddressRequired { get; set; }
        /// <summary>
        /// The beta
        /// </summary>
        public bool? Beta { get; set; }
        /// <summary>
        /// The near_number
        /// </summary>
        public Types.PhoneNumber NearNumber { get; set; }
        /// <summary>
        /// The near_lat_long
        /// </summary>
        public string NearLatLong { get; set; }
        /// <summary>
        /// The distance
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// The in_postal_code
        /// </summary>
        public string InPostalCode { get; set; }
        /// <summary>
        /// The in_region
        /// </summary>
        public string InRegion { get; set; }
        /// <summary>
        /// The in_rate_center
        /// </summary>
        public string InRateCenter { get; set; }
        /// <summary>
        /// The in_lata
        /// </summary>
        public string InLata { get; set; }
        /// <summary>
        /// The in_locality
        /// </summary>
        public string InLocality { get; set; }
        /// <summary>
        /// The fax_enabled
        /// </summary>
        public bool? FaxEnabled { get; set; }

        /// <summary>
        /// Construct a new ReadTollFreeOptions
        /// </summary>
        /// <param name="pathCountryCode"> The country_code </param>
        public ReadTollFreeOptions(string pathCountryCode)
        {
            PathCountryCode = pathCountryCode;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AreaCode != null)
            {
                p.Add(new KeyValuePair<string, string>("AreaCode", AreaCode.Value.ToString()));
            }

            if (Contains != null)
            {
                p.Add(new KeyValuePair<string, string>("Contains", Contains));
            }

            if (SmsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsEnabled", SmsEnabled.Value.ToString().ToLower()));
            }

            if (MmsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MmsEnabled", MmsEnabled.Value.ToString().ToLower()));
            }

            if (VoiceEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceEnabled", VoiceEnabled.Value.ToString().ToLower()));
            }

            if (ExcludeAllAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeAllAddressRequired", ExcludeAllAddressRequired.Value.ToString().ToLower()));
            }

            if (ExcludeLocalAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeLocalAddressRequired", ExcludeLocalAddressRequired.Value.ToString().ToLower()));
            }

            if (ExcludeForeignAddressRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("ExcludeForeignAddressRequired", ExcludeForeignAddressRequired.Value.ToString().ToLower()));
            }

            if (Beta != null)
            {
                p.Add(new KeyValuePair<string, string>("Beta", Beta.Value.ToString().ToLower()));
            }

            if (NearNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("NearNumber", NearNumber.ToString()));
            }

            if (NearLatLong != null)
            {
                p.Add(new KeyValuePair<string, string>("NearLatLong", NearLatLong));
            }

            if (Distance != null)
            {
                p.Add(new KeyValuePair<string, string>("Distance", Distance.Value.ToString()));
            }

            if (InPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("InPostalCode", InPostalCode));
            }

            if (InRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("InRegion", InRegion));
            }

            if (InRateCenter != null)
            {
                p.Add(new KeyValuePair<string, string>("InRateCenter", InRateCenter));
            }

            if (InLata != null)
            {
                p.Add(new KeyValuePair<string, string>("InLata", InLata));
            }

            if (InLocality != null)
            {
                p.Add(new KeyValuePair<string, string>("InLocality", InLocality));
            }

            if (FaxEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("FaxEnabled", FaxEnabled.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}