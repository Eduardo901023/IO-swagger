/*
 * home-iot-api
 *
 * The API for the EatBacon IOT project
 *
 * OpenAPI spec version: 1.0.0
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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class LightingZone : IEquatable<LightingZone>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>

        [DataMember(Name="deviceId")]
        public int? DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum DimmerEnum for dimmer
            /// </summary>
            [EnumMember(Value = "dimmer")]
            DimmerEnum = 0,
            /// <summary>
            /// Enum SwitchEnum for switch
            /// </summary>
            [EnumMember(Value = "switch")]
            SwitchEnum = 1        }

        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>

        [DataMember(Name="deviceType")]
        public DeviceTypeEnum? DeviceType { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>

        [DataMember(Name="zone")]
        public string Zone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LightingZone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((LightingZone)obj);
        }

        /// <summary>
        /// Returns true if LightingZone instances are equal
        /// </summary>
        /// <param name="other">Instance of LightingZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LightingZone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DeviceId == other.DeviceId ||
                    DeviceId != null &&
                    DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    DeviceType == other.DeviceType ||
                    DeviceType != null &&
                    DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    Zone == other.Zone ||
                    Zone != null &&
                    Zone.Equals(other.Zone)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (DeviceId != null)
                    hashCode = hashCode * 59 + DeviceId.GetHashCode();
                    if (DeviceType != null)
                    hashCode = hashCode * 59 + DeviceType.GetHashCode();
                    if (Zone != null)
                    hashCode = hashCode * 59 + Zone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LightingZone left, LightingZone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LightingZone left, LightingZone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
