using cc3_1B_gayaoyj_hms;
using System;
using System.Collections.Generic;

namespace HotelBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HotelRoom> yananRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyle.TwinRoom, 1500);
            HotelRoom room2 = new HotelRoom(102, RoomStyle.KingRoom, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);
            Hotel hotelYanan = new Hotel("Hotel Yanan", "123 GStreet, Takaw City", yananRooms);

            List<HotelRoom> hotel456Rooms = new List<HotelRoom>();
            HotelRoom hotel456Room1 = new HotelRoom(101, RoomStyle.QueenRoom, 2000);
            HotelRoom hotel456Room2 = new HotelRoom(102, RoomStyle.QueenRoom, 2000);
            hotel456Rooms.Add(hotel456Room1);
            hotel456Rooms.Add(hotel456Room2);
            Hotel hotel456 = new Hotel("Hotel 456", "Session Road, Baguio City", hotel456Rooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelYanan);
            hms.AddHotel(hotel456);

            // Output of DisplayHotels
            hms.DisplayHotels();

            // Output of DisplayAvailableRooms
            hotelYanan.DisplayAvailableRooms();

            // Create a new Guest with an account
            Account terryAccount = new Account(1, "password123");
            Guest terry = new Guest("Terry", "Addr 1", "terry@email.com", "63919129", terryAccount);
            hms.RegisterUser(terry);

            // Book a reservation for Terry
            hms.BookReservation(hotelYanan, room1, terry, DateTime.Now, new DateTime(2024, 04, 16));

            // Output of DisplayBookedRooms
            hotelYanan.DisplayBookedRooms();

            // Output of DisplayReservations
            terry.DisplayReservations();

            // Create a new Receptionist with an account
            Account annaAccount = new Account(2, "password456");
            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", "67890", annaAccount);
            hms.RegisterUser(anna);

            // Book a reservation through Receptionist
            Reservation res = new Reservation(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), hotel456Room2);
            anna.BookReservation(terry, res, hotel456);

            // Output of DisplayReservations after booking through Receptionist
            terry.DisplayReservations();

            // Output reservation details
            hms.DisplayReservationDetails(1234567890);
        }
    }
}