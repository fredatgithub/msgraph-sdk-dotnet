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
    /// The type Domain.
    /// </summary>
    public partial class Domain : Entity
    {
    
        /// <summary>
        /// Gets or sets authentication type.
        /// Indicates the configured authentication type for the domain. The value is either Managed or Federated. Managed indicates a cloud managed domain where Azure AD performs user authentication. Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services. This property is read-only and is not nullable.
        /// </summary>
        [JsonPropertyName("authenticationType")]
        public string AuthenticationType { get; set; }
    
        /// <summary>
        /// Gets or sets availability status.
        /// This property is always null except when the verify action is used. When the verify action is used, a domain entity is returned in the response. The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.
        /// </summary>
        [JsonPropertyName("availabilityStatus")]
        public string AvailabilityStatus { get; set; }
    
        /// <summary>
        /// Gets or sets is admin managed.
        /// The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365. Otherwise, the value is true. Not nullable
        /// </summary>
        [JsonPropertyName("isAdminManaged")]
        public bool? IsAdminManaged { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// true if this is the default domain that is used for user creation. There is only one default domain per company. Not nullable
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets is initial.
        /// true if this is the initial domain created by Microsoft Online Services (companyname.onmicrosoft.com). There is only one initial domain per company. Not nullable
        /// </summary>
        [JsonPropertyName("isInitial")]
        public bool? IsInitial { get; set; }
    
        /// <summary>
        /// Gets or sets is root.
        /// true if the domain is a verified root domain. Otherwise, false if the domain is a subdomain or unverified. Not nullable
        /// </summary>
        [JsonPropertyName("isRoot")]
        public bool? IsRoot { get; set; }
    
        /// <summary>
        /// Gets or sets is verified.
        /// true if the domain has completed domain ownership verification. Not nullable
        /// </summary>
        [JsonPropertyName("isVerified")]
        public bool? IsVerified { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets password notification window in days.
        /// Specifies the number of days before a user receives notification that their password will expire. If the property is not set, a default value of 14 days will be used.
        /// </summary>
        [JsonPropertyName("passwordNotificationWindowInDays")]
        public Int32? PasswordNotificationWindowInDays { get; set; }
    
        /// <summary>
        /// Gets or sets password validity period in days.
        /// Specifies the length of time that a password is valid before it must be changed. If the property is not set, a default value of 90 days will be used.
        /// </summary>
        [JsonPropertyName("passwordValidityPeriodInDays")]
        public Int32? PasswordValidityPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Status of asynchronous operations scheduled for the domain.
        /// </summary>
        [JsonPropertyName("state")]
        public DomainState State { get; set; }
    
        /// <summary>
        /// Gets or sets supported services.
        /// The capabilities assigned to the domain. Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune. The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer. Not nullable
        /// </summary>
        [JsonPropertyName("supportedServices")]
        public IEnumerable<string> SupportedServices { get; set; }
    
        /// <summary>
        /// Gets or sets domain name references.
        /// Read-only, Nullable
        /// </summary>
        [JsonPropertyName("domainNameReferences")]
        public IDomainDomainNameReferencesCollectionWithReferencesPage DomainNameReferences { get; set; }

        /// <summary>
        /// Gets or sets domainNameReferencesNextLink.
        /// </summary>
        [JsonPropertyName("domainNameReferences@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DomainNameReferencesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets service configuration records.
        /// DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable
        /// </summary>
        [JsonPropertyName("serviceConfigurationRecords")]
        public IDomainServiceConfigurationRecordsCollectionPage ServiceConfigurationRecords { get; set; }

        /// <summary>
        /// Gets or sets serviceConfigurationRecordsNextLink.
        /// </summary>
        [JsonPropertyName("serviceConfigurationRecords@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ServiceConfigurationRecordsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets verification dns records.
        /// DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD. Read-only, Nullable
        /// </summary>
        [JsonPropertyName("verificationDnsRecords")]
        public IDomainVerificationDnsRecordsCollectionPage VerificationDnsRecords { get; set; }

        /// <summary>
        /// Gets or sets verificationDnsRecordsNextLink.
        /// </summary>
        [JsonPropertyName("verificationDnsRecords@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string VerificationDnsRecordsNextLink { get; set; }
    
    }
}

