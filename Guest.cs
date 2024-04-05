using cc3_1B_gayaoyj_hms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class Guest : User
    {
        private List<Reservation> reservations;

        public List<Reservation> Reservations => reservations;

        public Guest(string name, string address, string email, string phoneNumber, Account account)
            : base(name, address, email, phoneNumber, account)
        {
            reservations = new List<Reservation>();
        }

        public int TotalRoomsBooked => reservations.Count;

        public void BookRoom(Hotel hotel, HotelRoom room, DateTime startTime, DateTime endTime)
        {
            if (room.IsAvailable)
            {
                room.BookRoom();
                Reservation reservation = new Reservation(startTime, endTime, room);
                reservations.Add(reservation);
                Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice} at {hotel.Name} booked successfully.");
            }
            else
            {
                Console.WriteLine($"Room {room.RoomNumber} at {hotel.Name} is not available.");
            }
        }

        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}:");
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"  {reservation.ReservationNumber} Start Time: {reservation.StartTime}, End Time: {reservation.EndTime}, Duration: {reservation.DurationInDays}, Total: {reservation.TotalAmount}");
            }
        }
    }
}