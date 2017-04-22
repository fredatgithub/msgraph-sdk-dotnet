// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsInformationProtectionProtectedLocationEnterpriseCloudResources.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WindowsInformationProtectionProtectedLocationEnterpriseCloudResources : WindowsInformationProtectionProtectedLocation
    {
    
        /// <summary>
        /// Gets or sets values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EnterpriseCloudResource> Values { get; set; }
    
    }
}
