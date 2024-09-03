// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ConditionalAccessGrantControls : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The authenticationStrength property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AuthenticationStrengthPolicy? AuthenticationStrength
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthPolicy?>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AuthenticationStrengthPolicy AuthenticationStrength
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthPolicy>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConditionalAccessGrantControl?>? BuiltInControls
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessGrantControl?>?>("builtInControls"); }
            set { BackingStore?.Set("builtInControls", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConditionalAccessGrantControl?> BuiltInControls
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessGrantControl?>>("builtInControls"); }
            set { BackingStore?.Set("builtInControls", value); }
        }
#endif
        /// <summary>List of custom controls IDs required by the policy. For more information, see Custom controls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomAuthenticationFactors
        {
            get { return BackingStore?.Get<List<string>?>("customAuthenticationFactors"); }
            set { BackingStore?.Set("customAuthenticationFactors", value); }
        }
#nullable restore
#else
        public List<string> CustomAuthenticationFactors
        {
            get { return BackingStore?.Get<List<string>>("customAuthenticationFactors"); }
            set { BackingStore?.Set("customAuthenticationFactors", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Defines the relationship of the grant controls. Possible values: AND, OR.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator
        {
            get { return BackingStore?.Get<string?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#nullable restore
#else
        public string Operator
        {
            get { return BackingStore?.Get<string>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#endif
        /// <summary>List of terms of use IDs required by the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TermsOfUse
        {
            get { return BackingStore?.Get<List<string>?>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#nullable restore
#else
        public List<string> TermsOfUse
        {
            get { return BackingStore?.Get<List<string>>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ConditionalAccessGrantControls"/> and sets the default values.
        /// </summary>
        public ConditionalAccessGrantControls()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ConditionalAccessGrantControls"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ConditionalAccessGrantControls CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ConditionalAccessGrantControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticationStrength", n => { AuthenticationStrength = n.GetObjectValue<global::Microsoft.Graph.Models.AuthenticationStrengthPolicy>(global::Microsoft.Graph.Models.AuthenticationStrengthPolicy.CreateFromDiscriminatorValue); } },
                { "builtInControls", n => { BuiltInControls = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.ConditionalAccessGrantControl>()?.AsList(); } },
                { "customAuthenticationFactors", n => { CustomAuthenticationFactors = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operator", n => { Operator = n.GetStringValue(); } },
                { "termsOfUse", n => { TermsOfUse = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AuthenticationStrengthPolicy>("authenticationStrength", AuthenticationStrength);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.ConditionalAccessGrantControl>("builtInControls", BuiltInControls);
            writer.WriteCollectionOfPrimitiveValues<string>("customAuthenticationFactors", CustomAuthenticationFactors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteCollectionOfPrimitiveValues<string>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
