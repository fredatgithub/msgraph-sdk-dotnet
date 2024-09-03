// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn
{
    /// <summary>
    /// Provides operations to call the filterByCurrentUser method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FilterByCurrentUserWithOnRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="on">Usage: on=&apos;{on}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilterByCurrentUserWithOnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string on = "") : base(requestAdapter, "{+baseurl}/identityGovernance/appConsent/appConsentRequests/filterByCurrentUser(on='{on}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(on)) PathParameters.Add("on", on);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilterByCurrentUserWithOnRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/appConsent/appConsentRequests/filterByCurrentUser(on='{on}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a collection of appConsentRequest objects for which the current user is the reviewer and the status of the userConsentRequest for accessing the specified app is InProgress.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/appconsentrequest-filterbycurrentuser?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnGetResponse?> GetAsFilterByCurrentUserWithOnGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnGetResponse> GetAsFilterByCurrentUserWithOnGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnGetResponse>(requestInfo, global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a collection of appConsentRequest objects for which the current user is the reviewer and the status of the userConsentRequest for accessing the specified app is InProgress.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/appconsentrequest-filterbycurrentuser?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsFilterByCurrentUserWithOnGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnResponse>(requestInfo, global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a collection of appConsentRequest objects for which the current user is the reviewer and the status of the userConsentRequest for accessing the specified app is InProgress.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a collection of appConsentRequest objects for which the current user is the reviewer and the status of the userConsentRequest for accessing the specified app is InProgress.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FilterByCurrentUserWithOnRequestBuilderGetQueryParameters 
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
        public partial class FilterByCurrentUserWithOnRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AppConsent.AppConsentRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder.FilterByCurrentUserWithOnRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
