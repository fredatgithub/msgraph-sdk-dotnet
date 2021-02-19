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
    /// The interface IExtensionRequest.
    /// </summary>
    public partial interface IExtensionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Extension using POST.
        /// </summary>
        /// <param name="extensionToCreate">The Extension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Extension.</returns>
        System.Threading.Tasks.Task<Extension> CreateAsync(Extension extensionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Extension using POST and returns a <see cref="GraphResponse{Extension}"/> object.
        /// </summary>
        /// <param name="extensionToCreate">The Extension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> CreateResponseAsync(Extension extensionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Extension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Extension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Extension.
        /// </summary>
        /// <returns>The Extension.</returns>
        System.Threading.Tasks.Task<Extension> GetAsync();

        /// <summary>
        /// Gets the specified Extension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Extension.</returns>
        System.Threading.Tasks.Task<Extension> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Extension and returns a <see cref="GraphResponse{Extension}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Extension and returns a <see cref="GraphResponse{Extension}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Extension using PATCH.
        /// </summary>
        /// <param name="extensionToUpdate">The Extension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Extension.</returns>
        System.Threading.Tasks.Task<Extension> UpdateAsync(Extension extensionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Extension using PATCH and returns a <see cref="GraphResponse{Extension}"/> object.
        /// </summary>
        /// <param name="extensionToUpdate">The Extension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> UpdateResponseAsync(Extension extensionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionRequest Expand(Expression<Func<Extension, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionRequest Select(Expression<Func<Extension, object>> selectExpression);

    }
}
