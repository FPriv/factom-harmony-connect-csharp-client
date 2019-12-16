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
    /// A single factoid transaction.
    /// </summary>
    [DataContract]
    public partial class TransactionLinkShort :  IEquatable<TransactionLinkShort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLinkShort" /> class.
        /// </summary>
        /// <param name="txId">The transaction ID for this transaction..</param>
        /// <param name="createdAt">The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;.</param>
        /// <param name="href">An API link to obtain all data for this transaction..</param>
        /// <param name="ecRate">The price of an entry credit at the time of this transaction..</param>
        public TransactionLinkShort(string txId = default(string), string createdAt = default(string), string href = default(string), string ecRate = default(string))
        {
            this.TxId = txId;
            this.CreatedAt = createdAt;
            this.Href = href;
            this.EcRate = ecRate;
        }
        
        /// <summary>
        /// The transaction ID for this transaction.
        /// </summary>
        /// <value>The transaction ID for this transaction.</value>
        [DataMember(Name="tx_id", EmitDefaultValue=false)]
        public string TxId { get; set; }

        /// <summary>
        /// The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;
        /// </summary>
        /// <value>The timestamp for this transaction. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// An API link to obtain all data for this transaction.
        /// </summary>
        /// <value>An API link to obtain all data for this transaction.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// The price of an entry credit at the time of this transaction.
        /// </summary>
        /// <value>The price of an entry credit at the time of this transaction.</value>
        [DataMember(Name="ec_rate", EmitDefaultValue=false)]
        public string EcRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionLinkShort {\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  EcRate: ").Append(EcRate).Append("\n");
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
            return this.Equals(input as TransactionLinkShort);
        }

        /// <summary>
        /// Returns true if TransactionLinkShort instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLinkShort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLinkShort input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
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
                ) && 
                (
                    this.EcRate == input.EcRate ||
                    (this.EcRate != null &&
                    this.EcRate.Equals(input.EcRate))
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
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.EcRate != null)
                    hashCode = hashCode * 59 + this.EcRate.GetHashCode();
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
