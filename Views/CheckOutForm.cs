using System;
using System.Windows.Forms;
using HotelCheckInSystem.Models;
using HotelCheckInSystem.Services;

namespace HotelCheckInSystem.Views
{
    public partial class CheckOutForm : Form
    {
        private readonly ReservationService reservationService; 

        // Construtor atualizado para receber a dependência
        public CheckOutForm(ReservationService reservationService)
        {
            InitializeComponent();
            this.reservationService = reservationService;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int reservationId;
            
            // 1. Tenta converter o texto para o ID da Reserva (int)
            if (int.TryParse(txtReservationId.Text, out reservationId))
            {
                // 2. Busca o objeto Reservation pelo ID
                var reservation = reservationService.GetReservationById(reservationId);
                
                if (reservation != null)
                {
                    // 3. Passar apenas o ID da reserva para o serviço
                    reservationService.CheckOut(reservation.Id); 
                    
                    MessageBox.Show("Check-out realizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de reserva válido (número inteiro).");
            }
        }
    }
}