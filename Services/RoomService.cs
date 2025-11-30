using System;
using System.Collections.Generic;
using HotelCheckInSystem.Models;

namespace HotelCheckInSystem.Services
{
    public class RoomService
    {
        private List<Room> rooms;

        public RoomService()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }

        public List<Room> GetAvailableRooms()
        {
            return rooms.FindAll(r => r.IsAvailable);
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            return rooms.Find(r => r.RoomNumber == roomNumber);
        }

        public void UpdateRoomAvailability(int roomNumber, bool isAvailable)
        {
            Room room = GetRoomByNumber(roomNumber);
            if (room != null)
            {
                room.IsAvailable = isAvailable;
            }
        }

        public bool IsRoomAvailable(int roomNumber)
        {
            Room room = GetRoomByNumber(roomNumber);
            return room != null && room.IsAvailable;
        }

        public List<Room> CheckRoomAvailability(DateTime checkIn, DateTime checkOut)
        {
            // For simplicity, return all available rooms, ignoring dates
            return GetAvailableRooms();
        }
    }
}
