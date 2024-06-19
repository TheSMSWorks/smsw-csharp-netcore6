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
    /// MessageResponseFailurereason
    /// </summary>
    [DataContract]
    public partial class MessageResponseFailurereason :  IEquatable<MessageResponseFailurereason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponseFailurereason" /> class.
        /// </summary>
        /// <param name="code">Numeric code that defines the error. Integer..</param>
        /// <param name="details">details.</param>
        /// <param name="permanent">permanent.</param>
        public MessageResponseFailurereason(decimal code = default(decimal), string details = default(string), bool permanent = default(bool))
        {
            this.Code = code;
            this.Details = details;
            this.Permanent = permanent;
        }

        /// <summary>
        /// Numeric code that defines the error. Integer.
        /// </summary>
        /// <value>Numeric code that defines the error. Integer.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public decimal Code { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name="permanent", EmitDefaultValue=false)]
        public bool Permanent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResponseFailurereason {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
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
            return this.Equals(input as MessageResponseFailurereason);
        }

        /// <summary>
        /// Returns true if MessageResponseFailurereason instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResponseFailurereason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResponseFailurereason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    (this.Permanent != null &&
                    this.Permanent.Equals(input.Permanent))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Permanent != null)
                    hashCode = hashCode * 59 + this.Permanent.GetHashCode();
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
