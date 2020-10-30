using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class FloorBuilder
    {
        private Floor _floor;

        public FloorBuilder(List<Room> rooms, int level)
        {
            _floor = new Floor(rooms, level);
        }

        public FloorBuilder Rooms(List<Room> rooms)
        {
            return new FloorBuilder(rooms, _floor.Level);
        }

        public FloorBuilder Room(Room room)
        {
            if (_floor.Rooms == null)
            {
                return new FloorBuilder(new List<Room> {room}, _floor.Level);
            }

            List<Room> rooms = new List<Room>();
            rooms.AddRange(_floor.Rooms);
            rooms.Add(room);

            return new FloorBuilder(rooms, _floor.Level);
        }

        public Floor Build()
        {
            return _floor;
        }
    }
}
