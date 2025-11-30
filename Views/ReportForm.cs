using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class ReportForm : Form
    {
        private readonly ReportService reportService;

        public ReportForm(ReportService reportService)
        {
            InitializeComponent();
            this.reportService = reportService;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Generate occupancy report for the current month
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var report = reportService.GenerateOccupancyReport(startDate, endDate);

            // Display the report in the DataGridView
            dgvReports.DataSource = new[] { report };
        }
    }
}
