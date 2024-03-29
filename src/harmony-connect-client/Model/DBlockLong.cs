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
    /// A single Directory block from the factom blockchain.
    /// </summary>
    [DataContract]
    public partial class DBlockLong :  IEquatable<DBlockLong>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBlockLong" /> class.
        /// </summary>
        /// <param name="height">The height of a directory block indicates how many blocks were created before this block. This is used to identify blocks in the blockchain..</param>
        /// <param name="startedAt">The timestamp for when this block was built. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;.</param>
        /// <param name="keymr">The Key Merkle Root for this block..</param>
        /// <param name="btcAnchorEntry">btcAnchorEntry.</param>
        /// <param name="btcBlockHash">The bitcoin block hash for the bitcoin anchor that matches this directory block..</param>
        /// <param name="btcTransaction">The bitcoin transaction ID for the transaction that includes the anchor message..</param>
        /// <param name="prev">prev.</param>
        /// <param name="next">next.</param>
        /// <param name="ablock">ablock.</param>
        /// <param name="ecblock">ecblock.</param>
        /// <param name="fblock">fblock.</param>
        /// <param name="eblocks">The entry blocks contained in this directory block..</param>
        public DBlockLong(string height = default(string), string startedAt = default(string), List<string> keymr = default(List<string>), DBlockLongBtcAnchorEntry btcAnchorEntry = default(DBlockLongBtcAnchorEntry), string btcBlockHash = default(string), string btcTransaction = default(string), DBlockLongPrev prev = default(DBlockLongPrev), DBlockLongNext next = default(DBlockLongNext), DBlockLongAblock ablock = default(DBlockLongAblock), DBlockLongEcblock ecblock = default(DBlockLongEcblock), DBlockLongFblock fblock = default(DBlockLongFblock), List<DBlockLongEblocks> eblocks = default(List<DBlockLongEblocks>))
        {
            this.Height = height;
            this.StartedAt = startedAt;
            this.Keymr = keymr;
            this.BtcAnchorEntry = btcAnchorEntry;
            this.BtcBlockHash = btcBlockHash;
            this.BtcTransaction = btcTransaction;
            this.Prev = prev;
            this.Next = next;
            this.Ablock = ablock;
            this.Ecblock = ecblock;
            this.Fblock = fblock;
            this.Eblocks = eblocks;
        }
        
        /// <summary>
        /// The height of a directory block indicates how many blocks were created before this block. This is used to identify blocks in the blockchain.
        /// </summary>
        /// <value>The height of a directory block indicates how many blocks were created before this block. This is used to identify blocks in the blockchain.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }

        /// <summary>
        /// The timestamp for when this block was built. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for when this block was built. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// The Key Merkle Root for this block.
        /// </summary>
        /// <value>The Key Merkle Root for this block.</value>
        [DataMember(Name="keymr", EmitDefaultValue=false)]
        public List<string> Keymr { get; set; }

        /// <summary>
        /// Gets or Sets BtcAnchorEntry
        /// </summary>
        [DataMember(Name="btc_anchor_entry", EmitDefaultValue=false)]
        public DBlockLongBtcAnchorEntry BtcAnchorEntry { get; set; }

        /// <summary>
        /// The bitcoin block hash for the bitcoin anchor that matches this directory block.
        /// </summary>
        /// <value>The bitcoin block hash for the bitcoin anchor that matches this directory block.</value>
        [DataMember(Name="btc_block_hash", EmitDefaultValue=false)]
        public string BtcBlockHash { get; set; }

        /// <summary>
        /// The bitcoin transaction ID for the transaction that includes the anchor message.
        /// </summary>
        /// <value>The bitcoin transaction ID for the transaction that includes the anchor message.</value>
        [DataMember(Name="btc_transaction", EmitDefaultValue=false)]
        public string BtcTransaction { get; set; }

        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public DBlockLongPrev Prev { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public DBlockLongNext Next { get; set; }

        /// <summary>
        /// Gets or Sets Ablock
        /// </summary>
        [DataMember(Name="ablock", EmitDefaultValue=false)]
        public DBlockLongAblock Ablock { get; set; }

        /// <summary>
        /// Gets or Sets Ecblock
        /// </summary>
        [DataMember(Name="ecblock", EmitDefaultValue=false)]
        public DBlockLongEcblock Ecblock { get; set; }

        /// <summary>
        /// Gets or Sets Fblock
        /// </summary>
        [DataMember(Name="fblock", EmitDefaultValue=false)]
        public DBlockLongFblock Fblock { get; set; }

        /// <summary>
        /// The entry blocks contained in this directory block.
        /// </summary>
        /// <value>The entry blocks contained in this directory block.</value>
        [DataMember(Name="eblocks", EmitDefaultValue=false)]
        public List<DBlockLongEblocks> Eblocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBlockLong {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Keymr: ").Append(Keymr).Append("\n");
            sb.Append("  BtcAnchorEntry: ").Append(BtcAnchorEntry).Append("\n");
            sb.Append("  BtcBlockHash: ").Append(BtcBlockHash).Append("\n");
            sb.Append("  BtcTransaction: ").Append(BtcTransaction).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Ablock: ").Append(Ablock).Append("\n");
            sb.Append("  Ecblock: ").Append(Ecblock).Append("\n");
            sb.Append("  Fblock: ").Append(Fblock).Append("\n");
            sb.Append("  Eblocks: ").Append(Eblocks).Append("\n");
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
            return this.Equals(input as DBlockLong);
        }

        /// <summary>
        /// Returns true if DBlockLong instances are equal
        /// </summary>
        /// <param name="input">Instance of DBlockLong to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DBlockLong input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Keymr == input.Keymr ||
                    this.Keymr != null &&
                    this.Keymr.SequenceEqual(input.Keymr)
                ) && 
                (
                    this.BtcAnchorEntry == input.BtcAnchorEntry ||
                    (this.BtcAnchorEntry != null &&
                    this.BtcAnchorEntry.Equals(input.BtcAnchorEntry))
                ) && 
                (
                    this.BtcBlockHash == input.BtcBlockHash ||
                    (this.BtcBlockHash != null &&
                    this.BtcBlockHash.Equals(input.BtcBlockHash))
                ) && 
                (
                    this.BtcTransaction == input.BtcTransaction ||
                    (this.BtcTransaction != null &&
                    this.BtcTransaction.Equals(input.BtcTransaction))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Ablock == input.Ablock ||
                    (this.Ablock != null &&
                    this.Ablock.Equals(input.Ablock))
                ) && 
                (
                    this.Ecblock == input.Ecblock ||
                    (this.Ecblock != null &&
                    this.Ecblock.Equals(input.Ecblock))
                ) && 
                (
                    this.Fblock == input.Fblock ||
                    (this.Fblock != null &&
                    this.Fblock.Equals(input.Fblock))
                ) && 
                (
                    this.Eblocks == input.Eblocks ||
                    this.Eblocks != null &&
                    this.Eblocks.SequenceEqual(input.Eblocks)
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
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Keymr != null)
                    hashCode = hashCode * 59 + this.Keymr.GetHashCode();
                if (this.BtcAnchorEntry != null)
                    hashCode = hashCode * 59 + this.BtcAnchorEntry.GetHashCode();
                if (this.BtcBlockHash != null)
                    hashCode = hashCode * 59 + this.BtcBlockHash.GetHashCode();
                if (this.BtcTransaction != null)
                    hashCode = hashCode * 59 + this.BtcTransaction.GetHashCode();
                if (this.Prev != null)
                    hashCode = hashCode * 59 + this.Prev.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Ablock != null)
                    hashCode = hashCode * 59 + this.Ablock.GetHashCode();
                if (this.Ecblock != null)
                    hashCode = hashCode * 59 + this.Ecblock.GetHashCode();
                if (this.Fblock != null)
                    hashCode = hashCode * 59 + this.Fblock.GetHashCode();
                if (this.Eblocks != null)
                    hashCode = hashCode * 59 + this.Eblocks.GetHashCode();
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
