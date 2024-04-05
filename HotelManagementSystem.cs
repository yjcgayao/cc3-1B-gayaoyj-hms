using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels;
        private List<User> users;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
            users = new List<User>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"  {hotel.Name}, {hotel.Location}");
            }
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            guest.BookRoom(hotel, room, startTime, endTime);
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            // Search for the reservation
            foreach (var user in users)
            {
                if (user is Guest guest)
                {
                    foreach (var reservation in guest.Reservations)
                    {
                        if (reservation.ReservationNumber == reservationNumber)
                        {
                            Console.WriteLine($"Reservation Details: ");
                            Console.WriteLine($"Reservation Number: {reservation.ReservationNumber}");
                            Console.WriteLine($"Start Time: {reservation.StartTime}");
                            Console.WriteLine($"End Time: {reservation.EndTime}");
                            Console.WriteLine($"Duration: {reservation.DurationInDays}");
                            Console.WriteLine($"Total: {reservation.TotalAmount}");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Reservation not found.");
        }
    }
}