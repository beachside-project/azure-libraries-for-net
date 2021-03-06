// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An environment variable to be set on a task process.
    /// </summary>
    public partial class EnvironmentSetting
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentSetting class.
        /// </summary>
        public EnvironmentSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentSetting class.
        /// </summary>
        /// <param name="name">The name of the environment variable.</param>
        /// <param name="value">The value of the environment variable.</param>
        public EnvironmentSetting(string name, string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the environment variable.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the environment variable.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
