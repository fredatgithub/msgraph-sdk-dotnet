// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Attachments;
using Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Extensions;
using Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Forward;
using Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.InReplyTo;
using Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Reply;
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
namespace Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item
{
    /// <summary>
    /// Provides operations to manage the posts property of the microsoft.graph.conversationThread entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PostItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.post entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Attachments.AttachmentsRequestBuilder Attachments
        {
            get => new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.post entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Extensions.ExtensionsRequestBuilder Extensions
        {
            get => new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the forward method.</summary>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Forward.ForwardRequestBuilder Forward
        {
            get => new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inReplyTo property of the microsoft.graph.post entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.InReplyTo.InReplyToRequestBuilder InReplyTo
        {
            get => new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.InReplyTo.InReplyToRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reply method.</summary>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Reply.ReplyRequestBuilder Reply
        {
            get => new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.Reply.ReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PostItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}/posts/{post%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PostItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}/posts/{post%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get posts from groups
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Post"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Post?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder.PostItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Post> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder.PostItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Post>(requestInfo, global::Microsoft.Graph.Models.Post.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get posts from groups
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder.PostItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder.PostItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get posts from groups
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PostItemRequestBuilderGetQueryParameters 
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
        public partial class PostItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Groups.Item.Threads.Item.Posts.Item.PostItemRequestBuilder.PostItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
