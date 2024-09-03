// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class NicEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.IpEvidence? IpAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IpEvidence?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.IpEvidence IpAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IpEvidence>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The macAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress
        {
            get { return BackingStore?.Get<string?>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#nullable restore
#else
        public string MacAddress
        {
            get { return BackingStore?.Get<string>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#endif
        /// <summary>The vlans property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Vlans
        {
            get { return BackingStore?.Get<List<string>?>("vlans"); }
            set { BackingStore?.Set("vlans", value); }
        }
#nullable restore
#else
        public List<string> Vlans
        {
            get { return BackingStore?.Get<List<string>>("vlans"); }
            set { BackingStore?.Set("vlans", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.NicEvidence"/> and sets the default values.
        /// </summary>
        public NicEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.nicEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.NicEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.NicEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.NicEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "ipAddress", n => { IpAddress = n.GetObjectValue<global::Microsoft.Graph.Models.Security.IpEvidence>(global::Microsoft.Graph.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "macAddress", n => { MacAddress = n.GetStringValue(); } },
                { "vlans", n => { Vlans = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.IpEvidence>("ipAddress", IpAddress);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("vlans", Vlans);
        }
    }
}
#pragma warning restore CS0618
