using System;

namespace BuilderPattern
{
    public class Room
    {
        public float Area { get; }
        public int Doors { get; }

        public Room(float area, int doors)
        {
            Area = area;
            Doors = doors;
        }

        
    }
}
