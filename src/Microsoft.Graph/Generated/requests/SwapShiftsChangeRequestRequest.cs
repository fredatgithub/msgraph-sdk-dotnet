// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type SwapShiftsChangeRequestRequest.
    /// </summary>
    public partial class SwapShiftsChangeRequestRequest : BaseRequest, ISwapShiftsChangeRequestRequest
    {
        /// <summary>
        /// Constructs a new SwapShiftsChangeRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SwapShiftsChangeRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SwapShiftsChangeRequestObject using POST.
        /// </summary>
        /// <param name="swapShiftsChangeRequestObjectToCreate">The SwapShiftsChangeRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SwapShiftsChangeRequestObject.</returns>
        public async System.Threading.Tasks.Task<SwapShiftsChangeRequestObject> CreateAsync(SwapShiftsChangeRequestObject swapShiftsChangeRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SwapShiftsChangeRequestObject>(swapShiftsChangeRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SwapShiftsChangeRequestObject using POST and returns a <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object.
        /// </summary>
        /// <param name="swapShiftsChangeRequestObjectToCreate">The SwapShiftsChangeRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SwapShiftsChangeRequestObject>> CreateResponseAsync(SwapShiftsChangeRequestObject swapShiftsChangeRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SwapShiftsChangeRequestObject>(swapShiftsChangeRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SwapShiftsChangeRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<SwapShiftsChangeRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SwapShiftsChangeRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SwapShiftsChangeRequestObject.
        /// </summary>
        /// <returns>The SwapShiftsChangeRequestObject.</returns>
        public System.Threading.Tasks.Task<SwapShiftsChangeRequestObject> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SwapShiftsChangeRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SwapShiftsChangeRequestObject.</returns>
        public async System.Threading.Tasks.Task<SwapShiftsChangeRequestObject> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SwapShiftsChangeRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SwapShiftsChangeRequestObject and returns a <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SwapShiftsChangeRequestObject>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SwapShiftsChangeRequestObject and returns a <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SwapShiftsChangeRequestObject>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<SwapShiftsChangeRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified SwapShiftsChangeRequestObject using PATCH.
        /// </summary>
        /// <param name="swapShiftsChangeRequestObjectToUpdate">The SwapShiftsChangeRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SwapShiftsChangeRequestObject.</returns>
        public async System.Threading.Tasks.Task<SwapShiftsChangeRequestObject> UpdateAsync(SwapShiftsChangeRequestObject swapShiftsChangeRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SwapShiftsChangeRequestObject>(swapShiftsChangeRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SwapShiftsChangeRequestObject using PATCH and returns a <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object.
        /// </summary>
        /// <param name="swapShiftsChangeRequestObjectToUpdate">The SwapShiftsChangeRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SwapShiftsChangeRequestObject}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SwapShiftsChangeRequestObject>> UpdateResponseAsync(SwapShiftsChangeRequestObject swapShiftsChangeRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SwapShiftsChangeRequestObject>(swapShiftsChangeRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISwapShiftsChangeRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISwapShiftsChangeRequestRequest Expand(Expression<Func<SwapShiftsChangeRequestObject, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ISwapShiftsChangeRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISwapShiftsChangeRequestRequest Select(Expression<Func<SwapShiftsChangeRequestObject, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="swapShiftsChangeRequestObjectToInitialize">The <see cref="SwapShiftsChangeRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SwapShiftsChangeRequestObject swapShiftsChangeRequestObjectToInitialize)
        {

        }
    }
}
