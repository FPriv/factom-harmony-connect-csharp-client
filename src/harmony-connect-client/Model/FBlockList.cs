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
    /// FBlockList
    /// </summary>
    [DataContract]
    public partial class FBlockList :  IEquatable<FBlockList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FBlockList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FBlockList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FBlockList" /> class.
        /// </summary>
        /// <param name="data">The factoid blocks returned in this set. (required).</param>
        /// <param name="offset">The index of the first block returned from the total set (Starting from 0). (required).</param>
        /// <param name="limit">The number of blocks returned per page. (required).</param>
        /// <param name="count">The total number of blocks seen. (required).</param>
        public FBlockList(List<FBlockShort> data = default(List<FBlockShort>), int? offset = default(int?), int? limit = default(int?), int? count = default(int?))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for FBlockList and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "offset" is required (not null)
            if (offset == null)
            {
                throw new InvalidDataException("offset is a required property for FBlockList and cannot be null");
            }
            else
            {
                this.Offset = offset;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for FBlockList and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for FBlockList and cannot be null");
            }
            else
            {
                this.Count = count;
            }
        }
        
        /// <summary>
        /// The factoid blocks returned in this set.
        /// </summary>
        /// <value>The factoid blocks returned in this set.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FBlockShort> Data { get; set; }

        /// <summary>
        /// The index of the first block returned from the total set (Starting from 0).
        /// </summary>
        /// <value>The index of the first block returned from the total set (Starting from 0).</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of blocks returned per page.
        /// </summary>
        /// <value>The number of blocks returned per page.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The total number of blocks seen.
        /// </summary>
        /// <value>The total number of blocks seen.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FBlockList {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as FBlockList);
        }

        /// <summary>
        /// Returns true if FBlockList instances are equal
        /// </summary>
        /// <param name="input">Instance of FBlockList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FBlockList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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
