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
    /// The type LocalizedNotificationMessageRequest.
    /// </summary>
    public partial class LocalizedNotificationMessageRequest : BaseRequest, ILocalizedNotificationMessageRequest
    {
        /// <summary>
        /// Constructs a new LocalizedNotificationMessageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public LocalizedNotificationMessageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified LocalizedNotificationMessage using POST.
        /// </summary>
        /// <param name="localizedNotificationMessageToCreate">The LocalizedNotificationMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LocalizedNotificationMessage.</returns>
        public async System.Threading.Tasks.Task<LocalizedNotificationMessage> CreateAsync(LocalizedNotificationMessage localizedNotificationMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<LocalizedNotificationMessage>(localizedNotificationMessageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified LocalizedNotificationMessage using POST and returns a <see cref="GraphResponse{LocalizedNotificationMessage}"/> object.
        /// </summary>
        /// <param name="localizedNotificationMessageToCreate">The LocalizedNotificationMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LocalizedNotificationMessage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<LocalizedNotificationMessage>> CreateResponseAsync(LocalizedNotificationMessage localizedNotificationMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<LocalizedNotificationMessage>(localizedNotificationMessageToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified LocalizedNotificationMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<LocalizedNotificationMessage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified LocalizedNotificationMessage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified LocalizedNotificationMessage.
        /// </summary>
        /// <returns>The LocalizedNotificationMessage.</returns>
        public System.Threading.Tasks.Task<LocalizedNotificationMessage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified LocalizedNotificationMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LocalizedNotificationMessage.</returns>
        public async System.Threading.Tasks.Task<LocalizedNotificationMessage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<LocalizedNotificationMessage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified LocalizedNotificationMessage and returns a <see cref="GraphResponse{LocalizedNotificationMessage}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{LocalizedNotificationMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LocalizedNotificationMessage>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified LocalizedNotificationMessage and returns a <see cref="GraphResponse{LocalizedNotificationMessage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LocalizedNotificationMessage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<LocalizedNotificationMessage>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<LocalizedNotificationMessage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified LocalizedNotificationMessage using PATCH.
        /// </summary>
        /// <param name="localizedNotificationMessageToUpdate">The LocalizedNotificationMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LocalizedNotificationMessage.</returns>
        public async System.Threading.Tasks.Task<LocalizedNotificationMessage> UpdateAsync(LocalizedNotificationMessage localizedNotificationMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<LocalizedNotificationMessage>(localizedNotificationMessageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LocalizedNotificationMessage using PATCH and returns a <see cref="GraphResponse{LocalizedNotificationMessage}"/> object.
        /// </summary>
        /// <param name="localizedNotificationMessageToUpdate">The LocalizedNotificationMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LocalizedNotificationMessage}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<LocalizedNotificationMessage>> UpdateResponseAsync(LocalizedNotificationMessage localizedNotificationMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<LocalizedNotificationMessage>(localizedNotificationMessageToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILocalizedNotificationMessageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILocalizedNotificationMessageRequest Expand(Expression<Func<LocalizedNotificationMessage, object>> expandExpression)
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
        public ILocalizedNotificationMessageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ILocalizedNotificationMessageRequest Select(Expression<Func<LocalizedNotificationMessage, object>> selectExpression)
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
        /// <param name="localizedNotificationMessageToInitialize">The <see cref="LocalizedNotificationMessage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(LocalizedNotificationMessage localizedNotificationMessageToInitialize)
        {

        }
    }
}
