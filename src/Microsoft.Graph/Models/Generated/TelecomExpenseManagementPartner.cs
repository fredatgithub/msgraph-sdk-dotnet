// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Telecom Expense Management Partner.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TelecomExpenseManagementPartner : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Newtonsoft.Json.Required.Default)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets app authorized.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appAuthorized", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppAuthorized { get; set; }
    
        /// <summary>
        /// Gets or sets enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets last connection date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastConnectionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastConnectionDateTime { get; set; }
    
    }
}

