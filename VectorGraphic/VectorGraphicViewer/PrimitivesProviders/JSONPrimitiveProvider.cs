using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using VectorGraphicViewer.Models;

namespace VectorGraphicViewer.PrimitivesProviders
{
    public class JSONPrimitiveProvider : IPrimitivesProvider
    {
        public string FileName { get; private set; }
        public JSONPrimitiveProvider(string fileName) 
        { 
            FileName = fileName;
        }

        async public Task<List<Primitive>?> PrimitivesAsync()
        {
            List<Primitive>? primitives;
            using (StreamReader reader = File.OpenText(FileName))
            {
                var jsonString = await reader.ReadToEndAsync();
                primitives = JsonConvert.DeserializeObject<List<Primitive>>(jsonString);
            }

            return primitives;
        }

    }
}
