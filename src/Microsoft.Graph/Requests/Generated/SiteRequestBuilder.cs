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
    /// The type SiteRequestBuilder.
    /// </summary>
    public partial class SiteRequestBuilder : BaseItemRequestBuilder, ISiteRequestBuilder
    {

        /// <summary>
        /// Constructs a new SiteRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SiteRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISiteRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISiteRequest Request(IEnumerable<Option> options)
        {
            return new SiteRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl("drive"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="ISiteDrivesCollectionRequestBuilder"/>.</returns>
        public ISiteDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new SiteDrivesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("drives"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="ISiteItemsCollectionRequestBuilder"/>.</returns>
        public ISiteItemsCollectionRequestBuilder Items
        {
            get
            {
                return new SiteItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Lists.
        /// </summary>
        /// <returns>The <see cref="ISiteListsCollectionRequestBuilder"/>.</returns>
        public ISiteListsCollectionRequestBuilder Lists
        {
            get
            {
                return new SiteListsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("lists"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="ISiteSitesCollectionRequestBuilder"/>.</returns>
        public ISiteSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new SiteSitesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sites"), this.Client);
            }
        }
    
    }
}
