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
    /// The type WorkbookChartAxisTitleFormatRequest.
    /// </summary>
    public partial class WorkbookChartAxisTitleFormatRequest : BaseRequest, IWorkbookChartAxisTitleFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartAxisTitleFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartAxisTitleFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartAxisTitleFormat using POST.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToCreate">The WorkbookChartAxisTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxisTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> CreateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartAxisTitleFormat>(workbookChartAxisTitleFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookChartAxisTitleFormat using POST and returns a <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToCreate">The WorkbookChartAxisTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitleFormat>> CreateResponseAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookChartAxisTitleFormat>(workbookChartAxisTitleFormatToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartAxisTitleFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitleFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <returns>The WorkbookChartAxisTitleFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxisTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartAxisTitleFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat and returns a <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitleFormat>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat and returns a <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitleFormat>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookChartAxisTitleFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToUpdate">The WorkbookChartAxisTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAxisTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> UpdateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartAxisTitleFormat>(workbookChartAxisTitleFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitleFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToUpdate">The WorkbookChartAxisTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartAxisTitleFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartAxisTitleFormat>> UpdateResponseAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookChartAxisTitleFormat>(workbookChartAxisTitleFormatToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAxisTitleFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAxisTitleFormatRequest Expand(Expression<Func<WorkbookChartAxisTitleFormat, object>> expandExpression)
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
        public IWorkbookChartAxisTitleFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAxisTitleFormatRequest Select(Expression<Func<WorkbookChartAxisTitleFormat, object>> selectExpression)
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
        /// <param name="workbookChartAxisTitleFormatToInitialize">The <see cref="WorkbookChartAxisTitleFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToInitialize)
        {

        }
    }
}
