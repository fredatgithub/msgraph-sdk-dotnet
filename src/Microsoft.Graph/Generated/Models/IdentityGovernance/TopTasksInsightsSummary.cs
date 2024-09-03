// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class TopTasksInsightsSummary : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Count of failed runs of the task.</summary>
        public int? FailedTasks
        {
            get { return BackingStore?.Get<int?>("failedTasks"); }
            set { BackingStore?.Set("failedTasks", value); }
        }
        /// <summary>Count of failed users who were processed by the task.</summary>
        public int? FailedUsers
        {
            get { return BackingStore?.Get<int?>("failedUsers"); }
            set { BackingStore?.Set("failedUsers", value); }
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
        /// <summary>Count of successful runs of the task.</summary>
        public int? SuccessfulTasks
        {
            get { return BackingStore?.Get<int?>("successfulTasks"); }
            set { BackingStore?.Set("successfulTasks", value); }
        }
        /// <summary>Count of successful users processed by the task.</summary>
        public int? SuccessfulUsers
        {
            get { return BackingStore?.Get<int?>("successfulUsers"); }
            set { BackingStore?.Set("successfulUsers", value); }
        }
        /// <summary>The name of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskDefinitionDisplayName
        {
            get { return BackingStore?.Get<string?>("taskDefinitionDisplayName"); }
            set { BackingStore?.Set("taskDefinitionDisplayName", value); }
        }
#nullable restore
#else
        public string TaskDefinitionDisplayName
        {
            get { return BackingStore?.Get<string>("taskDefinitionDisplayName"); }
            set { BackingStore?.Set("taskDefinitionDisplayName", value); }
        }
#endif
        /// <summary>The task ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskDefinitionId
        {
            get { return BackingStore?.Get<string?>("taskDefinitionId"); }
            set { BackingStore?.Set("taskDefinitionId", value); }
        }
#nullable restore
#else
        public string TaskDefinitionId
        {
            get { return BackingStore?.Get<string>("taskDefinitionId"); }
            set { BackingStore?.Set("taskDefinitionId", value); }
        }
#endif
        /// <summary>Count of total runs of the task.</summary>
        public int? TotalTasks
        {
            get { return BackingStore?.Get<int?>("totalTasks"); }
            set { BackingStore?.Set("totalTasks", value); }
        }
        /// <summary>Count of total users processed by the task.</summary>
        public int? TotalUsers
        {
            get { return BackingStore?.Get<int?>("totalUsers"); }
            set { BackingStore?.Set("totalUsers", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.TopTasksInsightsSummary"/> and sets the default values.
        /// </summary>
        public TopTasksInsightsSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.TopTasksInsightsSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.IdentityGovernance.TopTasksInsightsSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.TopTasksInsightsSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                { "failedUsers", n => { FailedUsers = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "successfulTasks", n => { SuccessfulTasks = n.GetIntValue(); } },
                { "successfulUsers", n => { SuccessfulUsers = n.GetIntValue(); } },
                { "taskDefinitionDisplayName", n => { TaskDefinitionDisplayName = n.GetStringValue(); } },
                { "taskDefinitionId", n => { TaskDefinitionId = n.GetStringValue(); } },
                { "totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                { "totalUsers", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteIntValue("failedUsers", FailedUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulTasks", SuccessfulTasks);
            writer.WriteIntValue("successfulUsers", SuccessfulUsers);
            writer.WriteStringValue("taskDefinitionDisplayName", TaskDefinitionDisplayName);
            writer.WriteStringValue("taskDefinitionId", TaskDefinitionId);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
