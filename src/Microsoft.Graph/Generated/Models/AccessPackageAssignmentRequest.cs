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
    public partial class AccessPackageAssignmentRequest : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable.  Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackage? AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackage?>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackage AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackage>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#endif
        /// <summary>Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessPackageAnswer>? Answers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageAnswer>?>("answers"); }
            set { BackingStore?.Set("answers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessPackageAnswer> Answers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageAnswer>>("answers"); }
            set { BackingStore?.Set("answers", value); }
        }
#endif
        /// <summary>For a requestType of userAdd or adminAdd, this is an access package assignment requested to be created. For a requestType of userRemove, adminRemove or systemRemove, this has the id property of an existing assignment to be removed.   Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageAssignment? Assignment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignment?>("assignment"); }
            set { BackingStore?.Set("assignment", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageAssignment Assignment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignment>("assignment"); }
            set { BackingStore?.Set("assignment", value); }
        }
#endif
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Information about all the custom extension calls that were made during the access package assignment workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance>?>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance> CustomExtensionCalloutInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance>>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#endif
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageSubject? Requestor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageSubject?>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageSubject Requestor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageSubject>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#endif
        /// <summary>The type of the request. The possible values are: notSpecified, userAdd, UserExtend, userUpdate, userRemove, adminAdd, adminUpdate, adminRemove, systemAdd, systemUpdate, systemRemove, onBehalfAdd (not supported), unknownFutureValue. Requests from the user have a requestType of userAdd, userUpdate, or userRemove. This property can&apos;t be changed once set.</summary>
        public global::Microsoft.Graph.Models.AccessPackageRequestType? RequestType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageRequestType?>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
        /// <summary>The range of dates that access is to be assigned to the requestor. This property can&apos;t be changed once set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EntitlementManagementSchedule? Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EntitlementManagementSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EntitlementManagementSchedule Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EntitlementManagementSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The state of the request. The possible values are: submitted, pendingApproval, delivering, delivered, deliveryFailed, denied, scheduled, canceled, partiallyDelivered, unknownFutureValue. Read-only. Supports $filter (eq).</summary>
        public global::Microsoft.Graph.Models.AccessPackageRequestState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageRequestState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>More information on the request processing status. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageAssignmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessPackageAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessPackageAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackage>(global::Microsoft.Graph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "answers", n => { Answers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageAnswer>(global::Microsoft.Graph.Models.AccessPackageAnswer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignment", n => { Assignment = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignment>(global::Microsoft.Graph.Models.AccessPackageAssignment.CreateFromDiscriminatorValue); } },
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance>(global::Microsoft.Graph.Models.CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestType", n => { RequestType = n.GetEnumValue<global::Microsoft.Graph.Models.AccessPackageRequestType>(); } },
                { "requestor", n => { Requestor = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageSubject>(global::Microsoft.Graph.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Microsoft.Graph.Models.EntitlementManagementSchedule>(global::Microsoft.Graph.Models.EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.AccessPackageRequestState>(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageAnswer>("answers", Answers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignment>("assignment", Assignment);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageSubject>("requestor", Requestor);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AccessPackageRequestType>("requestType", RequestType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AccessPackageRequestState>("state", State);
            writer.WriteStringValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
