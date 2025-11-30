using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services; // Adicione este using
using HotelCheckInSystem.Views;

namespace HotelCheckInSystem
{
    public partial class MainForm : Form
    {
        // 1. Campos para armazenar os dados e serviços (Dependências)
        private List<Reservation> _reservations;
        private ReservationService _reservationService; 
        private RoomService _roomService;               
        private ReportService _reportService;

        public MainForm()
        {
            InitializeComponent();
            
            // 2. Inicialização dos dados e serviços
            _reservations = new List<Reservation>(); 
            // Você pode adicionar algumas reservas de teste aqui:
            // _reservations.Add(new Reservation { /* ... */ });

            // Inicializando serviços. O ReportService depende da lista de reservas.
            _reportService = new ReportService(_reservations); 
            
            // Assumindo que ReservationService e RoomService têm construtores sem argumentos
            _reservationService = new ReservationService();
            _roomService = new RoomService();
        }

        private void btnGuestRegistration_Click(object sender, EventArgs e)
        {
            GuestRegistrationForm guestRegistrationForm = new GuestRegistrationForm();
            guestRegistrationForm.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // Passando as dependências para CheckInForm
            CheckInForm checkInForm = new CheckInForm(_reservationService, _roomService);
            checkInForm.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // CORREÇÃO: Passando a dependência para CheckOutForm
            CheckOutForm checkOutForm = new CheckOutForm(_reservationService);
            checkOutForm.ShowDialog();
        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {
            RoomAvailabilityForm roomAvailabilityForm = new RoomAvailabilityForm();
            roomAvailabilityForm.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Passando as dependências para ReportForm
            ReportForm reportForm = new ReportForm(_reportService);
            reportForm.ShowDialog();
        }
    }
}