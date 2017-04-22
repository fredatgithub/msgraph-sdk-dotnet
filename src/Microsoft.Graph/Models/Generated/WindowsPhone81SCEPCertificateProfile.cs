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
    /// The type Windows Phone81SCEPCertificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsPhone81SCEPCertificateProfile : WindowsPhone81CertificateProfileBase
    {
    
        /// <summary>
        /// Gets or sets scep server urls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scepServerUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ScepServerUrls { get; set; }
    
        /// <summary>
        /// Gets or sets key usage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyUsage", Required = Newtonsoft.Json.Required.Default)]
        public KeyUsages? KeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets key size.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keySize", Required = Newtonsoft.Json.Required.Default)]
        public KeySize? KeySize { get; set; }
    
        /// <summary>
        /// Gets or sets hash algorithm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hashAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public HashAlgorithms? HashAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificate", Required = Newtonsoft.Json.Required.Default)]
        public WindowsPhone81TrustedRootCertificate RootCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCertificateStates", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }
    
    }
}

