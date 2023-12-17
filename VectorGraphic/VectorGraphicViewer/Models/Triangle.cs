
namespace VectorGraphicViewer.Models
{
    public class Triangle : Primitive
    {
        public override string Type { get; } = "triangle";
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public bool Filled { get; set; }
    }
}
