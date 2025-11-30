using System;
using System.Collections.Generic;
using HotelCheckInSystem.Models;

namespace HotelCheckInSystem.Services
{
    public class ReservationService
    {
        private List<Reservation> reservations;

        public ReservationService()
        {
            reservations = new List<Reservation>();
        }

        public void CreateReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void UpdateReservation(Reservation reservation)
        {
            var existingReservation = reservations.Find(r => r.Id == reservation.Id);
            if (existingReservation != null)
            {
                existingReservation.GuestId = reservation.GuestId;
                existingReservation.RoomId = reservation.RoomId;
                existingReservation.CheckInDate = reservation.CheckInDate;
                existingReservation.CheckOutDate = reservation.CheckOutDate;
            }
        }

        public void DeleteReservation(int reservationId)
        {
            var reservation = reservations.Find(r => r.Id == reservationId);
            if (reservation != null)
            {
                reservations.Remove(reservation);
            }
        }

        public List<Reservation> GetAllReservations()
        {
            return reservations;
        }

        public Reservation GetReservationById(int reservationId)
        {
            return reservations.Find(r => r.Id == reservationId);
        }

        public void CheckIn(int reservationId)
        {
            var reservation = GetReservationById(reservationId);
            if (reservation != null)
            {
                // Lógica para dar check-in ao hóspede
                // Exemplo: atualizar o status da reserva ou marcar como checked in
            }
        }

        public void CheckOut(int reservationId)
        {
            var reservation = GetReservationById(reservationId);
            if (reservation != null)
            {
                // Lógica para dar check-out ao hóspede
                // Exemplo: atualizar o status da reserva ou marcar como checked out
            }
        }
    }
}