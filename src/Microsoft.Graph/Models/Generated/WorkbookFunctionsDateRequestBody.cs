// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsDateRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsDateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Year.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "year", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Year { get; set; }
    
        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "month", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Month { get; set; }
    
        /// <summary>
        /// Gets or sets Day.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "day", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Day { get; set; }
    
    }
}
