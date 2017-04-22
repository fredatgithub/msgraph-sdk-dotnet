// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserRequestBuilder.
    /// </summary>
    public partial class UserRequestBuilder : DirectoryObjectRequestBuilder, IUserRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IUserRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IUserRequest Request(IEnumerable<Option> options)
        {
            return new UserRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for OwnedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserOwnedDevicesCollectionWithReferencesRequestBuilder OwnedDevices
        {
            get
            {
                return new UserOwnedDevicesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("ownedDevices"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RegisteredDevices.
        /// </summary>
        /// <returns>The <see cref="IUserRegisteredDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserRegisteredDevicesCollectionWithReferencesRequestBuilder RegisteredDevices
        {
            get
            {
                return new UserRegisteredDevicesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("registeredDevices"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Manager.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder Manager
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("manager"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectReports.
        /// </summary>
        /// <returns>The <see cref="IUserDirectReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserDirectReportsCollectionWithReferencesRequestBuilder DirectReports
        {
            get
            {
                return new UserDirectReportsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("directReports"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserMemberOfCollectionWithReferencesRequestBuilder MemberOf
        {
            get
            {
                return new UserMemberOfCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("memberOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CreatedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserCreatedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserCreatedObjectsCollectionWithReferencesRequestBuilder CreatedObjects
        {
            get
            {
                return new UserCreatedObjectsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("createdObjects"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for OwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserOwnedObjectsCollectionWithReferencesRequestBuilder OwnedObjects
        {
            get
            {
                return new UserOwnedObjectsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("ownedObjects"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ScopedAdministratorOf.
        /// </summary>
        /// <returns>The <see cref="IUserScopedAdministratorOfCollectionRequestBuilder"/>.</returns>
        public IUserScopedAdministratorOfCollectionRequestBuilder ScopedAdministratorOf
        {
            get
            {
                return new UserScopedAdministratorOfCollectionRequestBuilder(this.AppendSegmentToRequestUrl("scopedAdministratorOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LicenseDetails.
        /// </summary>
        /// <returns>The <see cref="IUserLicenseDetailsCollectionRequestBuilder"/>.</returns>
        public IUserLicenseDetailsCollectionRequestBuilder LicenseDetails
        {
            get
            {
                return new UserLicenseDetailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("licenseDetails"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IUserExtensionsCollectionRequestBuilder"/>.</returns>
        public IUserExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new UserExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IUserMessagesCollectionRequestBuilder"/>.</returns>
        public IUserMessagesCollectionRequestBuilder Messages
        {
            get
            {
                return new UserMessagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("messages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for JoinedGroups.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedGroupsCollectionRequestBuilder"/>.</returns>
        public IUserJoinedGroupsCollectionRequestBuilder JoinedGroups
        {
            get
            {
                return new UserJoinedGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("joinedGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MailFolders.
        /// </summary>
        /// <returns>The <see cref="IUserMailFoldersCollectionRequestBuilder"/>.</returns>
        public IUserMailFoldersCollectionRequestBuilder MailFolders
        {
            get
            {
                return new UserMailFoldersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mailFolders"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        public ICalendarRequestBuilder Calendar
        {
            get
            {
                return new CalendarRequestBuilder(this.AppendSegmentToRequestUrl("calendar"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Calendars.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarsCollectionRequestBuilder"/>.</returns>
        public IUserCalendarsCollectionRequestBuilder Calendars
        {
            get
            {
                return new UserCalendarsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("calendars"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CalendarGroups.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarGroupsCollectionRequestBuilder"/>.</returns>
        public IUserCalendarGroupsCollectionRequestBuilder CalendarGroups
        {
            get
            {
                return new UserCalendarGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("calendarGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarViewCollectionRequestBuilder"/>.</returns>
        public IUserCalendarViewCollectionRequestBuilder CalendarView
        {
            get
            {
                return new UserCalendarViewCollectionRequestBuilder(this.AppendSegmentToRequestUrl("calendarView"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="IUserEventsCollectionRequestBuilder"/>.</returns>
        public IUserEventsCollectionRequestBuilder Events
        {
            get
            {
                return new UserEventsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("events"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for People.
        /// </summary>
        /// <returns>The <see cref="IUserPeopleCollectionRequestBuilder"/>.</returns>
        public IUserPeopleCollectionRequestBuilder People
        {
            get
            {
                return new UserPeopleCollectionRequestBuilder(this.AppendSegmentToRequestUrl("people"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Contacts.
        /// </summary>
        /// <returns>The <see cref="IUserContactsCollectionRequestBuilder"/>.</returns>
        public IUserContactsCollectionRequestBuilder Contacts
        {
            get
            {
                return new UserContactsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("contacts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ContactFolders.
        /// </summary>
        /// <returns>The <see cref="IUserContactFoldersCollectionRequestBuilder"/>.</returns>
        public IUserContactFoldersCollectionRequestBuilder ContactFolders
        {
            get
            {
                return new UserContactFoldersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("contactFolders"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for InferenceClassification.
        /// </summary>
        /// <returns>The <see cref="IInferenceClassificationRequestBuilder"/>.</returns>
        public IInferenceClassificationRequestBuilder InferenceClassification
        {
            get
            {
                return new InferenceClassificationRequestBuilder(this.AppendSegmentToRequestUrl("inferenceClassification"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        public IProfilePhotoRequestBuilder Photo
        {
            get
            {
                return new ProfilePhotoRequestBuilder(this.AppendSegmentToRequestUrl("photo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Photos.
        /// </summary>
        /// <returns>The <see cref="IUserPhotosCollectionRequestBuilder"/>.</returns>
        public IUserPhotosCollectionRequestBuilder Photos
        {
            get
            {
                return new UserPhotosCollectionRequestBuilder(this.AppendSegmentToRequestUrl("photos"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl("drive"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="IUserDrivesCollectionRequestBuilder"/>.</returns>
        public IUserDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new UserDrivesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("drives"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sharepoint.
        /// </summary>
        /// <returns>The <see cref="ISharePointRequestBuilder"/>.</returns>
        public ISharePointRequestBuilder Sharepoint
        {
            get
            {
                return new SharePointRequestBuilder(this.AppendSegmentToRequestUrl("sharepoint"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Insights.
        /// </summary>
        /// <returns>The <see cref="IOfficeGraphInsightsRequestBuilder"/>.</returns>
        public IOfficeGraphInsightsRequestBuilder Insights
        {
            get
            {
                return new OfficeGraphInsightsRequestBuilder(this.AppendSegmentToRequestUrl("insights"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TrendingAround.
        /// </summary>
        /// <returns>The <see cref="IUserTrendingAroundCollectionRequestBuilder"/>.</returns>
        public IUserTrendingAroundCollectionRequestBuilder TrendingAround
        {
            get
            {
                return new UserTrendingAroundCollectionRequestBuilder(this.AppendSegmentToRequestUrl("trendingAround"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkingWith.
        /// </summary>
        /// <returns>The <see cref="IUserWorkingWithCollectionRequestBuilder"/>.</returns>
        public IUserWorkingWithCollectionRequestBuilder WorkingWith
        {
            get
            {
                return new UserWorkingWithCollectionRequestBuilder(this.AppendSegmentToRequestUrl("workingWith"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IUserTasksCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserTasksCollectionWithReferencesRequestBuilder Tasks
        {
            get
            {
                return new UserTasksCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Plans.
        /// </summary>
        /// <returns>The <see cref="IUserPlansCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserPlansCollectionWithReferencesRequestBuilder Plans
        {
            get
            {
                return new UserPlansCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("plans"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Planner.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserRequestBuilder"/>.</returns>
        public IPlannerUserRequestBuilder Planner
        {
            get
            {
                return new PlannerUserRequestBuilder(this.AppendSegmentToRequestUrl("planner"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Notes.
        /// </summary>
        /// <returns>The <see cref="INotesRequestBuilder"/>.</returns>
        public INotesRequestBuilder Notes
        {
            get
            {
                return new NotesRequestBuilder(this.AppendSegmentToRequestUrl("notes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserManagedDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserManagedDevicesCollectionWithReferencesRequestBuilder ManagedDevices
        {
            get
            {
                return new UserManagedDevicesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("managedDevices"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IUserManagedAppRegistrationsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IUserManagedAppRegistrationsCollectionWithReferencesRequestBuilder ManagedAppRegistrations
        {
            get
            {
                return new UserManagedAppRegistrationsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("managedAppRegistrations"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for UserAssignLicense.
        /// </summary>
        /// <returns>The <see cref="IUserAssignLicenseRequestBuilder"/>.</returns>
        public IUserAssignLicenseRequestBuilder AssignLicense(
            IEnumerable<AssignedLicense> addLicenses,
            IEnumerable<Guid> removeLicenses)
        {
            return new UserAssignLicenseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assignLicense"),
                this.Client,
                addLicenses,
                removeLicenses);
        }

        /// <summary>
        /// Gets the request builder for UserChangePassword.
        /// </summary>
        /// <returns>The <see cref="IUserChangePasswordRequestBuilder"/>.</returns>
        public IUserChangePasswordRequestBuilder ChangePassword(
            string currentPassword = null,
            string newPassword = null)
        {
            return new UserChangePasswordRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.changePassword"),
                this.Client,
                currentPassword,
                newPassword);
        }

        /// <summary>
        /// Gets the request builder for UserInvalidateAllRefreshTokens.
        /// </summary>
        /// <returns>The <see cref="IUserInvalidateAllRefreshTokensRequestBuilder"/>.</returns>
        public IUserInvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens()
        {
            return new UserInvalidateAllRefreshTokensRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.invalidateAllRefreshTokens"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for UserSendMail.
        /// </summary>
        /// <returns>The <see cref="IUserSendMailRequestBuilder"/>.</returns>
        public IUserSendMailRequestBuilder SendMail(
            Message Message,
            bool? SaveToSentItems = null)
        {
            return new UserSendMailRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendMail"),
                this.Client,
                Message,
                SaveToSentItems);
        }

        /// <summary>
        /// Gets the request builder for UserFindMeetingTimesOLD.
        /// </summary>
        /// <returns>The <see cref="IUserFindMeetingTimesOLDRequestBuilder"/>.</returns>
        public IUserFindMeetingTimesOLDRequestBuilder FindMeetingTimesOLD(
            IEnumerable<AttendeeBase> Attendees = null,
            LocationConstraint LocationConstraint = null,
            TimeConstraint TimeConstraint = null,
            Duration MeetingDuration = null,
            Int32? MaxCandidates = null,
            bool? IsOrganizerOptional = null,
            bool? ReturnSuggestionHints = null)
        {
            return new UserFindMeetingTimesOLDRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.findMeetingTimesOLD"),
                this.Client,
                Attendees,
                LocationConstraint,
                TimeConstraint,
                MeetingDuration,
                MaxCandidates,
                IsOrganizerOptional,
                ReturnSuggestionHints);
        }

        /// <summary>
        /// Gets the request builder for UserFindMeetingTimes.
        /// </summary>
        /// <returns>The <see cref="IUserFindMeetingTimesRequestBuilder"/>.</returns>
        public IUserFindMeetingTimesRequestBuilder FindMeetingTimes(
            IEnumerable<AttendeeBase> Attendees = null,
            LocationConstraint LocationConstraint = null,
            TimeConstraint TimeConstraint = null,
            Duration MeetingDuration = null,
            Int32? MaxCandidates = null,
            bool? IsOrganizerOptional = null,
            bool? ReturnSuggestionReasons = null,
            double? MinimumAttendeePercentage = null)
        {
            return new UserFindMeetingTimesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.findMeetingTimes"),
                this.Client,
                Attendees,
                LocationConstraint,
                TimeConstraint,
                MeetingDuration,
                MaxCandidates,
                IsOrganizerOptional,
                ReturnSuggestionReasons,
                MinimumAttendeePercentage);
        }

        /// <summary>
        /// Gets the request builder for UserGetMailTips.
        /// </summary>
        /// <returns>The <see cref="IUserGetMailTipsRequestBuilder"/>.</returns>
        public IUserGetMailTipsRequestBuilder GetMailTips(
            IEnumerable<string> EmailAddresses,
            MailTipsType? MailTipsOptions = null)
        {
            return new UserGetMailTipsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getMailTips"),
                this.Client,
                EmailAddresses,
                MailTipsOptions);
        }

        /// <summary>
        /// Gets the request builder for UserRemoveAllDevicesFromManagement.
        /// </summary>
        /// <returns>The <see cref="IUserRemoveAllDevicesFromManagementRequestBuilder"/>.</returns>
        public IUserRemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement()
        {
            return new UserRemoveAllDevicesFromManagementRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeAllDevicesFromManagement"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for UserWipeManagedAppRegistrationByDeviceTag.
        /// </summary>
        /// <returns>The <see cref="IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder"/>.</returns>
        public IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag(
            string deviceTag = null)
        {
            return new UserWipeManagedAppRegistrationByDeviceTagRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.wipeManagedAppRegistrationByDeviceTag"),
                this.Client,
                deviceTag);
        }

        /// <summary>
        /// Gets the request builder for UserWipeByDeviceTag.
        /// </summary>
        /// <returns>The <see cref="IUserWipeByDeviceTagRequestBuilder"/>.</returns>
        public IUserWipeByDeviceTagRequestBuilder WipeByDeviceTag(
            string deviceTag = null)
        {
            return new UserWipeByDeviceTagRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.wipeByDeviceTag"),
                this.Client,
                deviceTag);
        }

        /// <summary>
        /// Gets the request builder for UserReminderView.
        /// </summary>
        /// <returns>The <see cref="IUserReminderViewRequestBuilder"/>.</returns>
        public IUserReminderViewRequestBuilder ReminderView(
            string StartDateTime,
            string EndDateTime = null)
        {
            return new UserReminderViewRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reminderView"),
                this.Client,
                StartDateTime,
                EndDateTime);
        }

        /// <summary>
        /// Gets the request builder for UserGetManagedAppDiagnosticStatuses.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppDiagnosticStatusesRequestBuilder"/>.</returns>
        public IUserGetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses()
        {
            return new UserGetManagedAppDiagnosticStatusesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getManagedAppDiagnosticStatuses"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for UserGetManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppPoliciesRequestBuilder"/>.</returns>
        public IUserGetManagedAppPoliciesRequestBuilder GetManagedAppPolicies()
        {
            return new UserGetManagedAppPoliciesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getManagedAppPolicies"),
                this.Client);
        }
    
    }
}
