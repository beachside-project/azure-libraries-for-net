// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Patch schedule entry for a Premium Redis Cache.
    /// </summary>
    public partial class ScheduleEntryInner
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleEntryInner class.
        /// </summary>
        public ScheduleEntryInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleEntryInner class.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week when a cache can be
        /// patched. Possible values include: 'Monday', 'Tuesday', 'Wednesday',
        /// 'Thursday', 'Friday', 'Saturday', 'Sunday', 'Everyday',
        /// 'Weekend'</param>
        /// <param name="startHourUtc">Start hour after which cache patching
        /// can start.</param>
        /// <param name="maintenanceWindow">ISO8601 timespan specifying how
        /// much time cache patching can take. </param>
        public ScheduleEntryInner(DayOfWeek dayOfWeek, int startHourUtc, System.TimeSpan? maintenanceWindow = default(System.TimeSpan?))
        {
            DayOfWeek = dayOfWeek;
            StartHourUtc = startHourUtc;
            MaintenanceWindow = maintenanceWindow;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets day of the week when a cache can be patched. Possible
        /// values include: 'Monday', 'Tuesday', 'Wednesday', 'Thursday',
        /// 'Friday', 'Saturday', 'Sunday', 'Everyday', 'Weekend'
        /// </summary>
        [JsonProperty(PropertyName = "dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets start hour after which cache patching can start.
        /// </summary>
        [JsonProperty(PropertyName = "startHourUtc")]
        public int StartHourUtc { get; set; }

        /// <summary>
        /// Gets or sets ISO8601 timespan specifying how much time cache
        /// patching can take.
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public System.TimeSpan? MaintenanceWindow { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
