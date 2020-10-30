using System.Collections.Generic;

namespace BuilderPattern
{
    public class Floor
    {
        public IReadOnlyList<Room> Rooms { get; }
        public int Level { get; }

        public Floor(IReadOnlyList<Room> rooms, int level)
        {
            Rooms = rooms;
            Level = level;
        }
    }
}
