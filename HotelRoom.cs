using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public enum RoomStyle
    {
        TwinRoom,
        KingRoom,
        QueenRoom
    }
    public class HotelRoom
    {
        public int RoomNumber { get; }
        public RoomStyle Style { get; }
        public decimal BookingPrice { get; }
        public bool IsAvailable { get; private set; }

        public HotelRoom(int roomNumber, RoomStyle style, decimal bookingPrice)
        {
            RoomNumber = roomNumber;
            Style = style;
            BookingPrice = bookingPrice;
            IsAvailable = true;
        }

        public void BookRoom()
        {
            IsAvailable = false;
        }

        public void CancelBooking()
        {
            IsAvailable = true;
        }
    }
}