using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ParticipantLeftNotification : Entity, IParsable {
        /// <summary>The call property</summary>
        public Microsoft.Graph.Models.Call Call {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Call>("call"); }
            set { BackingStore?.Set("call", value); }
        }
        /// <summary>ID of the participant under the policy who has left the meeting.</summary>
        public string ParticipantId {
            get { return BackingStore?.Get<string>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ParticipantLeftNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantLeftNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"call", n => { Call = n.GetObjectValue<Microsoft.Graph.Models.Call>(Microsoft.Graph.Models.Call.CreateFromDiscriminatorValue); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Call>("call", Call);
            writer.WriteStringValue("participantId", ParticipantId);
        }
    }
}
