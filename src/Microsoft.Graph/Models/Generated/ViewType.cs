// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ViewType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ViewType
    {
    
        /// <summary>
        /// detail
        /// </summary>
        Detail = 0,
	
        /// <summary>
        /// activations
        /// </summary>
        Activations = 1,
	
        /// <summary>
        /// users
        /// </summary>
        Users = 2,
	
        /// <summary>
        /// services
        /// </summary>
        Services = 3,
	
        /// <summary>
        /// activity
        /// </summary>
        Activity = 4,
	
        /// <summary>
        /// groups
        /// </summary>
        Groups = 5,
	
        /// <summary>
        /// storage
        /// </summary>
        Storage = 6,
	
        /// <summary>
        /// apps
        /// </summary>
        Apps = 7,
	
        /// <summary>
        /// versions
        /// </summary>
        Versions = 8,
	
        /// <summary>
        /// mailbox
        /// </summary>
        Mailbox = 9,
	
        /// <summary>
        /// quota
        /// </summary>
        Quota = 10,
	
        /// <summary>
        /// files
        /// </summary>
        Files = 11,
	
        /// <summary>
        /// account
        /// </summary>
        Account = 12,
	
        /// <summary>
        /// sites
        /// </summary>
        Sites = 13,
	
        /// <summary>
        /// minutes
        /// </summary>
        Minutes = 14,
	
        /// <summary>
        /// distribution
        /// </summary>
        Distribution = 15,
	
    }
}
