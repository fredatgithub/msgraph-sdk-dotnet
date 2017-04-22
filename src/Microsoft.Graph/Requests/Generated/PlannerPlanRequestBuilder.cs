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
    /// The type PlannerPlanRequestBuilder.
    /// </summary>
    public partial class PlannerPlanRequestBuilder : EntityRequestBuilder, IPlannerPlanRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlannerPlanRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerPlanRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPlannerPlanRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPlannerPlanRequest Request(IEnumerable<Option> options)
        {
            return new PlannerPlanRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanTasksCollectionRequestBuilder"/>.</returns>
        public IPlannerPlanTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new PlannerPlanTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Buckets.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanBucketsCollectionRequestBuilder"/>.</returns>
        public IPlannerPlanBucketsCollectionRequestBuilder Buckets
        {
            get
            {
                return new PlannerPlanBucketsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("buckets"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlanDetailsRequestBuilder"/>.</returns>
        public IPlannerPlanDetailsRequestBuilder Details
        {
            get
            {
                return new PlannerPlanDetailsRequestBuilder(this.AppendSegmentToRequestUrl("details"), this.Client);
            }
        }
    
    }
}
