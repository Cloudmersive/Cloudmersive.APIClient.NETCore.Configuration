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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.ConfigurationAPI.Model
{
    /// <summary>
    /// UpdateSettingResponse
    /// </summary>
    [DataContract]
    public partial class UpdateSettingResponse :  IEquatable<UpdateSettingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingResponse" /> class.
        /// </summary>
        /// <param name="successful">successful.</param>
        /// <param name="errorMessage">errorMessage.</param>
        public UpdateSettingResponse(bool? successful = default(bool?), string errorMessage = default(string))
        {
            this.Successful = successful;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSettingResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as UpdateSettingResponse);
        }

        /// <summary>
        /// Returns true if UpdateSettingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSettingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSettingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }

}
