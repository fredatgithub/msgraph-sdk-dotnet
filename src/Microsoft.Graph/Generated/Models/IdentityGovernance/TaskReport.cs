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
    public partial class TaskReport : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date time that the associated run completed. Value is null if the run has not completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task failed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? FailedUsersCount
        {
            get { return BackingStore?.Get<int?>("failedUsersCount"); }
            set { BackingStore?.Set("failedUsersCount", value); }
        }
        /// <summary>The date and time that the task report was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The processingStatus property</summary>
        public global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus? ProcessingStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The unique identifier of the associated run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunId
        {
            get { return BackingStore?.Get<string?>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#nullable restore
#else
        public string RunId
        {
            get { return BackingStore?.Get<string>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#endif
        /// <summary>The date time that the associated run started. Value is null if the run has not started.</summary>
        public DateTimeOffset? StartedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task succeeded.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? SuccessfulUsersCount
        {
            get { return BackingStore?.Get<int?>("successfulUsersCount"); }
            set { BackingStore?.Set("successfulUsersCount", value); }
        }
        /// <summary>The task property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskObject? Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject?>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskObject Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#endif
        /// <summary>The taskDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition? TaskDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition?>("taskDefinition"); }
            set { BackingStore?.Set("taskDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition TaskDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition>("taskDefinition"); }
            set { BackingStore?.Set("taskDefinition", value); }
        }
#endif
        /// <summary>The related lifecycle workflow taskProcessingResults.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>? TaskProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>?>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult> TaskProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#endif
        /// <summary>The total number of users in the run execution for which the associated task was scheduled to execute.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? TotalUsersCount
        {
            get { return BackingStore?.Get<int?>("totalUsersCount"); }
            set { BackingStore?.Set("totalUsersCount", value); }
        }
        /// <summary>The number of users in the run execution for which the associated task is queued, in progress, or canceled.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? UnprocessedUsersCount
        {
            get { return BackingStore?.Get<int?>("unprocessedUsersCount"); }
            set { BackingStore?.Set("unprocessedUsersCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.TaskReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.TaskReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.TaskReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "processingStatus", n => { ProcessingStatus = n.GetEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>(); } },
                { "runId", n => { RunId = n.GetStringValue(); } },
                { "startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                { "successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                { "task", n => { Task = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>(global::Microsoft.Graph.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
                { "taskDefinition", n => { TaskDefinition = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition>(global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition.CreateFromDiscriminatorValue); } },
                { "taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>(global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                { "unprocessedUsersCount", n => { UnprocessedUsersCount = n.GetIntValue(); } },
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
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteStringValue("runId", RunId);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>("task", Task);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskDefinition>("taskDefinition", TaskDefinition);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteIntValue("unprocessedUsersCount", UnprocessedUsersCount);
        }
    }
}
#pragma warning restore CS0618
