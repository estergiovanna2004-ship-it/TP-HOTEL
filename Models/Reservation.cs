using System;

namespace HotelCheckInSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(int id, int guestId, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            GuestId = guestId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public void UpdateReservation(DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            CheckInDate = newCheckInDate;
            CheckOutDate = newCheckOutDate;
        }

        public TimeSpan GetStayDuration()
        {
            return CheckOutDate - CheckInDate;
        }
    }
}