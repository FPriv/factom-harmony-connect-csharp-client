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
    /// CommitLink
    /// </summary>
    [DataContract]
    public partial class CommitLink :  IEquatable<CommitLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommitLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitLink" /> class.
        /// </summary>
        /// <param name="hash">The SHA256 Hash of this commit. (required).</param>
        /// <param name="createdAt">The timestamp for when this commit was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; (required).</param>
        /// <param name="href">An API link to retreive all of the information about this commit. (required).</param>
        public CommitLink(string hash = default(string), string createdAt = default(string), string href = default(string))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new InvalidDataException("hash is a required property for CommitLink and cannot be null");
            }
            else
            {
                this.Hash = hash;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for CommitLink and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "href" is required (not null)
            if (href == null)
            {
                throw new InvalidDataException("href is a required property for CommitLink and cannot be null");
            }
            else
            {
                this.Href = href;
            }
        }
        
        /// <summary>
        /// The SHA256 Hash of this commit.
        /// </summary>
        /// <value>The SHA256 Hash of this commit.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// The timestamp for when this commit was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for when this commit was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// An API link to retreive all of the information about this commit.
        /// </summary>
        /// <value>An API link to retreive all of the information about this commit.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitLink {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as CommitLink);
        }

        /// <summary>
        /// Returns true if CommitLink instances are equal
        /// </summary>
        /// <param name="input">Instance of CommitLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommitLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
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