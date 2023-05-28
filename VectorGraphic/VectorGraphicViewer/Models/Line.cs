
namespace VectorGraphicViewer.Models
{
    public class Line : Primitive
    {
        public override string Type { get; } = "line";
        public string A { get; set; }
        public string B { get; set; }
    }
}
