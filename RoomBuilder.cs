using System;

namespace BuilderPattern
{
    public class RoomBuilder
    {
        private Room _room;

        private RoomBuilder(float area, int doors)
        {
            _room = new Room(area: area, doors);
        }

        public RoomBuilder Area(float area)
        {
            return new RoomBuilder(area, _room.Doors);
        }

        public RoomBuilder Doors(int doors)
        {
            return new RoomBuilder(_room.Area, doors);
        }

        public static RoomBuilder Create() 
        {
            return new RoomBuilder(0, 1);
        }

        public Room Build()
        {
            if (_room.Area <= 0)
            {
                throw new InvalidOperationException("Area not set");
            }

            return _room;
        }
    }
}
