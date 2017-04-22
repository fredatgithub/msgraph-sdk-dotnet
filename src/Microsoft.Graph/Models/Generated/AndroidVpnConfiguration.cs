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
    /// The type Android Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidVpnConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets connection name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionName", Required = Newtonsoft.Json.Required.Default)]
        public string ConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "role", Required = Newtonsoft.Json.Required.Default)]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "realm", Required = Newtonsoft.Json.Required.Default)]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets servers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnServer> Servers { get; set; }
    
        /// <summary>
        /// Gets or sets fingerprint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fingerprint", Required = Newtonsoft.Json.Required.Default)]
        public string Fingerprint { get; set; }
    
        /// <summary>
        /// Gets or sets custom data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValue> CustomData { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

