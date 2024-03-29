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
    /// An object that contains the Entry Hash (ID) and a URL for the entry.
    /// </summary>
    [DataContract]
    public partial class DBlockLongBtcAnchorEntry :  IEquatable<DBlockLongBtcAnchorEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBlockLongBtcAnchorEntry" /> class.
        /// </summary>
        /// <param name="entryHash">The unique identitfier of the entry..</param>
        /// <param name="chain">chain.</param>
        /// <param name="createdAt">The time at which this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;.</param>
        /// <param name="href">An API link to retrieve all information about this entry..</param>
        public DBlockLongBtcAnchorEntry(string entryHash = default(string), DBlockLongBtcAnchorEntryChain chain = default(DBlockLongBtcAnchorEntryChain), string createdAt = default(string), string href = default(string))
        {
            this.EntryHash = entryHash;
            this.Chain = chain;
            this.CreatedAt = createdAt;
            this.Href = href;
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
        public DBlockLongBtcAnchorEntryChain Chain { get; set; }

        /// <summary>
        /// The time at which this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The time at which this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// An API link to retrieve all information about this entry.
        /// </summary>
        /// <value>An API link to retrieve all information about this entry.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBlockLongBtcAnchorEntry {\n");
            sb.Append("  EntryHash: ").Append(EntryHash).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as DBlockLongBtcAnchorEntry);
        }

        /// <summary>
        /// Returns true if DBlockLongBtcAnchorEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DBlockLongBtcAnchorEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DBlockLongBtcAnchorEntry input)
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
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
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
