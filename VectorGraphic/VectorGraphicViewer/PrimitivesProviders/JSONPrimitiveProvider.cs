using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicViewer.Models;

namespace VectorGraphicViewer.PrimitivesProviders
{
    public class JSONPrimitiveProvider : IPrimitivesProvider
    {
        string _fileName;
        public JSONPrimitiveProvider(string FileName) 
        { 
            _fileName = FileName;
        }

        List<Primitive> IPrimitivesProvider.Primitives()
        {
            throw new NotImplementedException();
        }
    }
}
