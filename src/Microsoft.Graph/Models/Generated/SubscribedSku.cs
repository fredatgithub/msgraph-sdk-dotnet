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
    /// The type Subscribed Sku.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SubscribedSku : Entity
    {
    
        /// <summary>
        /// Gets or sets capability status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capabilityStatus", Required = Newtonsoft.Json.Required.Default)]
        public string CapabilityStatus { get; set; }
    
        /// <summary>
        /// Gets or sets consumed units.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consumedUnits", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConsumedUnits { get; set; }
    
        /// <summary>
        /// Gets or sets prepaid units.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepaidUnits", Required = Newtonsoft.Json.Required.Default)]
        public LicenseUnitsDetail PrepaidUnits { get; set; }
    
        /// <summary>
        /// Gets or sets service plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ServicePlanInfo> ServicePlans { get; set; }
    
        /// <summary>
        /// Gets or sets sku id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? SkuId { get; set; }
    
        /// <summary>
        /// Gets or sets sku part number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuPartNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SkuPartNumber { get; set; }
    
        /// <summary>
        /// Gets or sets applies to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesTo", Required = Newtonsoft.Json.Required.Default)]
        public string AppliesTo { get; set; }
    
    }
}

