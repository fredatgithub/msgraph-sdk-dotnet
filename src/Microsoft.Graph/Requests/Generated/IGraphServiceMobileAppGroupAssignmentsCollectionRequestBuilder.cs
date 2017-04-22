// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceMobileAppGroupAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceMobileAppGroupAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileAppGroupAssignmentRequestBuilder"/> for the specified MobileAppGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the MobileAppGroupAssignment.</param>
        /// <returns>The <see cref="IMobileAppGroupAssignmentRequestBuilder"/>.</returns>
        IMobileAppGroupAssignmentRequestBuilder this[string id] { get; }

        
    }
}
