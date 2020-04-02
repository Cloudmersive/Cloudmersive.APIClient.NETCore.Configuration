/* 
 * configapi
 *
 * Config API lets you easily manage configuration at scale.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.ConfigurationAPI.Model
{
    /// <summary>
    /// Defines an x-www-form-urlencoded parameter
    /// </summary>
    [DataContract]
    public partial class HttpWwwFormUrlEncodedParameter :  IEquatable<HttpWwwFormUrlEncodedParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpWwwFormUrlEncodedParameter" /> class.
        /// </summary>
        /// <param name="keyName">Key name of the parameter.</param>
        /// <param name="keyValue">Key value of the paramer (must be of type text); if set, do not use UseOutputFromPreviousTask.</param>
        /// <param name="useOutputFromPreviousTask">Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore..</param>
        public HttpWwwFormUrlEncodedParameter(string keyName = default(string), string keyValue = default(string), TaskOutputReference useOutputFromPreviousTask = default(TaskOutputReference))
        {
            this.KeyName = keyName;
            this.KeyValue = keyValue;
            this.UseOutputFromPreviousTask = useOutputFromPreviousTask;
        }
        
        /// <summary>
        /// Key name of the parameter
        /// </summary>
        /// <value>Key name of the parameter</value>
        [DataMember(Name="KeyName", EmitDefaultValue=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// Key value of the paramer (must be of type text); if set, do not use UseOutputFromPreviousTask
        /// </summary>
        /// <value>Key value of the paramer (must be of type text); if set, do not use UseOutputFromPreviousTask</value>
        [DataMember(Name="KeyValue", EmitDefaultValue=false)]
        public string KeyValue { get; set; }

        /// <summary>
        /// Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore.
        /// </summary>
        /// <value>Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore.</value>
        [DataMember(Name="UseOutputFromPreviousTask", EmitDefaultValue=false)]
        public TaskOutputReference UseOutputFromPreviousTask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpWwwFormUrlEncodedParameter {\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  KeyValue: ").Append(KeyValue).Append("\n");
            sb.Append("  UseOutputFromPreviousTask: ").Append(UseOutputFromPreviousTask).Append("\n");
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
            return this.Equals(input as HttpWwwFormUrlEncodedParameter);
        }

        /// <summary>
        /// Returns true if HttpWwwFormUrlEncodedParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpWwwFormUrlEncodedParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpWwwFormUrlEncodedParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.KeyValue == input.KeyValue ||
                    (this.KeyValue != null &&
                    this.KeyValue.Equals(input.KeyValue))
                ) && 
                (
                    this.UseOutputFromPreviousTask == input.UseOutputFromPreviousTask ||
                    (this.UseOutputFromPreviousTask != null &&
                    this.UseOutputFromPreviousTask.Equals(input.UseOutputFromPreviousTask))
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
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.KeyValue != null)
                    hashCode = hashCode * 59 + this.KeyValue.GetHashCode();
                if (this.UseOutputFromPreviousTask != null)
                    hashCode = hashCode * 59 + this.UseOutputFromPreviousTask.GetHashCode();
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
