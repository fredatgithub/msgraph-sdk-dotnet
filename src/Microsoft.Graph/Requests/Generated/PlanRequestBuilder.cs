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
    /// The type PlanRequestBuilder.
    /// </summary>
    public partial class PlanRequestBuilder : EntityRequestBuilder, IPlanRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlanRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlanRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPlanRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPlanRequest Request(IEnumerable<Option> options)
        {
            return new PlanRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlanTasksCollectionWithReferencesRequestBuilder"/>.</returns>
        public IPlanTasksCollectionWithReferencesRequestBuilder Tasks
        {
            get
            {
                return new PlanTasksCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Buckets.
        /// </summary>
        /// <returns>The <see cref="IPlanBucketsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IPlanBucketsCollectionWithReferencesRequestBuilder Buckets
        {
            get
            {
                return new PlanBucketsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("buckets"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="IPlanDetailsRequestBuilder"/>.</returns>
        public IPlanDetailsRequestBuilder Details
        {
            get
            {
                return new PlanDetailsRequestBuilder(this.AppendSegmentToRequestUrl("details"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AssignedToTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        public IPlanTaskBoardRequestBuilder AssignedToTaskBoard
        {
            get
            {
                return new PlanTaskBoardRequestBuilder(this.AppendSegmentToRequestUrl("assignedToTaskBoard"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ProgressTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        public IPlanTaskBoardRequestBuilder ProgressTaskBoard
        {
            get
            {
                return new PlanTaskBoardRequestBuilder(this.AppendSegmentToRequestUrl("progressTaskBoard"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BucketTaskBoard.
        /// </summary>
        /// <returns>The <see cref="IPlanTaskBoardRequestBuilder"/>.</returns>
        public IPlanTaskBoardRequestBuilder BucketTaskBoard
        {
            get
            {
                return new PlanTaskBoardRequestBuilder(this.AppendSegmentToRequestUrl("bucketTaskBoard"), this.Client);
            }
        }
    
    }
}
