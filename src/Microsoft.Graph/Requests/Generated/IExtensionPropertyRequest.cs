// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IExtensionPropertyRequest.
    /// </summary>
    public partial interface IExtensionPropertyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExtensionProperty using PUT.
        /// </summary>
        /// <param name="extensionPropertyToCreate">The ExtensionProperty to create.</param>
        /// <returns>The created ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> CreateAsync(ExtensionProperty extensionPropertyToCreate);        /// <summary>
        /// Creates the specified ExtensionProperty using PUT.
        /// </summary>
        /// <param name="extensionPropertyToCreate">The ExtensionProperty to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> CreateAsync(ExtensionProperty extensionPropertyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ExtensionProperty.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ExtensionProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ExtensionProperty.
        /// </summary>
        /// <returns>The ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> GetAsync();

        /// <summary>
        /// Gets the specified ExtensionProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ExtensionProperty using PATCH.
        /// </summary>
        /// <param name="extensionPropertyToUpdate">The ExtensionProperty to update.</param>
        /// <returns>The updated ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> UpdateAsync(ExtensionProperty extensionPropertyToUpdate);

        /// <summary>
        /// Updates the specified ExtensionProperty using PATCH.
        /// </summary>
        /// <param name="extensionPropertyToUpdate">The ExtensionProperty to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ExtensionProperty.</returns>
        System.Threading.Tasks.Task<ExtensionProperty> UpdateAsync(ExtensionProperty extensionPropertyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionPropertyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionPropertyRequest Expand(Expression<Func<ExtensionProperty, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionPropertyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExtensionPropertyRequest Select(Expression<Func<ExtensionProperty, object>> selectExpression);

    }
}
