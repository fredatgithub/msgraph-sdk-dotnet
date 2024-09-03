// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.SeriesSum
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class SeriesSumPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The coefficients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Coefficients
        {
            get { return BackingStore?.Get<UntypedNode?>("coefficients"); }
            set { BackingStore?.Set("coefficients", value); }
        }
#nullable restore
#else
        public UntypedNode Coefficients
        {
            get { return BackingStore?.Get<UntypedNode>("coefficients"); }
            set { BackingStore?.Set("coefficients", value); }
        }
#endif
        /// <summary>The m property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? M
        {
            get { return BackingStore?.Get<UntypedNode?>("m"); }
            set { BackingStore?.Set("m", value); }
        }
#nullable restore
#else
        public UntypedNode M
        {
            get { return BackingStore?.Get<UntypedNode>("m"); }
            set { BackingStore?.Set("m", value); }
        }
#endif
        /// <summary>The n property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? N
        {
            get { return BackingStore?.Get<UntypedNode?>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#nullable restore
#else
        public UntypedNode N
        {
            get { return BackingStore?.Get<UntypedNode>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? X
        {
            get { return BackingStore?.Get<UntypedNode?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public UntypedNode X
        {
            get { return BackingStore?.Get<UntypedNode>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.SeriesSum.SeriesSumPostRequestBody"/> and sets the default values.
        /// </summary>
        public SeriesSumPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.SeriesSum.SeriesSumPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.SeriesSum.SeriesSumPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.SeriesSum.SeriesSumPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "coefficients", n => { Coefficients = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "m", n => { M = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "n", n => { N = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "x", n => { X = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("coefficients", Coefficients);
            writer.WriteObjectValue<UntypedNode>("m", M);
            writer.WriteObjectValue<UntypedNode>("n", N);
            writer.WriteObjectValue<UntypedNode>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
