// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WindowsInformationProtectionPolicyRequestBuilder.
    /// </summary>
    public partial class WindowsInformationProtectionPolicyRequestBuilder : WindowsInformationProtectionRequestBuilder, IWindowsInformationProtectionPolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsInformationProtectionPolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsInformationProtectionPolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsInformationProtectionPolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsInformationProtectionPolicyRequest Request(IEnumerable<Option> options)
        {
            return new WindowsInformationProtectionPolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionPolicyUpdateTargetedSecurityGroups.
        /// </summary>
        /// <returns>The <see cref="IWindowsInformationProtectionPolicyUpdateTargetedSecurityGroupsRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionPolicyUpdateTargetedSecurityGroupsRequestBuilder UpdateTargetedSecurityGroups(
            IEnumerable<DirectoryObject> targetedSecurityGroups = null)
        {
            return new WindowsInformationProtectionPolicyUpdateTargetedSecurityGroupsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateTargetedSecurityGroups"),
                this.Client,
                targetedSecurityGroups);
        }
    
    }
}
