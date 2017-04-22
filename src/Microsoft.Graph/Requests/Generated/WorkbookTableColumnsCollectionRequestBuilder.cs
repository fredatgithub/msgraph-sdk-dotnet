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
    /// The type WorkbookTableColumnsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookTableColumnsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookTableColumnsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookTableColumnsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookTableColumnsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookTableColumnsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookTableColumnsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookTableColumnsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookTableColumnRequestBuilder"/> for the specified WorkbookTableWorkbookTableColumn.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTableWorkbookTableColumn.</param>
        /// <returns>The <see cref="IWorkbookTableColumnRequestBuilder"/>.</returns>
        public IWorkbookTableColumnRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookTableColumnRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnAddRequestBuilder"/>.</returns>
        public IWorkbookTableColumnAddRequestBuilder Add(
            Int32? index = null,
            Newtonsoft.Json.Linq.JToken values = null,
            string name = null)
        {
            return new WorkbookTableColumnAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                index,
                values,
                name);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnItemAtRequestBuilder"/>.</returns>
        public IWorkbookTableColumnItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookTableColumnItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnCountRequestBuilder"/>.</returns>
        public IWorkbookTableColumnCountRequestBuilder Count()
        {
            return new WorkbookTableColumnCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    }
}
