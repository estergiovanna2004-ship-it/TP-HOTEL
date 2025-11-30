using System;

namespace HotelCheckInSystem.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, string roomType, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsAvailable = isAvailable;
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }

        public void MarkAsOccupied()
        {
            IsAvailable = false;
        }

        public void MarkAsAvailable()
        {
            IsAvailable = true;
        }
    }
}