using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FacadeExample.Services
{
    public class JsonWriterService
    {
        public void WriteCityData(string cityName, string jsonString)
        {
            File.WriteAllText(cityName + ".json", jsonString);
        }
    }
}
