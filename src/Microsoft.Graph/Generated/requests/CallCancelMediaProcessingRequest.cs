// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type CallCancelMediaProcessingRequest.
    /// </summary>
    public partial class CallCancelMediaProcessingRequest : BaseRequest, ICallCancelMediaProcessingRequest
    {
        /// <summary>
        /// Constructs a new CallCancelMediaProcessingRequest.
        /// </summary>
        public CallCancelMediaProcessingRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = "application/json";
            this.RequestBody = new CallCancelMediaProcessingRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public CallCancelMediaProcessingRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<CancelMediaProcessingOperation> PostAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "POST";
            return this.SendAsync<CancelMediaProcessingOperation>(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CancelMediaProcessingOperation>> PostResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<CancelMediaProcessingOperation>(this.RequestBody, cancellationToken).ConfigureAwait(false);
        }



        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICallCancelMediaProcessingRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICallCancelMediaProcessingRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
