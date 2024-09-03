// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Places.Count;
using Microsoft.Graph.Places.GraphRoom;
using Microsoft.Graph.Places.GraphRoomList;
using Microsoft.Graph.Places.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Places
{
    /// <summary>
    /// Builds and executes requests for operations under \places
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PlacesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Places.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Places.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to room.</summary>
        public global::Microsoft.Graph.Places.GraphRoom.GraphRoomRequestBuilder GraphRoom
        {
            get => new global::Microsoft.Graph.Places.GraphRoom.GraphRoomRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to roomList.</summary>
        public global::Microsoft.Graph.Places.GraphRoomList.GraphRoomListRequestBuilder GraphRoomList
        {
            get => new global::Microsoft.Graph.Places.GraphRoomList.GraphRoomListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of place entities.</summary>
        /// <param name="position">The unique identifier of place</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Places.Item.PlaceItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Places.Item.PlaceItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("place%2Did", position);
                return new global::Microsoft.Graph.Places.Item.PlaceItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Places.PlacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlacesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Places.PlacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/places", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
