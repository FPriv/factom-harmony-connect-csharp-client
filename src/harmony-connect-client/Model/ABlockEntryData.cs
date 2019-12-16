/* 
 * Harmony Connect
 *
 * An easy to use API that helps you access the Factom blockchain.
 *
 * OpenAPI spec version: 1.0.19
 * Contact: harmony-support@factom.com
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
using OpenAPIDateConverter = harmony-connect-client.Client.OpenAPIDateConverter;

namespace harmony-connect-client.Model
{
    /// <summary>
    /// ABlockEntryData
    /// </summary>
    [DataContract]
    public partial class ABlockEntryData :  IEquatable<ABlockEntryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ABlockEntryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ABlockEntryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ABlockEntryData" /> class.
        /// </summary>
        /// <param name="content">The content of the admin block entry. (required).</param>
        /// <param name="createdAt">The timestamp for when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; (required).</param>
        /// <param name="ablock">ablock (required).</param>
        public ABlockEntryData(string content = default(string), string createdAt = default(string), ABlockShort ablock = default(ABlockShort))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for ABlockEntryData and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for ABlockEntryData and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "ablock" is required (not null)
            if (ablock == null)
            {
                throw new InvalidDataException("ablock is a required property for ABlockEntryData and cannot be null");
            }
            else
            {
                this.Ablock = ablock;
            }
        }
        
        /// <summary>
        /// The content of the admin block entry.
        /// </summary>
        /// <value>The content of the admin block entry.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// The timestamp for when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Ablock
        /// </summary>
        [DataMember(Name="ablock", EmitDefaultValue=false)]
        public ABlockShort Ablock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ABlockEntryData {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Ablock: ").Append(Ablock).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ABlockEntryData);
        }

        /// <summary>
        /// Returns true if ABlockEntryData instances are equal
        /// </summary>
        /// <param name="input">Instance of ABlockEntryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ABlockEntryData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Ablock == input.Ablock ||
                    (this.Ablock != null &&
                    this.Ablock.Equals(input.Ablock))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Ablock != null)
                    hashCode = hashCode * 59 + this.Ablock.GetHashCode();
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