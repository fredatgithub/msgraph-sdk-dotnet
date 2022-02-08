// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SearchHit.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SearchHit>))]
    public partial class SearchHit
    {

        /// <summary>
        /// Gets or sets contentSource.
        /// The name of the content source which the externalItem is part of .
        /// </summary>
        [JsonPropertyName("contentSource")]
        public string ContentSource { get; set; }
    
        /// <summary>
        /// Gets or sets hitId.
        /// The internal identifier for the item.
        /// </summary>
        [JsonPropertyName("hitId")]
        public string HitId { get; set; }
    
        /// <summary>
        /// Gets or sets rank.
        /// The rank or the order of the result.
        /// </summary>
        [JsonPropertyName("rank")]
        public Int32? Rank { get; set; }
    
        /// <summary>
        /// Gets or sets resultTemplateId.
        /// ID of the result template for rendering the search result. This ID must map to a display layout in the resultTemplates dictionary, included in the searchresponse as well.
        /// </summary>
        [JsonPropertyName("resultTemplateId")]
        public string ResultTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets summary.
        /// A summary of the result, if a summary is available.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// </summary>
        [JsonPropertyName("resource")]
        public Entity Resource { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
