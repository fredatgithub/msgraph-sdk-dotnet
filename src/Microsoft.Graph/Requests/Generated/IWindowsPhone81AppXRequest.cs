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
    /// The interface IWindowsPhone81AppXRequest.
    /// </summary>
    public partial interface IWindowsPhone81AppXRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81AppX using PUT.
        /// </summary>
        /// <param name="windowsPhone81AppXToCreate">The WindowsPhone81AppX to create.</param>
        /// <returns>The created WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> CreateAsync(WindowsPhone81AppX windowsPhone81AppXToCreate);        /// <summary>
        /// Creates the specified WindowsPhone81AppX using PUT.
        /// </summary>
        /// <param name="windowsPhone81AppXToCreate">The WindowsPhone81AppX to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> CreateAsync(WindowsPhone81AppX windowsPhone81AppXToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81AppX.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81AppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81AppX.
        /// </summary>
        /// <returns>The WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81AppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81AppX using PATCH.
        /// </summary>
        /// <param name="windowsPhone81AppXToUpdate">The WindowsPhone81AppX to update.</param>
        /// <returns>The updated WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> UpdateAsync(WindowsPhone81AppX windowsPhone81AppXToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81AppX using PATCH.
        /// </summary>
        /// <param name="windowsPhone81AppXToUpdate">The WindowsPhone81AppX to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> UpdateAsync(WindowsPhone81AppX windowsPhone81AppXToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Expand(Expression<Func<WindowsPhone81AppX, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Select(Expression<Func<WindowsPhone81AppX, object>> selectExpression);

    }
}
