/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Echo TwiML Verb
    /// </summary>
    public class Echo : TwiML 
    {
        /// <summary>
        /// Create a new Echo
        /// </summary>
        public Echo() : base("Echo")
        {
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Echo Append(TwiML childElem)
        {
            return (Echo) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Echo SetOption(string key, object value)
        {
            return (Echo) base.SetOption(key, value);
        }
    }

}