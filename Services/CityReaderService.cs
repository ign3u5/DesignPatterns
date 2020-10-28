using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample.Services
{
    public class CityReaderService
    {

        public string[] ReadCitiesFromFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
