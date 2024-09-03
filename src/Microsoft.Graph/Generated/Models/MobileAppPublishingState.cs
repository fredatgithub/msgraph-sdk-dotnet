// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Indicates the publishing state of an app.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum MobileAppPublishingState
    {
        /// <summary>The app is not yet published.</summary>
        [EnumMember(Value = "notPublished")]
        NotPublished,
        /// <summary>The app is pending service-side processing.</summary>
        [EnumMember(Value = "processing")]
        Processing,
        /// <summary>The app is published.</summary>
        [EnumMember(Value = "published")]
        Published,
    }
}
