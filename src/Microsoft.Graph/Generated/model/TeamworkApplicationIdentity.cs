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
    /// The type TeamworkApplicationIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkApplicationIdentity>))]
    public partial class TeamworkApplicationIdentity : Identity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamworkApplicationIdentity"/> class.
        /// </summary>
        public TeamworkApplicationIdentity()
        {
            this.ODataType = "microsoft.graph.teamworkApplicationIdentity";
        }

        /// <summary>
        /// Gets or sets applicationIdentityType.
        /// Type of application that is referenced. Possible values are: aadApplication, bot, tenantBot, office365Connector, outgoingWebhook, and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("applicationIdentityType")]
        public TeamworkApplicationIdentityType? ApplicationIdentityType { get; set; }
    
    }
}
