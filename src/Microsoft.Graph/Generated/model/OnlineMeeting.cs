// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Online Meeting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnlineMeeting>))]
    public partial class OnlineMeeting : Entity
    {
    
        /// <summary>
        /// Gets or sets allow attendee to enable camera.
        /// Indicates whether attendees can turn on their camera.
        /// </summary>
        [JsonPropertyName("allowAttendeeToEnableCamera")]
        public bool? AllowAttendeeToEnableCamera { get; set; }
    
        /// <summary>
        /// Gets or sets allow attendee to enable mic.
        /// Indicates whether attendees can turn on their microphone.
        /// </summary>
        [JsonPropertyName("allowAttendeeToEnableMic")]
        public bool? AllowAttendeeToEnableMic { get; set; }
    
        /// <summary>
        /// Gets or sets allowed presenters.
        /// Specifies who can be a presenter in a meeting. Possible values are listed in the following table.
        /// </summary>
        [JsonPropertyName("allowedPresenters")]
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
    
        /// <summary>
        /// Gets or sets allow meeting chat.
        /// Specifies the mode of meeting chat.
        /// </summary>
        [JsonPropertyName("allowMeetingChat")]
        public MeetingChatMode? AllowMeetingChat { get; set; }
    
        /// <summary>
        /// Gets or sets allow teamwork reactions.
        /// Indicates whether Teams reactions are enabled for the meeting.
        /// </summary>
        [JsonPropertyName("allowTeamworkReactions")]
        public bool? AllowTeamworkReactions { get; set; }
    
        /// <summary>
        /// Gets or sets attendee report.
        /// The content stream of the attendee report of a Microsoft Teams live event. Read-only.
        /// </summary>
        [JsonPropertyName("attendeeReport")]
        public Stream AttendeeReport { get; set; }
    
        /// <summary>
        /// Gets or sets audio conferencing.
        /// The phone access (dial-in) information for an online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("audioConferencing")]
        public AudioConferencing AudioConferencing { get; set; }
    
        /// <summary>
        /// Gets or sets broadcast settings.
        /// Settings related to a live event.
        /// </summary>
        [JsonPropertyName("broadcastSettings")]
        public BroadcastMeetingSettings BroadcastSettings { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information associated with this online meeting.
        /// </summary>
        [JsonPropertyName("chatInfo")]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// The meeting creation time in UTC. Read-only.
        /// </summary>
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The meeting end time in UTC.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The external ID. A custom ID. Optional.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets is broadcast.
        /// Indicates if this is a Teams live event.
        /// </summary>
        [JsonPropertyName("isBroadcast")]
        public bool? IsBroadcast { get; set; }
    
        /// <summary>
        /// Gets or sets is entry exit announced.
        /// Indicates whether to announce when callers join or leave.
        /// </summary>
        [JsonPropertyName("isEntryExitAnnounced")]
        public bool? IsEntryExitAnnounced { get; set; }
    
        /// <summary>
        /// Gets or sets join information.
        /// The join information in the language and locale variant specified in the Accept-Language request HTTP header. Read-only.
        /// </summary>
        [JsonPropertyName("joinInformation")]
        public ItemBody JoinInformation { get; set; }
    
        /// <summary>
        /// Gets or sets join web url.
        /// The join URL of the online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets lobby bypass settings.
        /// Specifies which participants can bypass the meeting   lobby.
        /// </summary>
        [JsonPropertyName("lobbyBypassSettings")]
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// The participants associated with the online meeting.  This includes the organizer and the attendees.
        /// </summary>
        [JsonPropertyName("participants")]
        public MeetingParticipants Participants { get; set; }
    
        /// <summary>
        /// Gets or sets record automatically.
        /// Indicates whether to record the meeting automatically.
        /// </summary>
        [JsonPropertyName("recordAutomatically")]
        public bool? RecordAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The meeting start time in UTC.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the online meeting.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets video teleconference id.
        /// The video teleconferencing ID. Read-only.
        /// </summary>
        [JsonPropertyName("videoTeleconferenceId")]
        public string VideoTeleconferenceId { get; set; }
    
    }
}

