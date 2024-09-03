// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class NetworkDays_IntlPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The endDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? EndDate
        {
            get { return BackingStore?.Get<UntypedNode?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
#nullable restore
#else
        public UntypedNode EndDate
        {
            get { return BackingStore?.Get<UntypedNode>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
#endif
        /// <summary>The holidays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Holidays
        {
            get { return BackingStore?.Get<UntypedNode?>("holidays"); }
            set { BackingStore?.Set("holidays", value); }
        }
#nullable restore
#else
        public UntypedNode Holidays
        {
            get { return BackingStore?.Get<UntypedNode>("holidays"); }
            set { BackingStore?.Set("holidays", value); }
        }
#endif
        /// <summary>The startDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StartDate
        {
            get { return BackingStore?.Get<UntypedNode?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#nullable restore
#else
        public UntypedNode StartDate
        {
            get { return BackingStore?.Get<UntypedNode>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#endif
        /// <summary>The weekend property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Weekend
        {
            get { return BackingStore?.Get<UntypedNode?>("weekend"); }
            set { BackingStore?.Set("weekend", value); }
        }
#nullable restore
#else
        public UntypedNode Weekend
        {
            get { return BackingStore?.Get<UntypedNode>("weekend"); }
            set { BackingStore?.Set("weekend", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlPostRequestBody"/> and sets the default values.
        /// </summary>
        public NetworkDays_IntlPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "endDate", n => { EndDate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "holidays", n => { Holidays = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "startDate", n => { StartDate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "weekend", n => { Weekend = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("endDate", EndDate);
            writer.WriteObjectValue<UntypedNode>("holidays", Holidays);
            writer.WriteObjectValue<UntypedNode>("startDate", StartDate);
            writer.WriteObjectValue<UntypedNode>("weekend", Weekend);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
