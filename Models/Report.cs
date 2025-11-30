using System;

namespace HotelCheckInSystem.Models
{
    public class Report
    {
        public Guid ReportId { get; set; }
        public DateTime DateGenerated { get; set; }
        public int TotalRooms { get; set; }
        public int OccupiedRooms { get; set; }
        public double OccupancyRate { get; set; }

        public Report(Guid reportId, DateTime dateGenerated)
        {
            ReportId = reportId;
            DateGenerated = dateGenerated;
        }

        public void GenerateOccupancyReport()
        {
            // Logic to generate occupancy report
        }
    }
}
