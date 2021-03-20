/* 
 * Virtual Office
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
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
using SwaggerDateConverter = VirtualOffice.RestApiClient.Client.SwaggerDateConverter;

namespace VirtualOffice.RestApiClient.Model
{
    /// <summary>
    /// Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Task() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="beginTime">beginTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="creationTime">creationTime.</param>
        /// <param name="assignees">assignees.</param>
        public Task(long? id = default(long?), string name = default(string), string beginTime = default(string), string endTime = default(string), string creationTime = default(string), List<Employee> assignees = default(List<Employee>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Task and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Id = id;
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.CreationTime = creationTime;
            this.Assignees = assignees;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BeginTime
        /// </summary>
        [DataMember(Name="beginTime", EmitDefaultValue=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [DataMember(Name="assignees", EmitDefaultValue=false)]
        public List<Employee> Assignees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.Assignees == input.Assignees ||
                    this.Assignees != null &&
                    this.Assignees.SequenceEqual(input.Assignees)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.Assignees != null)
                    hashCode = hashCode * 59 + this.Assignees.GetHashCode();
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