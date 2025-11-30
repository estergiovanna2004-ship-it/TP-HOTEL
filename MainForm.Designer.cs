using System.Windows.Forms;

namespace HotelCheckInSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGuestRegistration = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRoomAvailability = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuestRegistration
            // 
            this.btnGuestRegistration.Location = new System.Drawing.Point(12, 12);
            this.btnGuestRegistration.Name = "btnGuestRegistration";
            this.btnGuestRegistration.Size = new System.Drawing.Size(150, 50);
            this.btnGuestRegistration.TabIndex = 0;
            this.btnGuestRegistration.Text = "Registro de Hóspede";
            this.btnGuestRegistration.UseVisualStyleBackColor = true;
            this.btnGuestRegistration.Click += new System.EventHandler(this.btnGuestRegistration_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(12, 68);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 50);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(12, 124);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(150, 50);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRoomAvailability
            // 
            this.btnRoomAvailability.Location = new System.Drawing.Point(12, 180);
            this.btnRoomAvailability.Name = "btnRoomAvailability";
            this.btnRoomAvailability.Size = new System.Drawing.Size(150, 50);
            this.btnRoomAvailability.TabIndex = 3;
            this.btnRoomAvailability.Text = "Disponibilidade de Quartos";
            this.btnRoomAvailability.UseVisualStyleBackColor = true;
            this.btnRoomAvailability.Click += new System.EventHandler(this.btnRoomAvailability_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 236);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnRoomAvailability);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnGuestRegistration);
            this.Name = "MainForm";
            this.Text = "Sistema de Check-In de Hotel";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGuestRegistration;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRoomAvailability;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}