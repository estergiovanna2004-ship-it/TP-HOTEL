using System;
using System.Windows.Forms;
using HotelCheckInSystem.Views;

namespace HotelCheckInSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGuestRegistration_Click(object sender, EventArgs e)
        {
            GuestRegistrationForm guestRegistrationForm = new GuestRegistrationForm();
            guestRegistrationForm.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            checkOutForm.ShowDialog();
        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {
            RoomAvailabilityForm roomAvailabilityForm = new RoomAvailabilityForm();
            roomAvailabilityForm.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}