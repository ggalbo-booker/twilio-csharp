/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Enqueue TwiML Noun
    /// </summary>
    public class Enqueue : TwiML 
    {
        /// <summary>
        /// Friendly name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Wait URL
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// Wait URL method
        /// </summary>
        public Twilio.Http.HttpMethod WaitUrlMethod { get; set; }
        /// <summary>
        /// TaskRouter Workflow SID
        /// </summary>
        public string WorkflowSid { get; set; }

        /// <summary>
        /// Create a new Enqueue
        /// </summary>
        /// <param name="name"> Friendly name, the body of the TwiML Element. </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="waitUrl"> Wait URL </param>
        /// <param name="waitUrlMethod"> Wait URL method </param>
        /// <param name="workflowSid"> TaskRouter Workflow SID </param>
        public Enqueue(string name = null, 
                       Uri action = null, 
                       Twilio.Http.HttpMethod method = null, 
                       Uri waitUrl = null, 
                       Twilio.Http.HttpMethod waitUrlMethod = null, 
                       string workflowSid = null) : base("Enqueue")
        {
            this.Name = name;
            this.Action = action;
            this.Method = method;
            this.WaitUrl = waitUrl;
            this.WaitUrlMethod = waitUrlMethod;
            this.WorkflowSid = workflowSid;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Name != null ? this.Name : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", this.Action.AbsoluteUri.TrimEnd('/')));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.WaitUrl != null)
            {
                attributes.Add(new XAttribute("waitUrl", this.WaitUrl.AbsoluteUri.TrimEnd('/')));
            }
            if (this.WaitUrlMethod != null)
            {
                attributes.Add(new XAttribute("waitUrlMethod", this.WaitUrlMethod.ToString()));
            }
            if (this.WorkflowSid != null)
            {
                attributes.Add(new XAttribute("workflowSid", this.WorkflowSid));
            }
            return attributes;
        }

        /// <summary>
        /// Append a <Task/> element as a child of this element
        /// </summary>
        /// <param name="task"> A Task instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Enqueue Task(Task task)
        {
            this.Append(task);
            return this;
        }

        /// <summary>
        /// Create a new <Task/> element and append it as a child of this element.
        /// </summary>
        /// <param name="body"> TaskRouter task attributes, the body of the TwiML Element. Also accepts stringified object
        ///            </param>
        /// <param name="priority"> Task priority </param>
        /// <param name="timeout"> Timeout associated with task </param>
        public Enqueue Task(string body = null, int? priority = null, int? timeout = null)
        {
            var newChild = new Task(body, priority, timeout);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Enqueue Append(TwiML childElem)
        {
            return (Enqueue) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Enqueue SetOption(string key, object value)
        {
            return (Enqueue) base.SetOption(key, value);
        }
    }

}