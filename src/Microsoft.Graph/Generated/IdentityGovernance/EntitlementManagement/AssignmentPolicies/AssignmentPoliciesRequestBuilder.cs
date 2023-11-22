// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies.Count;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies {
    /// <summary>
    /// Provides operations to manage the assignmentPolicies property of the microsoft.graph.entitlementManagement entity.
    /// </summary>
    public class AssignmentPoliciesRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignmentPolicies property of the microsoft.graph.entitlementManagement entity.</summary>
        /// <param name="position">The unique identifier of accessPackageAssignmentPolicy</param>
        public AccessPackageAssignmentPolicyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("accessPackageAssignmentPolicy%2Did", position);
            return new AccessPackageAssignmentPolicyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AssignmentPoliciesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignmentPoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/assignmentPolicies{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AssignmentPoliciesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignmentPoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/assignmentPolicies{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, retrieve a list of accessPackageAssignmentPolicy objects. If the delegated user is in a directory role, the resulting list includes all the assignment policies that the caller has access to read, across all catalogs and access packages. If the delegated user is an access package manager or catalog owner, they should instead retrieve the policies for the access packages they can read with list accessPackages by including $expand=accessPackageAssignmentPolicies as a query parameter. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/entitlementmanagement-list-assignmentpolicies?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessPackageAssignmentPolicyCollectionResponse?> GetAsync(Action<RequestConfiguration<AssignmentPoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessPackageAssignmentPolicyCollectionResponse> GetAsync(Action<RequestConfiguration<AssignmentPoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessPackageAssignmentPolicyCollectionResponse>(requestInfo, AccessPackageAssignmentPolicyCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, create a new accessPackageAssignmentPolicy object.  The request will include a reference to the accessPackage that will contain this policy, which must already exist. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/entitlementmanagement-post-assignmentpolicies?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessPackageAssignmentPolicy?> PostAsync(AccessPackageAssignmentPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessPackageAssignmentPolicy> PostAsync(AccessPackageAssignmentPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessPackageAssignmentPolicy>(requestInfo, AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, retrieve a list of accessPackageAssignmentPolicy objects. If the delegated user is in a directory role, the resulting list includes all the assignment policies that the caller has access to read, across all catalogs and access packages. If the delegated user is an access package manager or catalog owner, they should instead retrieve the policies for the access packages they can read with list accessPackages by including $expand=accessPackageAssignmentPolicies as a query parameter. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AssignmentPoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AssignmentPoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, create a new accessPackageAssignmentPolicy object.  The request will include a reference to the accessPackage that will contain this policy, which must already exist. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AccessPackageAssignmentPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AccessPackageAssignmentPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AssignmentPoliciesRequestBuilder WithUrl(string rawUrl) {
            return new AssignmentPoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, retrieve a list of accessPackageAssignmentPolicy objects. If the delegated user is in a directory role, the resulting list includes all the assignment policies that the caller has access to read, across all catalogs and access packages. If the delegated user is an access package manager or catalog owner, they should instead retrieve the policies for the access packages they can read with list accessPackages by including $expand=accessPackageAssignmentPolicies as a query parameter. This API is available in the following national cloud deployments.
        /// </summary>
        public class AssignmentPoliciesRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AssignmentPoliciesRequestBuilderGetRequestConfiguration : RequestConfiguration<AssignmentPoliciesRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AssignmentPoliciesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
