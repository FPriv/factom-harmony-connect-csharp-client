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
    /// Contains the receipt information for the desired entry.
    /// </summary>
    [DataContract]
    public partial class ReceiptLongData :  IEquatable<ReceiptLongData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptLongData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReceiptLongData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptLongData" /> class.
        /// </summary>
        /// <param name="createdAt">The timestamp for this entry. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; (required).</param>
        /// <param name="entrySerialized">The raw data that makes up the entry. (required).</param>
        /// <param name="entryHash">The unique identitfier of the entry. (required).</param>
        /// <param name="merkleBranch">The branch of the merkle tree that represents this entry. Presented as an array of Merkle nodes. (required).</param>
        /// <param name="eblock">eblock (required).</param>
        /// <param name="dblock">dblock (required).</param>
        public ReceiptLongData(string createdAt = default(string), string entrySerialized = default(string), string entryHash = default(string), List<MerkleNode> merkleBranch = default(List<MerkleNode>), EBlockLink eblock = default(EBlockLink), DBlockLink dblock = default(DBlockLink))
        {
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "entrySerialized" is required (not null)
            if (entrySerialized == null)
            {
                throw new InvalidDataException("entrySerialized is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.EntrySerialized = entrySerialized;
            }
            // to ensure "entryHash" is required (not null)
            if (entryHash == null)
            {
                throw new InvalidDataException("entryHash is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.EntryHash = entryHash;
            }
            // to ensure "merkleBranch" is required (not null)
            if (merkleBranch == null)
            {
                throw new InvalidDataException("merkleBranch is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.MerkleBranch = merkleBranch;
            }
            // to ensure "eblock" is required (not null)
            if (eblock == null)
            {
                throw new InvalidDataException("eblock is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.Eblock = eblock;
            }
            // to ensure "dblock" is required (not null)
            if (dblock == null)
            {
                throw new InvalidDataException("dblock is a required property for ReceiptLongData and cannot be null");
            }
            else
            {
                this.Dblock = dblock;
            }
        }
        
        /// <summary>
        /// The timestamp for this entry. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for this entry. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The raw data that makes up the entry.
        /// </summary>
        /// <value>The raw data that makes up the entry.</value>
        [DataMember(Name="entry_serialized", EmitDefaultValue=false)]
        public string EntrySerialized { get; set; }

        /// <summary>
        /// The unique identitfier of the entry.
        /// </summary>
        /// <value>The unique identitfier of the entry.</value>
        [DataMember(Name="entry_hash", EmitDefaultValue=false)]
        public string EntryHash { get; set; }

        /// <summary>
        /// The branch of the merkle tree that represents this entry. Presented as an array of Merkle nodes.
        /// </summary>
        /// <value>The branch of the merkle tree that represents this entry. Presented as an array of Merkle nodes.</value>
        [DataMember(Name="merkle_branch", EmitDefaultValue=false)]
        public List<MerkleNode> MerkleBranch { get; set; }

        /// <summary>
        /// Gets or Sets Eblock
        /// </summary>
        [DataMember(Name="eblock", EmitDefaultValue=false)]
        public EBlockLink Eblock { get; set; }

        /// <summary>
        /// Gets or Sets Dblock
        /// </summary>
        [DataMember(Name="dblock", EmitDefaultValue=false)]
        public DBlockLink Dblock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceiptLongData {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EntrySerialized: ").Append(EntrySerialized).Append("\n");
            sb.Append("  EntryHash: ").Append(EntryHash).Append("\n");
            sb.Append("  MerkleBranch: ").Append(MerkleBranch).Append("\n");
            sb.Append("  Eblock: ").Append(Eblock).Append("\n");
            sb.Append("  Dblock: ").Append(Dblock).Append("\n");
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
            return this.Equals(input as ReceiptLongData);
        }

        /// <summary>
        /// Returns true if ReceiptLongData instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptLongData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptLongData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EntrySerialized == input.EntrySerialized ||
                    (this.EntrySerialized != null &&
                    this.EntrySerialized.Equals(input.EntrySerialized))
                ) && 
                (
                    this.EntryHash == input.EntryHash ||
                    (this.EntryHash != null &&
                    this.EntryHash.Equals(input.EntryHash))
                ) && 
                (
                    this.MerkleBranch == input.MerkleBranch ||
                    this.MerkleBranch != null &&
                    this.MerkleBranch.SequenceEqual(input.MerkleBranch)
                ) && 
                (
                    this.Eblock == input.Eblock ||
                    (this.Eblock != null &&
                    this.Eblock.Equals(input.Eblock))
                ) && 
                (
                    this.Dblock == input.Dblock ||
                    (this.Dblock != null &&
                    this.Dblock.Equals(input.Dblock))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EntrySerialized != null)
                    hashCode = hashCode * 59 + this.EntrySerialized.GetHashCode();
                if (this.EntryHash != null)
                    hashCode = hashCode * 59 + this.EntryHash.GetHashCode();
                if (this.MerkleBranch != null)
                    hashCode = hashCode * 59 + this.MerkleBranch.GetHashCode();
                if (this.Eblock != null)
                    hashCode = hashCode * 59 + this.Eblock.GetHashCode();
                if (this.Dblock != null)
                    hashCode = hashCode * 59 + this.Dblock.GetHashCode();
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
