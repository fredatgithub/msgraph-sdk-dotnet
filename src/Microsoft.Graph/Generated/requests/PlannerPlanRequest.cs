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
    /// The type PlannerPlanRequest.
    /// </summary>
    public partial class PlannerPlanRequest : BaseRequest, IPlannerPlanRequest
    {
        /// <summary>
        /// Constructs a new PlannerPlanRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerPlanRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerPlan using POST.
        /// </summary>
        /// <param name="plannerPlanToCreate">The PlannerPlan to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerPlan.</returns>
        public async System.Threading.Tasks.Task<PlannerPlan> CreateAsync(PlannerPlan plannerPlanToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PlannerPlan>(plannerPlanToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PlannerPlan using POST and returns a <see cref="GraphResponse{PlannerPlan}"/> object.
        /// </summary>
        /// <param name="plannerPlanToCreate">The PlannerPlan to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlan}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlan>> CreateResponseAsync(PlannerPlan plannerPlanToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PlannerPlan>(plannerPlanToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerPlan.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<PlannerPlan>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerPlan and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PlannerPlan.
        /// </summary>
        /// <returns>The PlannerPlan.</returns>
        public System.Threading.Tasks.Task<PlannerPlan> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerPlan.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerPlan.</returns>
        public async System.Threading.Tasks.Task<PlannerPlan> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PlannerPlan>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PlannerPlan and returns a <see cref="GraphResponse{PlannerPlan}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerPlan}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerPlan>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerPlan and returns a <see cref="GraphResponse{PlannerPlan}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlan}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlan>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<PlannerPlan>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified PlannerPlan using PATCH.
        /// </summary>
        /// <param name="plannerPlanToUpdate">The PlannerPlan to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerPlan.</returns>
        public async System.Threading.Tasks.Task<PlannerPlan> UpdateAsync(PlannerPlan plannerPlanToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PlannerPlan>(plannerPlanToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerPlan using PATCH and returns a <see cref="GraphResponse{PlannerPlan}"/> object.
        /// </summary>
        /// <param name="plannerPlanToUpdate">The PlannerPlan to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerPlan}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlan>> UpdateResponseAsync(PlannerPlan plannerPlanToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<PlannerPlan>(plannerPlanToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanRequest Expand(Expression<Func<PlannerPlan, object>> expandExpression)
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
        public IPlannerPlanRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanRequest Select(Expression<Func<PlannerPlan, object>> selectExpression)
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
        /// <param name="plannerPlanToInitialize">The <see cref="PlannerPlan"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerPlan plannerPlanToInitialize)
        {

            if (plannerPlanToInitialize != null && plannerPlanToInitialize.AdditionalData != null)
            {

                if (plannerPlanToInitialize.Buckets != null && plannerPlanToInitialize.Buckets.CurrentPage != null)
                {
                    plannerPlanToInitialize.Buckets.AdditionalData = plannerPlanToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerPlanToInitialize.AdditionalData.TryGetValue("buckets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerPlanToInitialize.Buckets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (plannerPlanToInitialize.Tasks != null && plannerPlanToInitialize.Tasks.CurrentPage != null)
                {
                    plannerPlanToInitialize.Tasks.AdditionalData = plannerPlanToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerPlanToInitialize.AdditionalData.TryGetValue("tasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerPlanToInitialize.Tasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
