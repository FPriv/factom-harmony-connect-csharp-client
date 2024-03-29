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
    /// A factoid or entry credit address.
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="address">The literal address..</param>
        /// <param name="userAddress">The user address..</param>
        /// <param name="type">Whether this is an entry credit or factoid address..</param>
        /// <param name="balance">The current entry credit or factoid balance of the address..</param>
        /// <param name="transactions">A list of all transactions that this address has paricipated in..</param>
        public Address(string address = default(string), string userAddress = default(string), string type = default(string), string balance = default(string), Object transactions = default(Object))
        {
            this._Address = address;
            this.UserAddress = userAddress;
            this.Type = type;
            this.Balance = balance;
            this.Transactions = transactions;
        }
        
        /// <summary>
        /// The literal address.
        /// </summary>
        /// <value>The literal address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string _Address { get; set; }

        /// <summary>
        /// The user address.
        /// </summary>
        /// <value>The user address.</value>
        [DataMember(Name="user_address", EmitDefaultValue=false)]
        public string UserAddress { get; set; }

        /// <summary>
        /// Whether this is an entry credit or factoid address.
        /// </summary>
        /// <value>Whether this is an entry credit or factoid address.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The current entry credit or factoid balance of the address.
        /// </summary>
        /// <value>The current entry credit or factoid balance of the address.</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// A list of all transactions that this address has paricipated in.
        /// </summary>
        /// <value>A list of all transactions that this address has paricipated in.</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public Object Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  _Address: ").Append(_Address).Append("\n");
            sb.Append("  UserAddress: ").Append(UserAddress).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Address == input._Address ||
                    (this._Address != null &&
                    this._Address.Equals(input._Address))
                ) && 
                (
                    this.UserAddress == input.UserAddress ||
                    (this.UserAddress != null &&
                    this.UserAddress.Equals(input.UserAddress))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this._Address != null)
                    hashCode = hashCode * 59 + this._Address.GetHashCode();
                if (this.UserAddress != null)
                    hashCode = hashCode * 59 + this.UserAddress.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
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
