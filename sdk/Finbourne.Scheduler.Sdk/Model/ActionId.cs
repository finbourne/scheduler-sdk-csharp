/*
 * FINBOURNE Scheduler API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Scheduler.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Scheduler.Sdk.Model
{
    /// <summary>
    /// ActionId
    /// </summary>
    [DataContract(Name = "ActionId")]
    public partial class ActionId : IEquatable<ActionId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionId" /> class.
        /// </summary>
        /// <param name="scope">scope (required).</param>
        /// <param name="activity">activity (required).</param>
        /// <param name="entity">entity (required).</param>
        public ActionId(string scope = default(string), string activity = default(string), string entity = default(string))
        {
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for ActionId and cannot be null");
            }
            this.Scope = scope;
            // to ensure "activity" is required (not null)
            if (activity == null)
            {
                throw new ArgumentNullException("activity is a required property for ActionId and cannot be null");
            }
            this.Activity = activity;
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new ArgumentNullException("entity is a required property for ActionId and cannot be null");
            }
            this.Entity = entity;
        }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = true)]
        public string Activity { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", IsRequired = true, EmitDefaultValue = true)]
        public string Entity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionId {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionId);
        }

        /// <summary>
        /// Returns true if ActionId instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
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
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Activity != null)
                {
                    hashCode = (hashCode * 59) + this.Activity.GetHashCode();
                }
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
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
            // Scope (string) maxLength
            if (this.Scope != null && this.Scope.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be less than 100.", new [] { "Scope" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 3.", new [] { "Scope" });
            }

            // Activity (string) maxLength
            if (this.Activity != null && this.Activity.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Activity, length must be less than 25.", new [] { "Activity" });
            }

            // Activity (string) minLength
            if (this.Activity != null && this.Activity.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Activity, length must be greater than 3.", new [] { "Activity" });
            }

            // Entity (string) maxLength
            if (this.Entity != null && this.Entity.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Entity, length must be less than 40.", new [] { "Entity" });
            }

            // Entity (string) minLength
            if (this.Entity != null && this.Entity.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Entity, length must be greater than 3.", new [] { "Entity" });
            }

            yield break;
        }
    }
}
