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
            // Lógica para realizar o Check-in de um hóspede
            
            // Tenta converter o ID do hóspede (assumido como ID da Reserva) para int
            if (!int.TryParse(txtGuestId.Text, out int reservationId))
            {
                MessageBox.Show("ID de Reserva inválido. Por favor, insira um número inteiro.");
                return;
            }

            // Tenta converter o ID do quarto para int
            if (!int.TryParse(txtRoomId.Text, out int roomId))
            {
                MessageBox.Show("ID do Quarto inválido. Por favor, insira um número inteiro.");
                return;
            }

            // Assumindo que IsRoomAvailable no RoomService aceita int
            if (roomService.IsRoomAvailable(roomId)) 
            {
                // Chamar CheckIn com o ID da reserva (int)
                reservationService.CheckIn(reservationId);
                MessageBox.Show("Check-in realizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("O quarto não está disponível.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}