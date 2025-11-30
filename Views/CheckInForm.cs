using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class CheckInForm : Form
    {
        private readonly ReservationService reservationService;
        private readonly RoomService roomService;

        public CheckInForm(ReservationService reservationService, RoomService roomService)
        {
            InitializeComponent();
            this.reservationService = reservationService;
            this.roomService = roomService;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // Logic for checking in a guest
            var guestId = txtGuestId.Text;
            var roomId = txtRoomId.Text;

            if (roomService.IsRoomAvailable(roomId))
            {
                reservationService.CheckIn(guestId, roomId);
                MessageBox.Show("Check-in successful!");
            }
            else
            {
                MessageBox.Show("Room is not available.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}