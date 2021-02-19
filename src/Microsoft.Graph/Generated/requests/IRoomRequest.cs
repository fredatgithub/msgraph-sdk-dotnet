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
    /// The interface IRoomRequest.
    /// </summary>
    public partial interface IRoomRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Room using POST.
        /// </summary>
        /// <param name="roomToCreate">The Room to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Room.</returns>
        System.Threading.Tasks.Task<Room> CreateAsync(Room roomToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Room using POST and returns a <see cref="GraphResponse{Room}"/> object.
        /// </summary>
        /// <param name="roomToCreate">The Room to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Room}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Room>> CreateResponseAsync(Room roomToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Room.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Room and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Room.
        /// </summary>
        /// <returns>The Room.</returns>
        System.Threading.Tasks.Task<Room> GetAsync();

        /// <summary>
        /// Gets the specified Room.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Room.</returns>
        System.Threading.Tasks.Task<Room> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Room and returns a <see cref="GraphResponse{Room}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Room}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Room>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Room and returns a <see cref="GraphResponse{Room}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Room}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Room>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Room using PATCH.
        /// </summary>
        /// <param name="roomToUpdate">The Room to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Room.</returns>
        System.Threading.Tasks.Task<Room> UpdateAsync(Room roomToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Room using PATCH and returns a <see cref="GraphResponse{Room}"/> object.
        /// </summary>
        /// <param name="roomToUpdate">The Room to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Room}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Room>> UpdateResponseAsync(Room roomToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoomRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoomRequest Expand(Expression<Func<Room, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoomRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoomRequest Select(Expression<Func<Room, object>> selectExpression);

    }
}
