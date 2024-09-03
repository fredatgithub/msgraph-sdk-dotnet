// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Represents a staff member who provides services in a business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class BookingStaffMember : global::Microsoft.Graph.Models.BookingStaffMemberBase, IParsable
    {
        /// <summary>True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member&apos;s availability in their personal calendar in Microsoft 365, before making a booking.</summary>
        public bool? AvailabilityIsAffectedByPersonalCalendar
        {
            get { return BackingStore?.Get<bool?>("availabilityIsAffectedByPersonalCalendar"); }
            set { BackingStore?.Set("availabilityIsAffectedByPersonalCalendar", value); }
        }
        /// <summary>The date, time, and time zone when the staff member was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of the staff member, as displayed to customers. Required.</summary>
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
        /// <summary>The email address of the staff member. This email address can be in the same Microsoft 365 tenant as the business, or in a different email domain. This email address can be used if the sendConfirmationsToOwner property is set to true in the scheduling policy of the business. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress
        {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress
        {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Indicates that a staff member is notified via email when a booking assigned to them is created or changed. The default value is true.</summary>
        public bool? IsEmailNotificationEnabled
        {
            get { return BackingStore?.Get<bool?>("isEmailNotificationEnabled"); }
            set { BackingStore?.Set("isEmailNotificationEnabled", value); }
        }
        /// <summary>The date, time, and time zone when the staff member was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The membershipStatus property</summary>
        public global::Microsoft.Graph.Models.BookingStaffMembershipStatus? MembershipStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BookingStaffMembershipStatus?>("membershipStatus"); }
            set { BackingStore?.Set("membershipStatus", value); }
        }
        /// <summary>The role property</summary>
        public global::Microsoft.Graph.Models.BookingStaffRole? Role
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BookingStaffRole?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone
        {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone
        {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>True means the staff member&apos;s availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member&apos;s workingHours property setting.</summary>
        public bool? UseBusinessHours
        {
            get { return BackingStore?.Get<bool?>("useBusinessHours"); }
            set { BackingStore?.Set("useBusinessHours", value); }
        }
        /// <summary>The range of hours each day of the week that the staff member is available for booking. By default, they&apos;re initialized to be the same as the businessHours property of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BookingWorkHours>? WorkingHours
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingWorkHours>?>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BookingWorkHours> WorkingHours
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingWorkHours>>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.BookingStaffMember"/> and sets the default values.
        /// </summary>
        public BookingStaffMember() : base()
        {
            OdataType = "#microsoft.graph.bookingStaffMember";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BookingStaffMember"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.BookingStaffMember CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.BookingStaffMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availabilityIsAffectedByPersonalCalendar", n => { AvailabilityIsAffectedByPersonalCalendar = n.GetBoolValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                { "isEmailNotificationEnabled", n => { IsEmailNotificationEnabled = n.GetBoolValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "membershipStatus", n => { MembershipStatus = n.GetEnumValue<global::Microsoft.Graph.Models.BookingStaffMembershipStatus>(); } },
                { "role", n => { Role = n.GetEnumValue<global::Microsoft.Graph.Models.BookingStaffRole>(); } },
                { "timeZone", n => { TimeZone = n.GetStringValue(); } },
                { "useBusinessHours", n => { UseBusinessHours = n.GetBoolValue(); } },
                { "workingHours", n => { WorkingHours = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingWorkHours>(global::Microsoft.Graph.Models.BookingWorkHours.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteBoolValue("availabilityIsAffectedByPersonalCalendar", AvailabilityIsAffectedByPersonalCalendar);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteBoolValue("isEmailNotificationEnabled", IsEmailNotificationEnabled);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BookingStaffMembershipStatus>("membershipStatus", MembershipStatus);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BookingStaffRole>("role", Role);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteBoolValue("useBusinessHours", UseBusinessHours);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingWorkHours>("workingHours", WorkingHours);
        }
    }
}
#pragma warning restore CS0618
