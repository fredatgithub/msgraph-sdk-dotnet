// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum CertificateDestinationStore.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CertificateDestinationStore
    {
    
        /// <summary>
        /// computer Cert Store Root
        /// </summary>
        ComputerCertStoreRoot = 0,
	
        /// <summary>
        /// computer Cert Store Intermediate
        /// </summary>
        ComputerCertStoreIntermediate = 1,
	
        /// <summary>
        /// user Cert Store Intermediate
        /// </summary>
        UserCertStoreIntermediate = 2,
	
    }
}
