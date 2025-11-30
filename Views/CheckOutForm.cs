using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class CheckOutForm : Form
    {
        private ReservationService reservationService;

        public CheckOutForm()
        {
            InitializeComponent();
            reservationService = new ReservationService();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int reservationId;
            if (int.TryParse(txtReservationId.Text, out reservationId))
            {
                var reservation = reservationService.GetReservationById(reservationId);
                if (reservation != null)
                {
                    reservationService.CheckOut(reservation);
                    MessageBox.Show("Check-out successful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid reservation ID.");
            }
        }
    }
}