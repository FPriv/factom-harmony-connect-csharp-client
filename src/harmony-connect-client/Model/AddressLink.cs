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
    /// A link to a factoid or entry credit address.
    /// </summary>
    [DataContract]
    public partial class AddressLink :  IEquatable<AddressLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressLink" /> class.
        /// </summary>
        /// <param name="address">The literal address..</param>
        /// <param name="userAddress">The user address..</param>
        /// <param name="href">An API link to obtain all data about this address..</param>
        public AddressLink(string address = default(string), string userAddress = default(string), string href = default(string))
        {
            this.Address = address;
            this.UserAddress = userAddress;
            this.Href = href;
        }
        
        /// <summary>
        /// The literal address.
        /// </summary>
        /// <value>The literal address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The user address.
        /// </summary>
        /// <value>The user address.</value>
        [DataMember(Name="user_address", EmitDefaultValue=false)]
        public string UserAddress { get; set; }

        /// <summary>
        /// An API link to obtain all data about this address.
        /// </summary>
        /// <value>An API link to obtain all data about this address.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressLink {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  UserAddress: ").Append(UserAddress).Append("\n");
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
            return this.Equals(input as AddressLink);
        }

        /// <summary>
        /// Returns true if AddressLink instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.UserAddress == input.UserAddress ||
                    (this.UserAddress != null &&
                    this.UserAddress.Equals(input.UserAddress))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.UserAddress != null)
                    hashCode = hashCode * 59 + this.UserAddress.GetHashCode();
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
