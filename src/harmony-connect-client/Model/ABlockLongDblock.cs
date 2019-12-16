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
    /// The directory block that contains this factoid block.
    /// </summary>
    [DataContract]
    public partial class ABlockLongDblock :  IEquatable<ABlockLongDblock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ABlockLongDblock" /> class.
        /// </summary>
        /// <param name="keymr">The Key Merkle root of the directory block..</param>
        /// <param name="href">An API link to the directory block..</param>
        public ABlockLongDblock(string keymr = default(string), string href = default(string))
        {
            this.Keymr = keymr;
            this.Href = href;
        }
        
        /// <summary>
        /// The Key Merkle root of the directory block.
        /// </summary>
        /// <value>The Key Merkle root of the directory block.</value>
        [DataMember(Name="keymr", EmitDefaultValue=false)]
        public string Keymr { get; set; }

        /// <summary>
        /// An API link to the directory block.
        /// </summary>
        /// <value>An API link to the directory block.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ABlockLongDblock {\n");
            sb.Append("  Keymr: ").Append(Keymr).Append("\n");
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
            return this.Equals(input as ABlockLongDblock);
        }

        /// <summary>
        /// Returns true if ABlockLongDblock instances are equal
        /// </summary>
        /// <param name="input">Instance of ABlockLongDblock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ABlockLongDblock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keymr == input.Keymr ||
                    (this.Keymr != null &&
                    this.Keymr.Equals(input.Keymr))
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
                if (this.Keymr != null)
                    hashCode = hashCode * 59 + this.Keymr.GetHashCode();
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
