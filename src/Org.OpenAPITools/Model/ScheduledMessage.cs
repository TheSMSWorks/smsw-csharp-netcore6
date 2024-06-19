/*
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed UK messages are refunded.
 *
 * The version of the OpenAPI document: 1.11.0
 * Contact: support@thesmsworks.co.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// the scheduled message content
    /// </summary>
    [DataContract]
    public partial class ScheduledMessage :  IEquatable<ScheduledMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessage" /> class.
        /// </summary>
        /// <param name="sender">The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters..</param>
        /// <param name="content">Message to be sent to the recipient.</param>
        /// <param name="destination">For single scheduled messages, the mobile number of the recipient.</param>
        /// <param name="destinations">For batch messages, the mobile numbers of each of the recipients.</param>
        /// <param name="schedule">date/time at which to send the batch. This is only used by the batch/schedule service..</param>
        public ScheduledMessage(string sender = default(string), string content = default(string), string destination = default(string), List<string> destinations = default(List<string>), string schedule = default(string))
        {
            this.Sender = sender;
            this.Content = content;
            this.Destination = destination;
            this.Destinations = destinations;
            this.Schedule = schedule;
        }

        /// <summary>
        /// The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.
        /// </summary>
        /// <value>The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Message to be sent to the recipient
        /// </summary>
        /// <value>Message to be sent to the recipient</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// For single scheduled messages, the mobile number of the recipient
        /// </summary>
        /// <value>For single scheduled messages, the mobile number of the recipient</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// For batch messages, the mobile numbers of each of the recipients
        /// </summary>
        /// <value>For batch messages, the mobile numbers of each of the recipients</value>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<string> Destinations { get; set; }

        /// <summary>
        /// date/time at which to send the batch. This is only used by the batch/schedule service.
        /// </summary>
        /// <value>date/time at which to send the batch. This is only used by the batch/schedule service.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledMessage {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledMessage);
        }

        /// <summary>
        /// Returns true if ScheduledMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
