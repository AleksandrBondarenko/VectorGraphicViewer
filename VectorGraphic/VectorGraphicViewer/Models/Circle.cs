
namespace VectorGraphicViewer.Models
{
    public class Circle : Primitive
    {
        public override string Type { get; } = "circle";
        public string Center { get; set; }
        public double Radius { get; set; }
        public bool Filled { get; set; }

    }
}
