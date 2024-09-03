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
    public partial class AccessPackageSubject : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConnectedOrganization? ConnectedOrganization
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConnectedOrganization?>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConnectedOrganization ConnectedOrganization
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConnectedOrganization>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#endif
        /// <summary>The display name of the subject.</summary>
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
        /// <summary>The email address of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The object identifier of the subject. null if the subject isn&apos;t yet a user in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId
        {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#nullable restore
#else
        public string ObjectId
        {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>A string representation of the principal&apos;s security identifier, if known, or null if the subject doesn&apos;t have a security identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier
        {
            get { return BackingStore?.Get<string?>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier
        {
            get { return BackingStore?.Get<string>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#endif
        /// <summary>The principal name, if known, of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName
        {
            get { return BackingStore?.Get<string?>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#nullable restore
#else
        public string PrincipalName
        {
            get { return BackingStore?.Get<string>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#endif
        /// <summary>The resource type of the subject. The possible values are: notSpecified, user, servicePrincipal, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.AccessPackageSubjectType? SubjectType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageSubjectType?>("subjectType"); }
            set { BackingStore?.Set("subjectType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageSubject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<global::Microsoft.Graph.Models.ConnectedOrganization>(global::Microsoft.Graph.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "objectId", n => { ObjectId = n.GetStringValue(); } },
                { "onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                { "principalName", n => { PrincipalName = n.GetStringValue(); } },
                { "subjectType", n => { SubjectType = n.GetEnumValue<global::Microsoft.Graph.Models.AccessPackageSubjectType>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AccessPackageSubjectType>("subjectType", SubjectType);
        }
    }
}
#pragma warning restore CS0618
