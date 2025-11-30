using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class RoomAvailabilityForm : Form
    {
        private readonly RoomService _roomService;

        public RoomAvailabilityForm()
        {
            InitializeComponent();
            _roomService = new RoomService();
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = dtpCheckIn.Value;
            DateTime checkOutDate = dtpCheckOut.Value;

            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var availableRooms = _roomService.CheckRoomAvailability(checkInDate, checkOutDate);
            lstAvailableRooms.Items.Clear();

            foreach (var room in availableRooms)
            {
                lstAvailableRooms.Items.Add(room.RoomNumber);
            }

            if (availableRooms.Count == 0)
            {
                MessageBox.Show("No rooms available for the selected dates.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}