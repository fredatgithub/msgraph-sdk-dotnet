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
    public partial class Team : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of channels either hosted in or shared with the team (incoming channels).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Channel>? AllChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>?>("allChannels"); }
            set { BackingStore?.Set("allChannels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Channel> AllChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>>("allChannels"); }
            set { BackingStore?.Set("allChannels", value); }
        }
#endif
        /// <summary>The collection of channels and messages associated with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Channel>? Channels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>?>("channels"); }
            set { BackingStore?.Set("channels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Channel> Channels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>>("channels"); }
            set { BackingStore?.Set("channels", value); }
        }
#endif
        /// <summary>An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant&apos;s directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Classification
        {
            get { return BackingStore?.Get<string?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
#nullable restore
#else
        public string Classification
        {
            get { return BackingStore?.Get<string>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
#endif
        /// <summary>Timestamp at which the team was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>An optional description for the team. Maximum length: 1024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Settings to configure use of Giphy, memes, and stickers in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamFunSettings? FunSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamFunSettings?>("funSettings"); }
            set { BackingStore?.Set("funSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamFunSettings FunSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamFunSettings>("funSettings"); }
            set { BackingStore?.Set("funSettings", value); }
        }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Group? Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Group Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Settings to configure whether guests can create, update, or delete channels in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamGuestSettings? GuestSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamGuestSettings?>("guestSettings"); }
            set { BackingStore?.Set("guestSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamGuestSettings GuestSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamGuestSettings>("guestSettings"); }
            set { BackingStore?.Set("guestSettings", value); }
        }
#endif
        /// <summary>List of channels shared with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Channel>? IncomingChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>?>("incomingChannels"); }
            set { BackingStore?.Set("incomingChannels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Channel> IncomingChannels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Channel>>("incomingChannels"); }
            set { BackingStore?.Set("incomingChannels", value); }
        }
#endif
        /// <summary>The apps installed in this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamsAppInstallation>? InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAppInstallation>?>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamsAppInstallation> InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAppInstallation>>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#endif
        /// <summary>A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalId
        {
            get { return BackingStore?.Get<string?>("internalId"); }
            set { BackingStore?.Set("internalId", value); }
        }
#nullable restore
#else
        public string InternalId
        {
            get { return BackingStore?.Get<string>("internalId"); }
            set { BackingStore?.Set("internalId", value); }
        }
#endif
        /// <summary>Whether this team is in read-only mode.</summary>
        public bool? IsArchived
        {
            get { return BackingStore?.Get<bool?>("isArchived"); }
            set { BackingStore?.Set("isArchived", value); }
        }
        /// <summary>Members and owners of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConversationMember>? Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConversationMember>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConversationMember> Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConversationMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamMemberSettings? MemberSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamMemberSettings?>("memberSettings"); }
            set { BackingStore?.Set("memberSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamMemberSettings MemberSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamMemberSettings>("memberSettings"); }
            set { BackingStore?.Set("memberSettings", value); }
        }
#endif
        /// <summary>Settings to configure messaging and mentions in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamMessagingSettings? MessagingSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamMessagingSettings?>("messagingSettings"); }
            set { BackingStore?.Set("messagingSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamMessagingSettings MessagingSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamMessagingSettings>("messagingSettings"); }
            set { BackingStore?.Set("messagingSettings", value); }
        }
#endif
        /// <summary>The async operations that ran or are running on this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamsAsyncOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAsyncOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamsAsyncOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAsyncOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>A collection of permissions granted to apps to access the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>? PermissionGrants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>?>("permissionGrants"); }
            set { BackingStore?.Set("permissionGrants", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant> PermissionGrants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>>("permissionGrants"); }
            set { BackingStore?.Set("permissionGrants", value); }
        }
#endif
        /// <summary>The profile photo for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ProfilePhoto? Photo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProfilePhoto?>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ProfilePhoto Photo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProfilePhoto>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#endif
        /// <summary>The general channel for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Channel? PrimaryChannel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Channel?>("primaryChannel"); }
            set { BackingStore?.Set("primaryChannel", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Channel PrimaryChannel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Channel>("primaryChannel"); }
            set { BackingStore?.Set("primaryChannel", value); }
        }
#endif
        /// <summary>The schedule of shifts for this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Schedule? Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Schedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Schedule Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Schedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.</summary>
        public global::Microsoft.Graph.Models.TeamSpecialization? Specialization
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamSpecialization?>("specialization"); }
            set { BackingStore?.Set("specialization", value); }
        }
        /// <summary>Contains summary information about the team, including number of owners, members, and guests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamSummary? Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamSummary?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamSummary Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamSummary>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>The tags associated with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamworkTag>? Tags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkTag>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamworkTag> Tags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkTag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The template this team was created from. See available templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamsTemplate? Template
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsTemplate?>("template"); }
            set { BackingStore?.Set("template", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamsTemplate Template
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsTemplate>("template"); }
            set { BackingStore?.Set("template", value); }
        }
#endif
        /// <summary>The ID of the Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The visibility of the group and team. Defaults to Public.</summary>
        public global::Microsoft.Graph.Models.TeamVisibilityType? Visibility
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamVisibilityType?>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
        /// <summary>A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Team"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Team CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Team();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allChannels", n => { AllChannels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>(global::Microsoft.Graph.Models.Channel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "channels", n => { Channels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>(global::Microsoft.Graph.Models.Channel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "classification", n => { Classification = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "funSettings", n => { FunSettings = n.GetObjectValue<global::Microsoft.Graph.Models.TeamFunSettings>(global::Microsoft.Graph.Models.TeamFunSettings.CreateFromDiscriminatorValue); } },
                { "group", n => { Group = n.GetObjectValue<global::Microsoft.Graph.Models.Group>(global::Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                { "guestSettings", n => { GuestSettings = n.GetObjectValue<global::Microsoft.Graph.Models.TeamGuestSettings>(global::Microsoft.Graph.Models.TeamGuestSettings.CreateFromDiscriminatorValue); } },
                { "incomingChannels", n => { IncomingChannels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>(global::Microsoft.Graph.Models.Channel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAppInstallation>(global::Microsoft.Graph.Models.TeamsAppInstallation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "internalId", n => { InternalId = n.GetStringValue(); } },
                { "isArchived", n => { IsArchived = n.GetBoolValue(); } },
                { "memberSettings", n => { MemberSettings = n.GetObjectValue<global::Microsoft.Graph.Models.TeamMemberSettings>(global::Microsoft.Graph.Models.TeamMemberSettings.CreateFromDiscriminatorValue); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ConversationMember>(global::Microsoft.Graph.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messagingSettings", n => { MessagingSettings = n.GetObjectValue<global::Microsoft.Graph.Models.TeamMessagingSettings>(global::Microsoft.Graph.Models.TeamMessagingSettings.CreateFromDiscriminatorValue); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAsyncOperation>(global::Microsoft.Graph.Models.TeamsAsyncOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>(global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "photo", n => { Photo = n.GetObjectValue<global::Microsoft.Graph.Models.ProfilePhoto>(global::Microsoft.Graph.Models.ProfilePhoto.CreateFromDiscriminatorValue); } },
                { "primaryChannel", n => { PrimaryChannel = n.GetObjectValue<global::Microsoft.Graph.Models.Channel>(global::Microsoft.Graph.Models.Channel.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Microsoft.Graph.Models.Schedule>(global::Microsoft.Graph.Models.Schedule.CreateFromDiscriminatorValue); } },
                { "specialization", n => { Specialization = n.GetEnumValue<global::Microsoft.Graph.Models.TeamSpecialization>(); } },
                { "summary", n => { Summary = n.GetObjectValue<global::Microsoft.Graph.Models.TeamSummary>(global::Microsoft.Graph.Models.TeamSummary.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkTag>(global::Microsoft.Graph.Models.TeamworkTag.CreateFromDiscriminatorValue)?.AsList(); } },
                { "template", n => { Template = n.GetObjectValue<global::Microsoft.Graph.Models.TeamsTemplate>(global::Microsoft.Graph.Models.TeamsTemplate.CreateFromDiscriminatorValue); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::Microsoft.Graph.Models.TeamVisibilityType>(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>("allChannels", AllChannels);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>("channels", Channels);
            writer.WriteStringValue("classification", Classification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamFunSettings>("funSettings", FunSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamGuestSettings>("guestSettings", GuestSettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Channel>("incomingChannels", IncomingChannels);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteStringValue("internalId", InternalId);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ConversationMember>("members", Members);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamMemberSettings>("memberSettings", MemberSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamMessagingSettings>("messagingSettings", MessagingSettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAsyncOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ProfilePhoto>("photo", Photo);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Channel>("primaryChannel", PrimaryChannel);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Schedule>("schedule", Schedule);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TeamSpecialization>("specialization", Specialization);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamSummary>("summary", Summary);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkTag>("tags", Tags);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamsTemplate>("template", Template);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TeamVisibilityType>("visibility", Visibility);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
