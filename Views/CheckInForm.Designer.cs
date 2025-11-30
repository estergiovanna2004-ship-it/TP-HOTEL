using System.Windows.Forms;

namespace HotelCheckInSystem.Views
{
    partial class CheckInForm
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
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblGuestId = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtGuestId
            //
            this.txtGuestId.Location = new System.Drawing.Point(100, 60);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(200, 20);
            this.txtGuestId.TabIndex = 0;
            //
            // txtRoomId
            //
            this.txtRoomId.Location = new System.Drawing.Point(100, 90);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(200, 20);
            this.txtRoomId.TabIndex = 1;
            //
            // btnCheckIn
            //
            this.btnCheckIn.Location = new System.Drawing.Point(100, 120);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 25);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            //
            // lblGuestId
            //
            this.lblGuestId.AutoSize = true;
            this.lblGuestId.Location = new System.Drawing.Point(20, 60);
            this.lblGuestId.Name = "lblGuestId";
            this.lblGuestId.Size = new System.Drawing.Size(50, 13);
            this.lblGuestId.TabIndex = 3;
            this.lblGuestId.Text = "Guest ID:";
            //
            // lblRoomId
            //
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(20, 90);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(50, 13);
            this.lblRoomId.TabIndex = 4;
            this.lblRoomId.Text = "Room ID:";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Check In";
            //
            // CheckInForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.lblGuestId);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.txtGuestId);
            this.Name = "CheckInForm";
            this.Text = "Check In";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblTitle;
    }
}
