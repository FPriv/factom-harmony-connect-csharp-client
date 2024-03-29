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
    /// IdentityKeyReplace
    /// </summary>
    [DataContract]
    public partial class IdentityKeyReplace :  IEquatable<IdentityKeyReplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityKeyReplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdentityKeyReplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityKeyReplace" /> class.
        /// </summary>
        /// <param name="oldKey">The public key you would like to replace. This should be sent as a Base58 string in IdPub format. (required).</param>
        /// <param name="newKey">The public key that you would like to activate. This should be sent as a Base58 string in IdPub format. (required).</param>
        /// <param name="signerKey">The key you are using to authorize the replacement. Must be equal to or higher level than the key you want to replace. This should be sent as a Base58 string in IdPub format. (required).</param>
        /// <param name="signature">A signature that proves ownership of the &#x60;signer_key&#x60;. This signature should use the [Ed25519](https://ed25519.cr.yp.to/) specification. The signed message should be the Identity Chain ID, the Old Key, and the New Key in that order. The message should be a single string with no whitespace or separators between the three parts. (required).</param>
        /// <param name="callbackUrl">The URL where you would like to receive the callback from Connect. If this is not specified, callbacks will not activate..</param>
        /// <param name="callbackStages">The stages that you would like to trigger a callback from Connect. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;.</param>
        public IdentityKeyReplace(string oldKey = default(string), string newKey = default(string), string signerKey = default(string), string signature = default(string), string callbackUrl = default(string), List<string> callbackStages = default(List<string>))
        {
            // to ensure "oldKey" is required (not null)
            if (oldKey == null)
            {
                throw new InvalidDataException("oldKey is a required property for IdentityKeyReplace and cannot be null");
            }
            else
            {
                this.OldKey = oldKey;
            }
            // to ensure "newKey" is required (not null)
            if (newKey == null)
            {
                throw new InvalidDataException("newKey is a required property for IdentityKeyReplace and cannot be null");
            }
            else
            {
                this.NewKey = newKey;
            }
            // to ensure "signerKey" is required (not null)
            if (signerKey == null)
            {
                throw new InvalidDataException("signerKey is a required property for IdentityKeyReplace and cannot be null");
            }
            else
            {
                this.SignerKey = signerKey;
            }
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for IdentityKeyReplace and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }
            this.CallbackUrl = callbackUrl;
            this.CallbackStages = callbackStages;
        }
        
        /// <summary>
        /// The public key you would like to replace. This should be sent as a Base58 string in IdPub format.
        /// </summary>
        /// <value>The public key you would like to replace. This should be sent as a Base58 string in IdPub format.</value>
        [DataMember(Name="old_key", EmitDefaultValue=false)]
        public string OldKey { get; set; }

        /// <summary>
        /// The public key that you would like to activate. This should be sent as a Base58 string in IdPub format.
        /// </summary>
        /// <value>The public key that you would like to activate. This should be sent as a Base58 string in IdPub format.</value>
        [DataMember(Name="new_key", EmitDefaultValue=false)]
        public string NewKey { get; set; }

        /// <summary>
        /// The key you are using to authorize the replacement. Must be equal to or higher level than the key you want to replace. This should be sent as a Base58 string in IdPub format.
        /// </summary>
        /// <value>The key you are using to authorize the replacement. Must be equal to or higher level than the key you want to replace. This should be sent as a Base58 string in IdPub format.</value>
        [DataMember(Name="signer_key", EmitDefaultValue=false)]
        public string SignerKey { get; set; }

        /// <summary>
        /// A signature that proves ownership of the &#x60;signer_key&#x60;. This signature should use the [Ed25519](https://ed25519.cr.yp.to/) specification. The signed message should be the Identity Chain ID, the Old Key, and the New Key in that order. The message should be a single string with no whitespace or separators between the three parts.
        /// </summary>
        /// <value>A signature that proves ownership of the &#x60;signer_key&#x60;. This signature should use the [Ed25519](https://ed25519.cr.yp.to/) specification. The signed message should be the Identity Chain ID, the Old Key, and the New Key in that order. The message should be a single string with no whitespace or separators between the three parts.</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// The URL where you would like to receive the callback from Connect. If this is not specified, callbacks will not activate.
        /// </summary>
        /// <value>The URL where you would like to receive the callback from Connect. If this is not specified, callbacks will not activate.</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The stages that you would like to trigger a callback from Connect. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;
        /// </summary>
        /// <value>The stages that you would like to trigger a callback from Connect. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60;</value>
        [DataMember(Name="callback_stages", EmitDefaultValue=false)]
        public List<string> CallbackStages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityKeyReplace {\n");
            sb.Append("  OldKey: ").Append(OldKey).Append("\n");
            sb.Append("  NewKey: ").Append(NewKey).Append("\n");
            sb.Append("  SignerKey: ").Append(SignerKey).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CallbackStages: ").Append(CallbackStages).Append("\n");
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
            return this.Equals(input as IdentityKeyReplace);
        }

        /// <summary>
        /// Returns true if IdentityKeyReplace instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityKeyReplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityKeyReplace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldKey == input.OldKey ||
                    (this.OldKey != null &&
                    this.OldKey.Equals(input.OldKey))
                ) && 
                (
                    this.NewKey == input.NewKey ||
                    (this.NewKey != null &&
                    this.NewKey.Equals(input.NewKey))
                ) && 
                (
                    this.SignerKey == input.SignerKey ||
                    (this.SignerKey != null &&
                    this.SignerKey.Equals(input.SignerKey))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.CallbackStages == input.CallbackStages ||
                    this.CallbackStages != null &&
                    this.CallbackStages.SequenceEqual(input.CallbackStages)
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
                if (this.OldKey != null)
                    hashCode = hashCode * 59 + this.OldKey.GetHashCode();
                if (this.NewKey != null)
                    hashCode = hashCode * 59 + this.NewKey.GetHashCode();
                if (this.SignerKey != null)
                    hashCode = hashCode * 59 + this.SignerKey.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.CallbackStages != null)
                    hashCode = hashCode * 59 + this.CallbackStages.GetHashCode();
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
