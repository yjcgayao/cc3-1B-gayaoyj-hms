using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class Reservation
    {
        public int ReservationNumber { get; } // Add property for reservation number
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public int DurationInDays => (int)(EndTime - StartTime).TotalDays;
        public HotelRoom Room { get; } // Add property for room

        // Add property for total amount
        public decimal TotalAmount => DurationInDays * Room.BookingPrice;

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            StartTime = startTime;
            EndTime = endTime;
            ReservationNumber = GenerateReservationNumber(); // Generate unique reservation number
            Room = room; // Assign room
        }

        private int GenerateReservationNumber()
        {
            // Implement logic to generate unique reservation number
            return new Random().Next(100000000, 999999999);
        }
    }
}