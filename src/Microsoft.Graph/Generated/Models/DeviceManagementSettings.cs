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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class DeviceManagementSettings : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The number of days a device is allowed to go without checking in to remain compliant.</summary>
        public int? DeviceComplianceCheckinThresholdDays
        {
            get { return BackingStore?.Get<int?>("deviceComplianceCheckinThresholdDays"); }
            set { BackingStore?.Set("deviceComplianceCheckinThresholdDays", value); }
        }
        /// <summary>Is feature enabled or not for scheduled action for rule.</summary>
        public bool? IsScheduledActionEnabled
        {
            get { return BackingStore?.Get<bool?>("isScheduledActionEnabled"); }
            set { BackingStore?.Set("isScheduledActionEnabled", value); }
        }
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
        /// <summary>Device should be noncompliant when there is no compliance policy targeted when this is true</summary>
        public bool? SecureByDefault
        {
            get { return BackingStore?.Get<bool?>("secureByDefault"); }
            set { BackingStore?.Set("secureByDefault", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.DeviceManagementSettings"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceManagementSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.DeviceManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceComplianceCheckinThresholdDays", n => { DeviceComplianceCheckinThresholdDays = n.GetIntValue(); } },
                { "isScheduledActionEnabled", n => { IsScheduledActionEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "secureByDefault", n => { SecureByDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceComplianceCheckinThresholdDays", DeviceComplianceCheckinThresholdDays);
            writer.WriteBoolValue("isScheduledActionEnabled", IsScheduledActionEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("secureByDefault", SecureByDefault);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
