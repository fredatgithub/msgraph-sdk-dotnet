// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.Ref {
    /// <summary>
    /// Provides operations to manage the collection of servicePrincipal entities.
    /// </summary>
    public class RefRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/homeRealmDiscoveryPolicies/{homeRealmDiscoveryPolicy%2Did}/$ref{?%40id*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/homeRealmDiscoveryPolicies/{homeRealmDiscoveryPolicy%2Did}/$ref{?%40id*}", rawUrl) {
        }
        /// <summary>
        /// Remove a homeRealmDiscoveryPolicy from a servicePrincipal. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-delete-homerealmdiscoverypolicies?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove a homeRealmDiscoveryPolicy from a servicePrincipal. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder WithUrl(string rawUrl) {
            return new RefRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Remove a homeRealmDiscoveryPolicy from a servicePrincipal. This API is available in the following national cloud deployments.
        /// </summary>
        public class RefRequestBuilderDeleteQueryParameters {
            /// <summary>Delete Uri</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%40id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("%40id")]
            public string Id { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RefRequestBuilderDeleteRequestConfiguration : RequestConfiguration<RefRequestBuilderDeleteQueryParameters> {
        }
    }
}
