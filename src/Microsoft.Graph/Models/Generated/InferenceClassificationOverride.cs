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
    /// The type Inference Classification Override.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class InferenceClassificationOverride : Entity
    {
    
        /// <summary>
        /// Gets or sets classify as.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classifyAs", Required = Newtonsoft.Json.Required.Default)]
        public InferenceClassificationType? ClassifyAs { get; set; }
    
        /// <summary>
        /// Gets or sets sender email address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "senderEmailAddress", Required = Newtonsoft.Json.Required.Default)]
        public EmailAddress SenderEmailAddress { get; set; }
    
    }
}

