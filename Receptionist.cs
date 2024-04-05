using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class Receptionist : User
    {
        public Receptionist(string name, string address, string email, string phoneNumber, Account account)
            : base(name, address, email, phoneNumber, account)
        {
        }

        public void BookReservation(Guest guest, Reservation reservation, Hotel hotel)
        {
            // Book the reservation for the guest in the specified hotel
            guest.BookRoom(hotel, reservation.Room, reservation.StartTime, reservation.EndTime);
        }
    }
}