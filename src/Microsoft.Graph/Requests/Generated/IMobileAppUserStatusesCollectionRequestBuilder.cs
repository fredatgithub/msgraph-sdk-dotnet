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
    /// The interface IMobileAppUserStatusesCollectionRequestBuilder.
    /// </summary>
    public partial interface IMobileAppUserStatusesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMobileAppUserStatusesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMobileAppUserStatusesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserAppInstallStatusRequestBuilder"/> for the specified UserAppInstallStatus.
        /// </summary>
        /// <param name="id">The ID for the UserAppInstallStatus.</param>
        /// <returns>The <see cref="IUserAppInstallStatusRequestBuilder"/>.</returns>
        IUserAppInstallStatusRequestBuilder this[string id] { get; }

        
    }
}
