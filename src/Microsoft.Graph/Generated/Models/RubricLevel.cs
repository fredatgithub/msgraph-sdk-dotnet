// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class RubricLevel : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The description of this rubric level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationItemBody? Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationItemBody Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of this rubric level.</summary>
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
        /// <summary>Null if this is a no-points rubric; educationAssignmentPointsGradeType if it&apos;s a points rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationAssignmentGradeType? Grading
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAssignmentGradeType?>("grading"); }
            set { BackingStore?.Set("grading", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationAssignmentGradeType Grading
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAssignmentGradeType>("grading"); }
            set { BackingStore?.Set("grading", value); }
        }
#endif
        /// <summary>The ID of this resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LevelId
        {
            get { return BackingStore?.Get<string?>("levelId"); }
            set { BackingStore?.Set("levelId", value); }
        }
#nullable restore
#else
        public string LevelId
        {
            get { return BackingStore?.Get<string>("levelId"); }
            set { BackingStore?.Set("levelId", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.RubricLevel"/> and sets the default values.
        /// </summary>
        public RubricLevel()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RubricLevel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.RubricLevel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RubricLevel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "description", n => { Description = n.GetObjectValue<global::Microsoft.Graph.Models.EducationItemBody>(global::Microsoft.Graph.Models.EducationItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "grading", n => { Grading = n.GetObjectValue<global::Microsoft.Graph.Models.EducationAssignmentGradeType>(global::Microsoft.Graph.Models.EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                { "levelId", n => { LevelId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationAssignmentGradeType>("grading", Grading);
            writer.WriteStringValue("levelId", LevelId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
