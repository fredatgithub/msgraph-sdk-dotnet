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
    /// The interface ITodoTaskRequest.
    /// </summary>
    public partial interface ITodoTaskRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TodoTask using POST.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TodoTask.</returns>
        System.Threading.Tasks.Task<TodoTask> CreateAsync(TodoTask todoTaskToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TodoTask using POST and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToCreate">The TodoTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTask>> CreateResponseAsync(TodoTask todoTaskToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TodoTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TodoTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TodoTask.
        /// </summary>
        /// <returns>The TodoTask.</returns>
        System.Threading.Tasks.Task<TodoTask> GetAsync();

        /// <summary>
        /// Gets the specified TodoTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TodoTask.</returns>
        System.Threading.Tasks.Task<TodoTask> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TodoTask and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTask>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TodoTask and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTask>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TodoTask using PATCH.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TodoTask.</returns>
        System.Threading.Tasks.Task<TodoTask> UpdateAsync(TodoTask todoTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TodoTask using PATCH and returns a <see cref="GraphResponse{TodoTask}"/> object.
        /// </summary>
        /// <param name="todoTaskToUpdate">The TodoTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TodoTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTask>> UpdateResponseAsync(TodoTask todoTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskRequest Expand(Expression<Func<TodoTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskRequest Select(Expression<Func<TodoTask, object>> selectExpression);

    }
}
