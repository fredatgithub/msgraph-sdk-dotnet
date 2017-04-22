// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type NotebookRequest.
    /// </summary>
    public partial class NotebookRequest : BaseRequest, INotebookRequest
    {
        /// <summary>
        /// Constructs a new NotebookRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NotebookRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Notebook using POST.
        /// </summary>
        /// <param name="notebookToCreate">The Notebook to create.</param>
        /// <returns>The created Notebook.</returns>
        public System.Threading.Tasks.Task<Notebook> CreateAsync(Notebook notebookToCreate)
        {
            return this.CreateAsync(notebookToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Notebook using POST.
        /// </summary>
        /// <param name="notebookToCreate">The Notebook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Notebook.</returns>
        public async System.Threading.Tasks.Task<Notebook> CreateAsync(Notebook notebookToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Notebook>(notebookToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Notebook.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Notebook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Notebook>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Notebook.
        /// </summary>
        /// <returns>The Notebook.</returns>
        public System.Threading.Tasks.Task<Notebook> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Notebook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Notebook.</returns>
        public async System.Threading.Tasks.Task<Notebook> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Notebook>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Notebook using PATCH.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook to update.</param>
        /// <returns>The updated Notebook.</returns>
        public System.Threading.Tasks.Task<Notebook> UpdateAsync(Notebook notebookToUpdate)
        {
            return this.UpdateAsync(notebookToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Notebook using PATCH.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Notebook.</returns>
        public async System.Threading.Tasks.Task<Notebook> UpdateAsync(Notebook notebookToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Notebook>(notebookToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INotebookRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INotebookRequest Expand(Expression<Func<Notebook, object>> expandExpression)
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
        public INotebookRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INotebookRequest Select(Expression<Func<Notebook, object>> selectExpression)
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
        /// <param name="notebookToInitialize">The <see cref="Notebook"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Notebook notebookToInitialize)
        {

            if (notebookToInitialize != null && notebookToInitialize.AdditionalData != null)
            {

                if (notebookToInitialize.Sections != null && notebookToInitialize.Sections.CurrentPage != null)
                {
                    notebookToInitialize.Sections.AdditionalData = notebookToInitialize.AdditionalData;

                    object nextPageLink;
                    notebookToInitialize.AdditionalData.TryGetValue("sections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        notebookToInitialize.Sections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (notebookToInitialize.SectionGroups != null && notebookToInitialize.SectionGroups.CurrentPage != null)
                {
                    notebookToInitialize.SectionGroups.AdditionalData = notebookToInitialize.AdditionalData;

                    object nextPageLink;
                    notebookToInitialize.AdditionalData.TryGetValue("sectionGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        notebookToInitialize.SectionGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
