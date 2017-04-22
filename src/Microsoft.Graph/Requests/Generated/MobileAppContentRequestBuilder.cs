// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type MobileAppContentRequestBuilder.
    /// </summary>
    public partial class MobileAppContentRequestBuilder : EntityRequestBuilder, IMobileAppContentRequestBuilder
    {

        /// <summary>
        /// Constructs a new MobileAppContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MobileAppContentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMobileAppContentRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMobileAppContentRequest Request(IEnumerable<Option> options)
        {
            return new MobileAppContentRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Files.
        /// </summary>
        /// <returns>The <see cref="IMobileAppContentFilesCollectionRequestBuilder"/>.</returns>
        public IMobileAppContentFilesCollectionRequestBuilder Files
        {
            get
            {
                return new MobileAppContentFilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("files"), this.Client);
            }
        }
    
    }
}
