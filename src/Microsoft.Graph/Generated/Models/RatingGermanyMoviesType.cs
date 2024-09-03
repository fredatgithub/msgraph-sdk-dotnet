// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Movies rating labels in Germany</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum RatingGermanyMoviesType
    {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>Ab 0 Jahren, no age restrictions</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>Ab 6 Jahren, ages 6 and older</summary>
        [EnumMember(Value = "agesAbove6")]
        AgesAbove6,
        /// <summary>Ab 12 Jahren, ages 12 and older</summary>
        [EnumMember(Value = "agesAbove12")]
        AgesAbove12,
        /// <summary>Ab 16 Jahren, ages 16 and older</summary>
        [EnumMember(Value = "agesAbove16")]
        AgesAbove16,
        /// <summary>Ab 18 Jahren, adults only</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}
