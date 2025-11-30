using System;
using System.Collections.Generic;
using HotelCheckInSystem.Models;

namespace HotelCheckInSystem.Services
{
    public class ReportService
    {
        private List<Reservation> reservations;

        public ReportService(List<Reservation> reservations)
        {
            this.reservations = reservations;
        }

        public Report GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            int totalRooms = 0;
            int occupiedRooms = 0;

            foreach (var reservation in reservations)
            {
                if (reservation.CheckInDate >= startDate && reservation.CheckOutDate <= endDate)
                {
                    occupiedRooms++;
                }
            }

            totalRooms = reservations.Count; // Assumindo que cada reserva corresponde a um quarto

            // CORREÇÃO: Usando o construtor explícito (Report.cs requer Guid e DateTime)
            return new Report(Guid.NewGuid(), DateTime.Now)
            {
                TotalRooms = totalRooms,
                OccupiedRooms = occupiedRooms,
                OccupancyRate = totalRooms > 0 ? (double)occupiedRooms / totalRooms * 100 : 0
            };
        }
    }
}