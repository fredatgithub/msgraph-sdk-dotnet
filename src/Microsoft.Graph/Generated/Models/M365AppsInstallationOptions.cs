// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class M365AppsInstallationOptions : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appsForMac property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AppsInstallationOptionsForMac? AppsForMac
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppsInstallationOptionsForMac?>("appsForMac"); }
            set { BackingStore?.Set("appsForMac", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AppsInstallationOptionsForMac AppsForMac
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppsInstallationOptionsForMac>("appsForMac"); }
            set { BackingStore?.Set("appsForMac", value); }
        }
#endif
        /// <summary>The appsForWindows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows? AppsForWindows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows?>("appsForWindows"); }
            set { BackingStore?.Set("appsForWindows", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows AppsForWindows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows>("appsForWindows"); }
            set { BackingStore?.Set("appsForWindows", value); }
        }
#endif
        /// <summary>The updateChannel property</summary>
        public global::Microsoft.Graph.Models.AppsUpdateChannelType? UpdateChannel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppsUpdateChannelType?>("updateChannel"); }
            set { BackingStore?.Set("updateChannel", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.M365AppsInstallationOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.M365AppsInstallationOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.M365AppsInstallationOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appsForMac", n => { AppsForMac = n.GetObjectValue<global::Microsoft.Graph.Models.AppsInstallationOptionsForMac>(global::Microsoft.Graph.Models.AppsInstallationOptionsForMac.CreateFromDiscriminatorValue); } },
                { "appsForWindows", n => { AppsForWindows = n.GetObjectValue<global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows>(global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows.CreateFromDiscriminatorValue); } },
                { "updateChannel", n => { UpdateChannel = n.GetEnumValue<global::Microsoft.Graph.Models.AppsUpdateChannelType>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AppsInstallationOptionsForMac>("appsForMac", AppsForMac);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AppsInstallationOptionsForWindows>("appsForWindows", AppsForWindows);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AppsUpdateChannelType>("updateChannel", UpdateChannel);
        }
    }
}
#pragma warning restore CS0618
