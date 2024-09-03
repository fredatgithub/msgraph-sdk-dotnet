// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Count;
using Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Item;
using Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Ref;
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
namespace Microsoft.Graph.Applications.Item.TokenIssuancePolicies
{
    /// <summary>
    /// Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.application entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class TokenIssuancePoliciesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Microsoft.Graph.applications.item.tokenIssuancePolicies.item collection</summary>
        /// <param name="position">The unique identifier of tokenIssuancePolicy</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Item.TokenIssuancePolicyItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Item.TokenIssuancePolicyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("tokenIssuancePolicy%2Did", position);
                return new global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.Item.TokenIssuancePolicyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenIssuancePoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenIssuancePolicies{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenIssuancePoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenIssuancePolicies{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List the tokenIssuancePolicy objects that are assigned to an application.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/application-list-tokenissuancepolicies?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TokenIssuancePolicyCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TokenIssuancePolicyCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder.TokenIssuancePoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TokenIssuancePolicyCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder.TokenIssuancePoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TokenIssuancePolicyCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.TokenIssuancePolicyCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the tokenIssuancePolicy objects that are assigned to an application.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder.TokenIssuancePoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder.TokenIssuancePoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the tokenIssuancePolicy objects that are assigned to an application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class TokenIssuancePoliciesRequestBuilderGetQueryParameters 
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
        public partial class TokenIssuancePoliciesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder.TokenIssuancePoliciesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
