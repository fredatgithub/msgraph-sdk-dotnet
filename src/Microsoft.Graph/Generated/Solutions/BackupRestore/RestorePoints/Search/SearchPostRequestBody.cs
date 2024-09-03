// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Solutions.BackupRestore.RestorePoints.Search
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class SearchPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The artifactQuery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ArtifactQuery? ArtifactQuery
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ArtifactQuery?>("artifactQuery"); }
            set { BackingStore?.Set("artifactQuery", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ArtifactQuery ArtifactQuery
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ArtifactQuery>("artifactQuery"); }
            set { BackingStore?.Set("artifactQuery", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The protectionTimePeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TimePeriod? ProtectionTimePeriod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TimePeriod?>("protectionTimePeriod"); }
            set { BackingStore?.Set("protectionTimePeriod", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TimePeriod ProtectionTimePeriod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TimePeriod>("protectionTimePeriod"); }
            set { BackingStore?.Set("protectionTimePeriod", value); }
        }
#endif
        /// <summary>The protectionUnitIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProtectionUnitIds
        {
            get { return BackingStore?.Get<List<string>?>("protectionUnitIds"); }
            set { BackingStore?.Set("protectionUnitIds", value); }
        }
#nullable restore
#else
        public List<string> ProtectionUnitIds
        {
            get { return BackingStore?.Get<List<string>>("protectionUnitIds"); }
            set { BackingStore?.Set("protectionUnitIds", value); }
        }
#endif
        /// <summary>The restorePointPreference property</summary>
        public global::Microsoft.Graph.Models.RestorePointPreference? RestorePointPreference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RestorePointPreference?>("restorePointPreference"); }
            set { BackingStore?.Set("restorePointPreference", value); }
        }
        /// <summary>The tags property</summary>
        public global::Microsoft.Graph.Models.RestorePointTags? Tags
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RestorePointTags?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Solutions.BackupRestore.RestorePoints.Search.SearchPostRequestBody"/> and sets the default values.
        /// </summary>
        public SearchPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Solutions.BackupRestore.RestorePoints.Search.SearchPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Solutions.BackupRestore.RestorePoints.Search.SearchPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Solutions.BackupRestore.RestorePoints.Search.SearchPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "artifactQuery", n => { ArtifactQuery = n.GetObjectValue<global::Microsoft.Graph.Models.ArtifactQuery>(global::Microsoft.Graph.Models.ArtifactQuery.CreateFromDiscriminatorValue); } },
                { "protectionTimePeriod", n => { ProtectionTimePeriod = n.GetObjectValue<global::Microsoft.Graph.Models.TimePeriod>(global::Microsoft.Graph.Models.TimePeriod.CreateFromDiscriminatorValue); } },
                { "protectionUnitIds", n => { ProtectionUnitIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "restorePointPreference", n => { RestorePointPreference = n.GetEnumValue<global::Microsoft.Graph.Models.RestorePointPreference>(); } },
                { "tags", n => { Tags = n.GetEnumValue<global::Microsoft.Graph.Models.RestorePointTags>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ArtifactQuery>("artifactQuery", ArtifactQuery);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TimePeriod>("protectionTimePeriod", ProtectionTimePeriod);
            writer.WriteCollectionOfPrimitiveValues<string>("protectionUnitIds", ProtectionUnitIds);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RestorePointPreference>("restorePointPreference", RestorePointPreference);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RestorePointTags>("tags", Tags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
