using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicViewer.Models;

namespace VectorGraphicViewer.PrimitivesProviders
{
    public interface IPrimitivesProvider
    {
        public Task<List<Primitive>?> PrimitivesAsync();
    }
}
