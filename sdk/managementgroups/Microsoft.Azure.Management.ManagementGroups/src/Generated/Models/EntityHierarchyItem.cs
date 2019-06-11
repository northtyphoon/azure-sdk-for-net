// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The management group details for the hierarchy view.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EntityHierarchyItem : IResource
    {
        /// <summary>
        /// Initializes a new instance of the EntityHierarchyItem class.
        /// </summary>
        public EntityHierarchyItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityHierarchyItem class.
        /// </summary>
        /// <param name="id">The fully qualified ID for the management group.
        /// For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000</param>
        /// <param name="type">The type of the resource.  For example,
        /// /providers/Microsoft.Management/managementGroups</param>
        /// <param name="name">The name of the management group. For example,
        /// 00000000-0000-0000-0000-000000000000</param>
        /// <param name="displayName">The friendly name of the management
        /// group.</param>
        /// <param name="permissions">Permissions</param>
        /// <param name="children">The list of children.</param>
        public EntityHierarchyItem(string id = default(string), string type = default(string), string name = default(string), string displayName = default(string), string permissions = default(string), IList<EntityHierarchyItem> children = default(IList<EntityHierarchyItem>))
        {
            Id = id;
            Type = type;
            Name = name;
            DisplayName = displayName;
            Permissions = permissions;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified ID for the management group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the resource.  For example,
        /// /providers/Microsoft.Management/managementGroups
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name of the management group. For example,
        /// 00000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the friendly name of the management group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets permissions
        /// </summary>
        /// <remarks>
        /// Possible values include: 'noaccess', 'view', 'edit', 'delete'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// Gets or sets the list of children.
        /// </summary>
        [JsonProperty(PropertyName = "properties.children")]
        public IList<EntityHierarchyItem> Children { get; set; }

    }
}