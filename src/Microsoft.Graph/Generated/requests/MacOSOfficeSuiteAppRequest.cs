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
    /// The type MacOSOfficeSuiteAppRequest.
    /// </summary>
    public partial class MacOSOfficeSuiteAppRequest : BaseRequest, IMacOSOfficeSuiteAppRequest
    {
        /// <summary>
        /// Constructs a new MacOSOfficeSuiteAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSOfficeSuiteAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSOfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<MacOSOfficeSuiteApp> CreateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSOfficeSuiteApp>(macOSOfficeSuiteAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> CreateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSOfficeSuiteApp>(macOSOfficeSuiteAppToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSOfficeSuiteApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <returns>The MacOSOfficeSuiteApp.</returns>
        public System.Threading.Tasks.Task<MacOSOfficeSuiteApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSOfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<MacOSOfficeSuiteApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSOfficeSuiteApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSOfficeSuiteApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSOfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<MacOSOfficeSuiteApp> UpdateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSOfficeSuiteApp>(macOSOfficeSuiteAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> UpdateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSOfficeSuiteApp>(macOSOfficeSuiteAppToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSOfficeSuiteAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSOfficeSuiteAppRequest Expand(Expression<Func<MacOSOfficeSuiteApp, object>> expandExpression)
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
        public IMacOSOfficeSuiteAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSOfficeSuiteAppRequest Select(Expression<Func<MacOSOfficeSuiteApp, object>> selectExpression)
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
        /// <param name="macOSOfficeSuiteAppToInitialize">The <see cref="MacOSOfficeSuiteApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSOfficeSuiteApp macOSOfficeSuiteAppToInitialize)
        {

        }
    }
}
