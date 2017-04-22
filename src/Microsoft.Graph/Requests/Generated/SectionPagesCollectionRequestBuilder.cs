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
    /// The type SectionPagesCollectionRequestBuilder.
    /// </summary>
    public partial class SectionPagesCollectionRequestBuilder : BaseRequestBuilder, ISectionPagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SectionPagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SectionPagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISectionPagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISectionPagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SectionPagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPageRequestBuilder"/> for the specified SectionPage.
        /// </summary>
        /// <param name="id">The ID for the SectionPage.</param>
        /// <returns>The <see cref="IPageRequestBuilder"/>.</returns>
        public IPageRequestBuilder this[string id]
        {
            get
            {
                return new PageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
