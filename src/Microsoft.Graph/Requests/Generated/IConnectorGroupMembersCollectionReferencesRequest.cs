// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IConnectorGroupMembersCollectionReferencesRequest.
    /// </summary>
    public partial interface IConnectorGroupMembersCollectionReferencesRequest : IBaseRequest
    {
        

        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(Connector connector);

        /// <summary>
        /// Adds the specified Connector to the collection via POST.
        /// </summary>
        /// <param name="connector">The Connector to add.</param>
        System.Threading.Tasks.Task AddAsync(Connector connector, CancellationToken cancellationToken);
    }
}
