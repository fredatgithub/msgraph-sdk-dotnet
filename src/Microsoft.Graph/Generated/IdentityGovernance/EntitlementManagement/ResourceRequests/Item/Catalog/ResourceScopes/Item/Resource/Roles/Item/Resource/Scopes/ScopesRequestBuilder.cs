// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Count;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes
{
    /// <summary>
    /// Provides operations to manage the scopes property of the microsoft.graph.accessPackageResource entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ScopesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the scopes property of the microsoft.graph.accessPackageResource entity.</summary>
        /// <param name="position">The unique identifier of accessPackageResourceScope</param>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Item.AccessPackageResourceScopeItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Item.AccessPackageResourceScopeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("accessPackageResourceScope%2Did1", position);
                return new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.Item.AccessPackageResourceScopeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScopesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest%2Did}/catalog/resourceScopes/{accessPackageResourceScope%2Did}/resource/roles/{accessPackageResourceRole%2Did}/resource/scopes{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScopesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest%2Did}/catalog/resourceScopes/{accessPackageResourceScope%2Did}/resource/roles/{accessPackageResourceRole%2Did}/resource/scopes{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Read-only. Nullable. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageResourceScopeCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.AccessPackageResourceScopeCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder.ScopesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.AccessPackageResourceScopeCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder.ScopesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.AccessPackageResourceScopeCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.AccessPackageResourceScopeCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to scopes for identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageResourceScope"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.AccessPackageResourceScope?> PostAsync(global::Microsoft.Graph.Models.AccessPackageResourceScope body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.AccessPackageResourceScope> PostAsync(global::Microsoft.Graph.Models.AccessPackageResourceScope body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.AccessPackageResourceScope>(requestInfo, global::Microsoft.Graph.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read-only. Nullable. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder.ScopesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder.ScopesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to scopes for identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.AccessPackageResourceScope body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.AccessPackageResourceScope body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Read-only. Nullable. Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ScopesRequestBuilderGetQueryParameters 
        {
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ScopesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.Item.Catalog.ResourceScopes.Item.Resource.Roles.Item.Resource.Scopes.ScopesRequestBuilder.ScopesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ScopesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
