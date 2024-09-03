// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class BlobEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The container which the blob belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.BlobContainerEvidence? BlobContainer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.BlobContainerEvidence?>("blobContainer"); }
            set { BackingStore?.Set("blobContainer", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.BlobContainerEvidence BlobContainer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.BlobContainerEvidence>("blobContainer"); }
            set { BackingStore?.Set("blobContainer", value); }
        }
#endif
        /// <summary>The Etag associated with this blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag
        {
            get { return BackingStore?.Get<string?>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#nullable restore
#else
        public string Etag
        {
            get { return BackingStore?.Get<string>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#endif
        /// <summary>The file hashes associated with this blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.FileHash>? FileHashes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.FileHash>?>("fileHashes"); }
            set { BackingStore?.Set("fileHashes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.FileHash> FileHashes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.FileHash>>("fileHashes"); }
            set { BackingStore?.Set("fileHashes", value); }
        }
#endif
        /// <summary>The name of the blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The full URL representation of the blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url
        {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url
        {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.BlobEvidence"/> and sets the default values.
        /// </summary>
        public BlobEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.blobEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.BlobEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.BlobEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.BlobEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "blobContainer", n => { BlobContainer = n.GetObjectValue<global::Microsoft.Graph.Models.Security.BlobContainerEvidence>(global::Microsoft.Graph.Models.Security.BlobContainerEvidence.CreateFromDiscriminatorValue); } },
                { "etag", n => { Etag = n.GetStringValue(); } },
                { "fileHashes", n => { FileHashes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.FileHash>(global::Microsoft.Graph.Models.Security.FileHash.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.BlobContainerEvidence>("blobContainer", BlobContainer);
            writer.WriteStringValue("etag", Etag);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.FileHash>("fileHashes", FileHashes);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
