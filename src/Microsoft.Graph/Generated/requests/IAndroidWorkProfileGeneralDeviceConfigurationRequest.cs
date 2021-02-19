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
    /// The interface IAndroidWorkProfileGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileGeneralDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileGeneralDeviceConfigurationToCreate">The AndroidWorkProfileGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGeneralDeviceConfiguration> CreateAsync(AndroidWorkProfileGeneralDeviceConfiguration androidWorkProfileGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidWorkProfileGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileGeneralDeviceConfigurationToCreate">The AndroidWorkProfileGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGeneralDeviceConfiguration>> CreateResponseAsync(AndroidWorkProfileGeneralDeviceConfiguration androidWorkProfileGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfileGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The AndroidWorkProfileGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGeneralDeviceConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidWorkProfileGeneralDeviceConfiguration and returns a <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGeneralDeviceConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileGeneralDeviceConfiguration and returns a <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGeneralDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidWorkProfileGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileGeneralDeviceConfigurationToUpdate">The AndroidWorkProfileGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGeneralDeviceConfiguration> UpdateAsync(AndroidWorkProfileGeneralDeviceConfiguration androidWorkProfileGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfileGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileGeneralDeviceConfigurationToUpdate">The AndroidWorkProfileGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileGeneralDeviceConfiguration>> UpdateResponseAsync(AndroidWorkProfileGeneralDeviceConfiguration androidWorkProfileGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGeneralDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGeneralDeviceConfigurationRequest Expand(Expression<Func<AndroidWorkProfileGeneralDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGeneralDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGeneralDeviceConfigurationRequest Select(Expression<Func<AndroidWorkProfileGeneralDeviceConfiguration, object>> selectExpression);

    }
}
