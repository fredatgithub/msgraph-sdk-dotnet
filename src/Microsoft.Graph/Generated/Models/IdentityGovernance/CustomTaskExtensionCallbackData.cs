// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class CustomTaskExtensionCallbackData : global::Microsoft.Graph.Models.CustomExtensionData, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Operation status that&apos;s provided by the Azure Logic App indicating whenever the Azure Logic App has run successfully or not. Supported values: completed, failed, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionOperationStatus? OperationStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionOperationStatus?>("operationStatus"); }
            set { BackingStore?.Set("operationStatus", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCallbackData"/> and sets the default values.
        /// </summary>
        public CustomTaskExtensionCallbackData() : base()
        {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtensionCallbackData";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCallbackData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCallbackData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCallbackData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "operationStatus", n => { OperationStatus = n.GetEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionOperationStatus>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionOperationStatus>("operationStatus", OperationStatus);
        }
    }
}
#pragma warning restore CS0618
