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
    /// Result of performing an HTTP orchestration
    /// </summary>
    [DataContract]
    public partial class HttpOrchestrationResponse :  IEquatable<HttpOrchestrationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpOrchestrationResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="tasksCompleted">Count of the number of tasks that were completed.</param>
        /// <param name="outputStringType">Result output in string format.</param>
        /// <param name="outputBinaryType">Result output in binary format.</param>
        public HttpOrchestrationResponse(bool? successful = default(bool?), int? tasksCompleted = default(int?), string outputStringType = default(string), byte[] outputBinaryType = default(byte[]))
        {
            this.Successful = successful;
            this.TasksCompleted = tasksCompleted;
            this.OutputStringType = outputStringType;
            this.OutputBinaryType = outputBinaryType;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Count of the number of tasks that were completed
        /// </summary>
        /// <value>Count of the number of tasks that were completed</value>
        [DataMember(Name="TasksCompleted", EmitDefaultValue=false)]
        public int? TasksCompleted { get; set; }

        /// <summary>
        /// Result output in string format
        /// </summary>
        /// <value>Result output in string format</value>
        [DataMember(Name="Output_StringType", EmitDefaultValue=false)]
        public string OutputStringType { get; set; }

        /// <summary>
        /// Result output in binary format
        /// </summary>
        /// <value>Result output in binary format</value>
        [DataMember(Name="Output_BinaryType", EmitDefaultValue=false)]
        public byte[] OutputBinaryType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpOrchestrationResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TasksCompleted: ").Append(TasksCompleted).Append("\n");
            sb.Append("  OutputStringType: ").Append(OutputStringType).Append("\n");
            sb.Append("  OutputBinaryType: ").Append(OutputBinaryType).Append("\n");
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
            return this.Equals(input as HttpOrchestrationResponse);
        }

        /// <summary>
        /// Returns true if HttpOrchestrationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpOrchestrationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpOrchestrationResponse input)
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
                    this.TasksCompleted == input.TasksCompleted ||
                    (this.TasksCompleted != null &&
                    this.TasksCompleted.Equals(input.TasksCompleted))
                ) && 
                (
                    this.OutputStringType == input.OutputStringType ||
                    (this.OutputStringType != null &&
                    this.OutputStringType.Equals(input.OutputStringType))
                ) && 
                (
                    this.OutputBinaryType == input.OutputBinaryType ||
                    (this.OutputBinaryType != null &&
                    this.OutputBinaryType.Equals(input.OutputBinaryType))
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
                if (this.TasksCompleted != null)
                    hashCode = hashCode * 59 + this.TasksCompleted.GetHashCode();
                if (this.OutputStringType != null)
                    hashCode = hashCode * 59 + this.OutputStringType.GetHashCode();
                if (this.OutputBinaryType != null)
                    hashCode = hashCode * 59 + this.OutputBinaryType.GetHashCode();
                return hashCode;
            }
        }
    }

}
