using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicViewer.Models
{
    public class Line : Primitive
    {
        public override string Type { get; } = "line";
        public string A { get; set; }
        public string B { get; set; }
    }
}
