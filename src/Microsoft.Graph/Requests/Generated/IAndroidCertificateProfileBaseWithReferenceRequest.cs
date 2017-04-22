// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAndroidCertificateProfileBaseWithReferenceRequest.
    /// </summary>
    public partial interface IAndroidCertificateProfileBaseWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AndroidCertificateProfileBase.
        /// </summary>
        /// <returns>The AndroidCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<AndroidCertificateProfileBase> GetAsync();

        /// <summary>
        /// Gets the specified AndroidCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<AndroidCertificateProfileBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCertificateProfileBaseWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCertificateProfileBaseWithReferenceRequest Expand(Expression<Func<AndroidCertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCertificateProfileBaseWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidCertificateProfileBaseWithReferenceRequest Select(Expression<Func<AndroidCertificateProfileBase, object>> selectExpression);

    }
}
