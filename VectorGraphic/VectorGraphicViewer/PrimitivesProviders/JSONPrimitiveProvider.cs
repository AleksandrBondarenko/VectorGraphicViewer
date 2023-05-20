using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
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

        public List<Primitive>? Primitives()
        {
            List<Primitive>? primitives;
            using (StreamReader reader = File.OpenText(_fileName))
            {
                var jsonString = reader.ReadToEnd();
                primitives = JsonConvert.DeserializeObject<List<Primitive>>(jsonString);
            }
            
            return primitives;
        }
    }
}
