// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.TermStore;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm
{
    /// <summary>
    /// Provides operations to manage the fromTerm property of the microsoft.graph.termStore.relation entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FromTermRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FromTermRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/termStores/{store%2Did}/groups/{group%2Did1}/sets/{set%2Did}/terms/{term%2Did}/relations/{relation%2Did}/fromTerm{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FromTermRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/termStores/{store%2Did}/groups/{group%2Did1}/sets/{set%2Did}/terms/{term%2Did}/relations/{relation%2Did}/fromTerm{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TermStore.Term"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TermStore.Term?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder.FromTermRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TermStore.Term> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder.FromTermRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TermStore.Term>(requestInfo, global::Microsoft.Graph.Models.TermStore.Term.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder.FromTermRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder.FromTermRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FromTermRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FromTermRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Groups.Item.Sets.Item.Terms.Item.Relations.Item.FromTerm.FromTermRequestBuilder.FromTermRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
