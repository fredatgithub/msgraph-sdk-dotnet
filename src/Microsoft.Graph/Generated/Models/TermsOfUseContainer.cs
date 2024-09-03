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
    public partial class TermsOfUseContainer : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the current status of a user&apos;s response to a company&apos;s customizable terms of use agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AgreementAcceptance>? AgreementAcceptances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementAcceptance>?>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AgreementAcceptance> AgreementAcceptances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementAcceptance>>("agreementAcceptances"); }
            set { BackingStore?.Set("agreementAcceptances", value); }
        }
#endif
        /// <summary>Represents a tenant&apos;s customizable terms of use agreement that&apos;s created and managed with Microsoft Entra ID Governance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Agreement>? Agreements
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Agreement>?>("agreements"); }
            set { BackingStore?.Set("agreements", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Agreement> Agreements
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Agreement>>("agreements"); }
            set { BackingStore?.Set("agreements", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TermsOfUseContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TermsOfUseContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TermsOfUseContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementAcceptance>(global::Microsoft.Graph.Models.AgreementAcceptance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "agreements", n => { Agreements = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Agreement>(global::Microsoft.Graph.Models.Agreement.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Agreement>("agreements", Agreements);
        }
    }
}
#pragma warning restore CS0618
