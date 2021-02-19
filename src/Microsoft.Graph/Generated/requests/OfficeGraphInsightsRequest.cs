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
    /// The type OfficeGraphInsightsRequest.
    /// </summary>
    public partial class OfficeGraphInsightsRequest : BaseRequest, IOfficeGraphInsightsRequest
    {
        /// <summary>
        /// Constructs a new OfficeGraphInsightsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OfficeGraphInsightsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeGraphInsights.</returns>
        public async System.Threading.Tasks.Task<OfficeGraphInsights> CreateAsync(OfficeGraphInsights officeGraphInsightsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OfficeGraphInsights>(officeGraphInsightsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OfficeGraphInsights using POST and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <param name="officeGraphInsightsToCreate">The OfficeGraphInsights to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> CreateResponseAsync(OfficeGraphInsights officeGraphInsightsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OfficeGraphInsights>(officeGraphInsightsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OfficeGraphInsights.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<OfficeGraphInsights>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OfficeGraphInsights and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OfficeGraphInsights.
        /// </summary>
        /// <returns>The OfficeGraphInsights.</returns>
        public System.Threading.Tasks.Task<OfficeGraphInsights> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OfficeGraphInsights.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeGraphInsights.</returns>
        public async System.Threading.Tasks.Task<OfficeGraphInsights> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OfficeGraphInsights>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OfficeGraphInsights and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OfficeGraphInsights and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<OfficeGraphInsights>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified OfficeGraphInsights using PATCH.
        /// </summary>
        /// <param name="officeGraphInsightsToUpdate">The OfficeGraphInsights to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OfficeGraphInsights.</returns>
        public async System.Threading.Tasks.Task<OfficeGraphInsights> UpdateAsync(OfficeGraphInsights officeGraphInsightsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OfficeGraphInsights>(officeGraphInsightsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OfficeGraphInsights using PATCH and returns a <see cref="GraphResponse{OfficeGraphInsights}"/> object.
        /// </summary>
        /// <param name="officeGraphInsightsToUpdate">The OfficeGraphInsights to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OfficeGraphInsights}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OfficeGraphInsights>> UpdateResponseAsync(OfficeGraphInsights officeGraphInsightsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<OfficeGraphInsights>(officeGraphInsightsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeGraphInsightsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeGraphInsightsRequest Expand(Expression<Func<OfficeGraphInsights, object>> expandExpression)
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
        public IOfficeGraphInsightsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeGraphInsightsRequest Select(Expression<Func<OfficeGraphInsights, object>> selectExpression)
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
        /// <param name="officeGraphInsightsToInitialize">The <see cref="OfficeGraphInsights"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OfficeGraphInsights officeGraphInsightsToInitialize)
        {

            if (officeGraphInsightsToInitialize != null && officeGraphInsightsToInitialize.AdditionalData != null)
            {

                if (officeGraphInsightsToInitialize.Shared != null && officeGraphInsightsToInitialize.Shared.CurrentPage != null)
                {
                    officeGraphInsightsToInitialize.Shared.AdditionalData = officeGraphInsightsToInitialize.AdditionalData;

                    object nextPageLink;
                    officeGraphInsightsToInitialize.AdditionalData.TryGetValue("shared@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        officeGraphInsightsToInitialize.Shared.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (officeGraphInsightsToInitialize.Trending != null && officeGraphInsightsToInitialize.Trending.CurrentPage != null)
                {
                    officeGraphInsightsToInitialize.Trending.AdditionalData = officeGraphInsightsToInitialize.AdditionalData;

                    object nextPageLink;
                    officeGraphInsightsToInitialize.AdditionalData.TryGetValue("trending@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        officeGraphInsightsToInitialize.Trending.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (officeGraphInsightsToInitialize.Used != null && officeGraphInsightsToInitialize.Used.CurrentPage != null)
                {
                    officeGraphInsightsToInitialize.Used.AdditionalData = officeGraphInsightsToInitialize.AdditionalData;

                    object nextPageLink;
                    officeGraphInsightsToInitialize.AdditionalData.TryGetValue("used@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        officeGraphInsightsToInitialize.Used.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
