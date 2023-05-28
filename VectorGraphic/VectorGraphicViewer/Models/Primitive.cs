using Newtonsoft.Json;
using JsonSubTypes;

namespace VectorGraphicViewer.Models
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(Line), "line")]
    [JsonSubtypes.KnownSubType(typeof(Circle), "circle")]
    [JsonSubtypes.KnownSubType(typeof(Triangle), "triangle")]
    public abstract class Primitive
    {
        public abstract string Type { get; }
        public string Color { get; set; }
    }
}
