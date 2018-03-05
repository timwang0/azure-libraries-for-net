// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service objectives capability.
    /// </summary>
    public partial class ServiceLevelObjectiveCapability
    {
        /// <summary>
        /// Initializes a new instance of the ServiceLevelObjectiveCapability
        /// class.
        /// </summary>
        public ServiceLevelObjectiveCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceLevelObjectiveCapability
        /// class.
        /// </summary>
        /// <param name="id">The unique ID of the service objective.</param>
        /// <param name="name">The service objective name.</param>
        /// <param name="supportedMaxSizes">The list of supported maximum
        /// database sizes for this service objective.</param>
        /// <param name="performanceLevel">The performance level of the service
        /// objective capability.</param>
        /// <param name="includedMaxSize">The included (free) max size for this
        /// service level objective.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public ServiceLevelObjectiveCapability(System.Guid? id = default(System.Guid?), string name = default(string), IList<MaxSizeCapability> supportedMaxSizes = default(IList<MaxSizeCapability>), PerformanceLevelCapability performanceLevel = default(PerformanceLevelCapability), MaxSizeCapability includedMaxSize = default(MaxSizeCapability), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Id = id;
            Name = name;
            SupportedMaxSizes = supportedMaxSizes;
            PerformanceLevel = performanceLevel;
            IncludedMaxSize = includedMaxSize;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique ID of the service objective.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; private set; }

        /// <summary>
        /// Gets the service objective name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the list of supported maximum database sizes for this service
        /// objective.
        /// </summary>
        [JsonProperty(PropertyName = "supportedMaxSizes")]
        public IList<MaxSizeCapability> SupportedMaxSizes { get; private set; }

        /// <summary>
        /// Gets the performance level of the service objective capability.
        /// </summary>
        [JsonProperty(PropertyName = "performanceLevel")]
        public PerformanceLevelCapability PerformanceLevel { get; private set; }

        /// <summary>
        /// Gets the included (free) max size for this service level objective.
        /// </summary>
        [JsonProperty(PropertyName = "includedMaxSize")]
        public MaxSizeCapability IncludedMaxSize { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}