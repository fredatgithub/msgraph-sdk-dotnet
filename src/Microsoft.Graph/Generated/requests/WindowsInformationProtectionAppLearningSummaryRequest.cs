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
    /// The type WindowsInformationProtectionAppLearningSummaryRequest.
    /// </summary>
    public partial class WindowsInformationProtectionAppLearningSummaryRequest : BaseRequest, IWindowsInformationProtectionAppLearningSummaryRequest
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionAppLearningSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsInformationProtectionAppLearningSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLearningSummary using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToCreate">The WindowsInformationProtectionAppLearningSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionAppLearningSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> CreateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsInformationProtectionAppLearningSummary>(windowsInformationProtectionAppLearningSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLearningSummary using POST and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToCreate">The WindowsInformationProtectionAppLearningSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLearningSummary>> CreateResponseAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLearningSummary>(windowsInformationProtectionAppLearningSummaryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsInformationProtectionAppLearningSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <returns>The WindowsInformationProtectionAppLearningSummary.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionAppLearningSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsInformationProtectionAppLearningSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLearningSummary>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLearningSummary>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLearningSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLearningSummary using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToUpdate">The WindowsInformationProtectionAppLearningSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionAppLearningSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> UpdateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsInformationProtectionAppLearningSummary>(windowsInformationProtectionAppLearningSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLearningSummary using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToUpdate">The WindowsInformationProtectionAppLearningSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLearningSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLearningSummary>> UpdateResponseAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLearningSummary>(windowsInformationProtectionAppLearningSummaryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLearningSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLearningSummaryRequest Expand(Expression<Func<WindowsInformationProtectionAppLearningSummary, object>> expandExpression)
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
        public IWindowsInformationProtectionAppLearningSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLearningSummaryRequest Select(Expression<Func<WindowsInformationProtectionAppLearningSummary, object>> selectExpression)
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
        /// <param name="windowsInformationProtectionAppLearningSummaryToInitialize">The <see cref="WindowsInformationProtectionAppLearningSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToInitialize)
        {

        }
    }
}
