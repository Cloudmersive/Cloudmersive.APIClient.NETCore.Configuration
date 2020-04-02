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
    /// HTTP header to add to the HTTP request
    /// </summary>
    [DataContract]
    public partial class HttpOrchestrationHeader :  IEquatable<HttpOrchestrationHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpOrchestrationHeader" /> class.
        /// </summary>
        /// <param name="headerName">Name of the HTTP header, e.g. \&quot;Content-Type\&quot;.</param>
        /// <param name="headerValue">Value of the HTTP header.</param>
        /// <param name="useOutputFromPreviousTask">Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore..</param>
        public HttpOrchestrationHeader(string headerName = default(string), string headerValue = default(string), TaskOutputReference useOutputFromPreviousTask = default(TaskOutputReference))
        {
            this.HeaderName = headerName;
            this.HeaderValue = headerValue;
            this.UseOutputFromPreviousTask = useOutputFromPreviousTask;
        }
        
        /// <summary>
        /// Name of the HTTP header, e.g. \&quot;Content-Type\&quot;
        /// </summary>
        /// <value>Name of the HTTP header, e.g. \&quot;Content-Type\&quot;</value>
        [DataMember(Name="HeaderName", EmitDefaultValue=false)]
        public string HeaderName { get; set; }

        /// <summary>
        /// Value of the HTTP header
        /// </summary>
        /// <value>Value of the HTTP header</value>
        [DataMember(Name="HeaderValue", EmitDefaultValue=false)]
        public string HeaderValue { get; set; }

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
            sb.Append("class HttpOrchestrationHeader {\n");
            sb.Append("  HeaderName: ").Append(HeaderName).Append("\n");
            sb.Append("  HeaderValue: ").Append(HeaderValue).Append("\n");
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
            return this.Equals(input as HttpOrchestrationHeader);
        }

        /// <summary>
        /// Returns true if HttpOrchestrationHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpOrchestrationHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpOrchestrationHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeaderName == input.HeaderName ||
                    (this.HeaderName != null &&
                    this.HeaderName.Equals(input.HeaderName))
                ) && 
                (
                    this.HeaderValue == input.HeaderValue ||
                    (this.HeaderValue != null &&
                    this.HeaderValue.Equals(input.HeaderValue))
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
                if (this.HeaderName != null)
                    hashCode = hashCode * 59 + this.HeaderName.GetHashCode();
                if (this.HeaderValue != null)
                    hashCode = hashCode * 59 + this.HeaderValue.GetHashCode();
                if (this.UseOutputFromPreviousTask != null)
                    hashCode = hashCode * 59 + this.UseOutputFromPreviousTask.GetHashCode();
                return hashCode;
            }
        }
    }

}
