// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.Format;
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
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex
{
    /// <summary>
    /// Provides operations to call the itemAt method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ItemAtWithIndexRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookChartPoint entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="index">Usage: index={index}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? index = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/{workbookChart%2Did}/series/{workbookChartSeries%2Did}/points/itemAt(index={index})", pathParameters)
        {
            if (index != null) PathParameters.Add("index", index);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/{workbookChart%2Did}/series/{workbookChartSeries%2Did}/points/itemAt(index={index})", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a point based on its position within the series.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chartpointscollection-itemat?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookChartPoint"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.WorkbookChartPoint?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.WorkbookChartPoint> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.WorkbookChartPoint>(requestInfo, global::Microsoft.Graph.Models.WorkbookChartPoint.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a point based on its position within the series.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.ItemAtWithIndexRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.ItemAtWithIndex.ItemAtWithIndexRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ItemAtWithIndexRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
