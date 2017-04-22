// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceContractsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceContractsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceContractsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceContractsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceContractsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceContractsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceContractsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceContractsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IContractRequestBuilder"/> for the specified GraphServiceContract.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceContract.</param>
        /// <returns>The <see cref="IContractRequestBuilder"/>.</returns>
        public IContractRequestBuilder this[string id]
        {
            get
            {
                return new ContractRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
