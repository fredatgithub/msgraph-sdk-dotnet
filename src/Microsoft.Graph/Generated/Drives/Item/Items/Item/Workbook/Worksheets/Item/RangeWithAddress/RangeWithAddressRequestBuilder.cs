// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.BoundingRectWithAnotherRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.CellWithRowWithColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Clear;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnWithColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfter;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfterWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBefore;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBeforeWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Delete;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Format;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Insert;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.IntersectionWithAnotherRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastCell;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Merge;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.OffsetRangeWithRowOffsetWithColumnOffset;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ResizedRangeWithDeltaRowsWithDeltaColumns;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowWithRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAbove;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAboveWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelowWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Sort;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Unmerge;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRangeWithValuesOnly;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.VisibleView;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Worksheet;
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
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress
{
    /// <summary>
    /// Provides operations to call the range method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RangeWithAddressRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clear method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Clear.ClearRequestBuilder Clear
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsAfter method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfter.ColumnsAfterRequestBuilder ColumnsAfter
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsBefore method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBefore.ColumnsBeforeRequestBuilder ColumnsBefore
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delete method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Delete.DeleteRequestBuilder DeletePath
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Delete.DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireColumn method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireColumn.EntireColumnRequestBuilder EntireColumn
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireColumn.EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireRow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireRow.EntireRowRequestBuilder EntireRow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.EntireRow.EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the insert method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Insert.InsertRequestBuilder Insert
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Insert.InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastCell method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastCell.LastCellRequestBuilder LastCell
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastCell.LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastColumn method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastColumn.LastColumnRequestBuilder LastColumn
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastColumn.LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastRow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastRow.LastRowRequestBuilder LastRow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.LastRow.LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the merge method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Merge.MergeRequestBuilder Merge
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsAbove method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAbove.RowsAboveRequestBuilder RowsAbove
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAbove.RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsBelow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelow.RowsBelowRequestBuilder RowsBelow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelow.RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmerge method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Unmerge.UnmergeRequestBuilder Unmerge
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Unmerge.UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usedRange method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRange.UsedRangeRequestBuilder UsedRange
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRange.UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the visibleView method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.VisibleView.VisibleViewRequestBuilder VisibleView
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.VisibleView.VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? column, int? row)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, column, row);
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnWithColumn.ColumnWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnWithColumn.ColumnWithColumnRequestBuilder ColumnWithColumn(int? column)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ColumnWithColumn.ColumnWithColumnRequestBuilder(PathParameters, RequestAdapter, column);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RangeWithAddressRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="address">Usage: address=&apos;{address}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RangeWithAddressRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string address = "") : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/range(address='{address}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(address)) PathParameters.Add("address", address);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RangeWithAddressRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RangeWithAddressRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/range(address='{address}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function range
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookRange"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.WorkbookRange?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.WorkbookRange> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.WorkbookRange>(requestInfo, global::Microsoft.Graph.Models.WorkbookRange.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the intersection method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder"/></returns>
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? columnOffset, int? rowOffset)
        {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, columnOffset, rowOffset);
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder"/></returns>
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaColumns, int? deltaRows)
        {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaColumns, deltaRows);
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAboveWithCount.RowsAboveWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAboveWithCount.RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelowWithCount.RowsBelowWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelowWithCount.RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowWithRow.RowWithRowRequestBuilder"/></returns>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowWithRow.RowWithRowRequestBuilder RowWithRow(int? row)
        {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RowWithRow.RowWithRowRequestBuilder(PathParameters, RequestAdapter, row);
        }
        /// <summary>
        /// Invoke function range
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
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/></returns>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly)
        {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RangeWithAddressRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RangeWithAddressRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress.RangeWithAddressRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class RangeWithAddressRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
