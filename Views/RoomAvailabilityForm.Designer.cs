using System.Windows.Forms;

namespace HotelCheckInSystem.Views
{
    partial class RoomAvailabilityForm
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
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lstAvailableRooms = new System.Windows.Forms.ListBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // dtpCheckIn
            //
            this.dtpCheckIn.Location = new System.Drawing.Point(100, 30);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 0;
            //
            // dtpCheckOut
            //
            this.dtpCheckOut.Location = new System.Drawing.Point(100, 60);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 1;
            //
            // lstAvailableRooms
            //
            this.lstAvailableRooms.FormattingEnabled = true;
            this.lstAvailableRooms.Location = new System.Drawing.Point(100, 120);
            this.lstAvailableRooms.Name = "lstAvailableRooms";
            this.lstAvailableRooms.Size = new System.Drawing.Size(200, 200);
            this.lstAvailableRooms.TabIndex = 2;
            //
            // btnCheckAvailability
            //
            this.btnCheckAvailability.Location = new System.Drawing.Point(100, 90);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(120, 25);
            this.btnCheckAvailability.TabIndex = 3;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            //
            // lblCheckIn
            //
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 30);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check In:";
            //
            // lblCheckOut
            //
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(20, 60);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(60, 13);
            this.lblCheckOut.TabIndex = 5;
            this.lblCheckOut.Text = "Check Out:";
            //
            // lblAvailableRooms
            //
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Location = new System.Drawing.Point(20, 120);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(80, 13);
            this.lblAvailableRooms.TabIndex = 6;
            this.lblAvailableRooms.Text = "Available Rooms:";
            //
            // RoomAvailabilityForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lblAvailableRooms);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.lstAvailableRooms);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Name = "RoomAvailabilityForm";
            this.Text = "Room Availability";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.ListBox lstAvailableRooms;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblAvailableRooms;
    }
}
