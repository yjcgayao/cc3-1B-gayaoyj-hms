using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class Hotel
    {
        public string Name { get; }
        public string Location { get; }
        private List<HotelRoom> Rooms { get; }

        public Hotel(string name, string location, List<HotelRoom> rooms)
        {
            Name = name;
            Location = location;
            Rooms = rooms;
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {Name} - Available Rooms");
            foreach (var room in Rooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {Name} - Booked Rooms");
            foreach (var room in Rooms)
            {
                if (!room.IsAvailable)
                {
                    Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }

    }
}
