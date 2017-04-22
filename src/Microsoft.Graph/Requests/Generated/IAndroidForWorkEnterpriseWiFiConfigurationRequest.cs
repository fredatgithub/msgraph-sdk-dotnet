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
    /// The interface IAndroidForWorkEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidForWorkEnterpriseWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkEnterpriseWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkEnterpriseWiFiConfigurationToCreate">The AndroidForWorkEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> CreateAsync(AndroidForWorkEnterpriseWiFiConfiguration androidForWorkEnterpriseWiFiConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkEnterpriseWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkEnterpriseWiFiConfigurationToCreate">The AndroidForWorkEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> CreateAsync(AndroidForWorkEnterpriseWiFiConfiguration androidForWorkEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkEnterpriseWiFiConfigurationToUpdate">The AndroidForWorkEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> UpdateAsync(AndroidForWorkEnterpriseWiFiConfiguration androidForWorkEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkEnterpriseWiFiConfigurationToUpdate">The AndroidForWorkEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidForWorkEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkEnterpriseWiFiConfiguration> UpdateAsync(AndroidForWorkEnterpriseWiFiConfiguration androidForWorkEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkEnterpriseWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidForWorkEnterpriseWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkEnterpriseWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidForWorkEnterpriseWiFiConfiguration, object>> selectExpression);

    }
}
