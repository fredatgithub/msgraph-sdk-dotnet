// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosManagedAppProtectionRequest.
    /// </summary>
    public partial interface IIosManagedAppProtectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosManagedAppProtection using POST.
        /// </summary>
        /// <param name="iosManagedAppProtectionToCreate">The IosManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosManagedAppProtection.</returns>
        System.Threading.Tasks.Task<IosManagedAppProtection> CreateAsync(IosManagedAppProtection iosManagedAppProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosManagedAppProtection using POST and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="iosManagedAppProtectionToCreate">The IosManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> CreateResponseAsync(IosManagedAppProtection iosManagedAppProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosManagedAppProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosManagedAppProtection.
        /// </summary>
        /// <returns>The IosManagedAppProtection.</returns>
        System.Threading.Tasks.Task<IosManagedAppProtection> GetAsync();

        /// <summary>
        /// Gets the specified IosManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosManagedAppProtection.</returns>
        System.Threading.Tasks.Task<IosManagedAppProtection> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosManagedAppProtection and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosManagedAppProtection and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="iosManagedAppProtectionToUpdate">The IosManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosManagedAppProtection.</returns>
        System.Threading.Tasks.Task<IosManagedAppProtection> UpdateAsync(IosManagedAppProtection iosManagedAppProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosManagedAppProtection using PATCH and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="iosManagedAppProtectionToUpdate">The IosManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> UpdateResponseAsync(IosManagedAppProtection iosManagedAppProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppProtectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppProtectionRequest Expand(Expression<Func<IosManagedAppProtection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppProtectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppProtectionRequest Select(Expression<Func<IosManagedAppProtection, object>> selectExpression);

    }
}
