using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class GuestRegistrationForm : Form
    {
        private readonly ReservationService _reservationService;

        public GuestRegistrationForm()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int id = GenerateGuestId(); // Generate a unique ID
            var guest = new Guest(id, txtName.Text, txtContactInfo.Text);

            // Logic to save guest information
            // For example, you might call a method in a service to save the guest
            // _guestService.SaveGuest(guest);

            MessageBox.Show("Guest registered successfully!");
            ClearFields();
        }

        private int GenerateGuestId()
        {
            // Simple ID generation, in a real app, this would be handled by the database
            return new Random().Next(1, 10000);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Logic to update guest information
            MessageBox.Show("Guest updated successfully!");
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtContactInfo.Clear();
        }
    }
}