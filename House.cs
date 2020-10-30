using System.Collections.Generic;

namespace BuilderPattern
{
    public class House
    {
        public List<Floor> Floors { get; }
        public float Area { get; }
        public bool HasGarden { get; }

        public House(List<Floor> floors, float area, bool hasGarden)
        {
            Floors = floors;
            Area = area;
            HasGarden = hasGarden;
        }


    }
}
