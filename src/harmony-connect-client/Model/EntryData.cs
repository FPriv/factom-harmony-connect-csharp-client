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
    /// EntryData
    /// </summary>
    [DataContract]
    public partial class EntryData :  IEquatable<EntryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryData" /> class.
        /// </summary>
        /// <param name="entryHash">The unique identitfier of the entry. (required).</param>
        /// <param name="chain">chain (required).</param>
        /// <param name="createdAt">The time when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60;.</param>
        /// <param name="externalIds">Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs are returned in Base64. (required).</param>
        /// <param name="content">This is the data that is stored by the entry. Content will be sent in Base64 format. (required).</param>
        /// <param name="stage">The level of immutability that this entry has reached. (required).</param>
        /// <param name="dblock">dblock.</param>
        /// <param name="eblock">eblock.</param>
        public EntryData(string entryHash = default(string), EntryListChain chain = default(EntryListChain), string createdAt = default(string), List<string> externalIds = default(List<string>), string content = default(string), string stage = default(string), EntryDataDblock dblock = default(EntryDataDblock), EntryDataEblock eblock = default(EntryDataEblock))
        {
            // to ensure "entryHash" is required (not null)
            if (entryHash == null)
            {
                throw new InvalidDataException("entryHash is a required property for EntryData and cannot be null");
            }
            else
            {
                this.EntryHash = entryHash;
            }
            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new InvalidDataException("chain is a required property for EntryData and cannot be null");
            }
            else
            {
                this.Chain = chain;
            }
            // to ensure "externalIds" is required (not null)
            if (externalIds == null)
            {
                throw new InvalidDataException("externalIds is a required property for EntryData and cannot be null");
            }
            else
            {
                this.ExternalIds = externalIds;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for EntryData and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "stage" is required (not null)
            if (stage == null)
            {
                throw new InvalidDataException("stage is a required property for EntryData and cannot be null");
            }
            else
            {
                this.Stage = stage;
            }
            this.CreatedAt = createdAt;
            this.Dblock = dblock;
            this.Eblock = eblock;
        }
        
        /// <summary>
        /// The unique identitfier of the entry.
        /// </summary>
        /// <value>The unique identitfier of the entry.</value>
        [DataMember(Name="entry_hash", EmitDefaultValue=false)]
        public string EntryHash { get; set; }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public EntryListChain Chain { get; set; }

        /// <summary>
        /// The time when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60;
        /// </summary>
        /// <value>The time when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs are returned in Base64.
        /// </summary>
        /// <value>Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs are returned in Base64.</value>
        [DataMember(Name="external_ids", EmitDefaultValue=false)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// This is the data that is stored by the entry. Content will be sent in Base64 format.
        /// </summary>
        /// <value>This is the data that is stored by the entry. Content will be sent in Base64 format.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// The level of immutability that this entry has reached.
        /// </summary>
        /// <value>The level of immutability that this entry has reached.</value>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }

        /// <summary>
        /// Gets or Sets Dblock
        /// </summary>
        [DataMember(Name="dblock", EmitDefaultValue=false)]
        public EntryDataDblock Dblock { get; set; }

        /// <summary>
        /// Gets or Sets Eblock
        /// </summary>
        [DataMember(Name="eblock", EmitDefaultValue=false)]
        public EntryDataEblock Eblock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntryData {\n");
            sb.Append("  EntryHash: ").Append(EntryHash).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Dblock: ").Append(Dblock).Append("\n");
            sb.Append("  Eblock: ").Append(Eblock).Append("\n");
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
            return this.Equals(input as EntryData);
        }

        /// <summary>
        /// Returns true if EntryData instances are equal
        /// </summary>
        /// <param name="input">Instance of EntryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntryData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntryHash == input.EntryHash ||
                    (this.EntryHash != null &&
                    this.EntryHash.Equals(input.EntryHash))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
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
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Dblock == input.Dblock ||
                    (this.Dblock != null &&
                    this.Dblock.Equals(input.Dblock))
                ) && 
                (
                    this.Eblock == input.Eblock ||
                    (this.Eblock != null &&
                    this.Eblock.Equals(input.Eblock))
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
                if (this.EntryHash != null)
                    hashCode = hashCode * 59 + this.EntryHash.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExternalIds != null)
                    hashCode = hashCode * 59 + this.ExternalIds.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Dblock != null)
                    hashCode = hashCode * 59 + this.Dblock.GetHashCode();
                if (this.Eblock != null)
                    hashCode = hashCode * 59 + this.Eblock.GetHashCode();
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