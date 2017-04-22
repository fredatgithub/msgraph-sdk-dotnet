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
    /// The type Workbook Chart Legend Format.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartLegendFormat : Entity
    {
    
        /// <summary>
        /// Gets or sets fill.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fill", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartFill Fill { get; set; }
    
        /// <summary>
        /// Gets or sets font.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "font", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartFont Font { get; set; }
    
    }
}

