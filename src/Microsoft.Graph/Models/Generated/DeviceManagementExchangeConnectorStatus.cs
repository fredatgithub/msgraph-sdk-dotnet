// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceManagementExchangeConnectorStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceManagementExchangeConnectorStatus
    {
    
        /// <summary>
        /// connection Pending
        /// </summary>
        ConnectionPending = 0,
	
        /// <summary>
        /// connected
        /// </summary>
        Connected = 1,
	
        /// <summary>
        /// disconnected
        /// </summary>
        Disconnected = 2,
	
        /// <summary>
        /// none
        /// </summary>
        None = 3,
	
    }
}
