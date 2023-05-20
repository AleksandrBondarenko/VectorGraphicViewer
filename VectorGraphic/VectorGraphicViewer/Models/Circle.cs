using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
