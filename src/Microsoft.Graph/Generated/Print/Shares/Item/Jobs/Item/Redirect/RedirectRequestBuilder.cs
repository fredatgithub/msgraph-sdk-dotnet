// <auto-generated/>
#pragma warning disable CS0618
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
namespace Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect
{
    /// <summary>
    /// Provides operations to call the redirect method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RedirectRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RedirectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/shares/{printerShare%2Did}/jobs/{printJob%2Did}/redirect", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RedirectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/shares/{printerShare%2Did}/jobs/{printJob%2Did}/redirect", rawUrl)
        {
        }
        /// <summary>
        /// Redirect a print job to a different printer. Redirecting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.  For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/printjob-redirect?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrintJob"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.PrintJob?> PostAsync(global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.PrintJob> PostAsync(global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.PrintJob>(requestInfo, global::Microsoft.Graph.Models.PrintJob.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Redirect a print job to a different printer. Redirecting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.  For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Print.Shares.Item.Jobs.Item.Redirect.RedirectRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class RedirectRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
