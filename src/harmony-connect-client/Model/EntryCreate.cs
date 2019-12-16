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
    /// This information will be used to create a new entry.
    /// </summary>
    [DataContract]
    public partial class EntryCreate :  IEquatable<EntryCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntryCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryCreate" /> class.
        /// </summary>
        /// <param name="externalIds">Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs should be sent in Base64. (required).</param>
        /// <param name="content">This is the data that will be stored directly on the blockchain. Please be sure that no private information is entered here. Content should be sent in Base64 format. (required).</param>
        /// <param name="callbackUrl">The address you&#39;d like the callback to be sent to. If this is not specified, callbacks will not activate..</param>
        /// <param name="callbackStages">The immutability stages you&#39;d like to be notified about. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;.</param>
        public EntryCreate(List<string> externalIds = default(List<string>), string content = default(string), string callbackUrl = default(string), List<string> callbackStages = default(List<string>))
        {
            // to ensure "externalIds" is required (not null)
            if (externalIds == null)
            {
                throw new InvalidDataException("externalIds is a required property for EntryCreate and cannot be null");
            }
            else
            {
                this.ExternalIds = externalIds;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for EntryCreate and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.CallbackUrl = callbackUrl;
            this.CallbackStages = callbackStages;
        }
        
        /// <summary>
        /// Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs should be sent in Base64.
        /// </summary>
        /// <value>Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs should be sent in Base64.</value>
        [DataMember(Name="external_ids", EmitDefaultValue=false)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// This is the data that will be stored directly on the blockchain. Please be sure that no private information is entered here. Content should be sent in Base64 format.
        /// </summary>
        /// <value>This is the data that will be stored directly on the blockchain. Please be sure that no private information is entered here. Content should be sent in Base64 format.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// The address you&#39;d like the callback to be sent to. If this is not specified, callbacks will not activate.
        /// </summary>
        /// <value>The address you&#39;d like the callback to be sent to. If this is not specified, callbacks will not activate.</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The immutability stages you&#39;d like to be notified about. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;
        /// </summary>
        /// <value>The immutability stages you&#39;d like to be notified about. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;</value>
        [DataMember(Name="callback_stages", EmitDefaultValue=false)]
        public List<string> CallbackStages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntryCreate {\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CallbackStages: ").Append(CallbackStages).Append("\n");
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
            return this.Equals(input as EntryCreate);
        }

        /// <summary>
        /// Returns true if EntryCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of EntryCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntryCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalIds == input.ExternalIds ||
                    this.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(input.ExternalIds)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.CallbackStages == input.CallbackStages ||
                    this.CallbackStages != null &&
                    this.CallbackStages.SequenceEqual(input.CallbackStages)
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
                if (this.ExternalIds != null)
                    hashCode = hashCode * 59 + this.ExternalIds.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.CallbackStages != null)
                    hashCode = hashCode * 59 + this.CallbackStages.GetHashCode();
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