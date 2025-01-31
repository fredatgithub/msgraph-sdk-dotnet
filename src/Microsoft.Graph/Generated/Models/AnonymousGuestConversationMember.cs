// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class AnonymousGuestConversationMember : global::Microsoft.Graph.Models.ConversationMember, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique ID that represents the user. Note: This ID can change if the user leaves and rejoins the meeting, or joins from a different device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnonymousGuestId
        {
            get { return BackingStore?.Get<string?>("anonymousGuestId"); }
            set { BackingStore?.Set("anonymousGuestId", value); }
        }
#nullable restore
#else
        public string AnonymousGuestId
        {
            get { return BackingStore?.Get<string>("anonymousGuestId"); }
            set { BackingStore?.Set("anonymousGuestId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AnonymousGuestConversationMember"/> and sets the default values.
        /// </summary>
        public AnonymousGuestConversationMember() : base()
        {
            OdataType = "#microsoft.graph.anonymousGuestConversationMember";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AnonymousGuestConversationMember"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AnonymousGuestConversationMember CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AnonymousGuestConversationMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "anonymousGuestId", n => { AnonymousGuestId = n.GetStringValue(); } },
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
            writer.WriteStringValue("anonymousGuestId", AnonymousGuestId);
        }
    }
}
#pragma warning restore CS0618
