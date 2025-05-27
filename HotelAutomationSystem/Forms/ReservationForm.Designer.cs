using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label ve Input bileşenleri (değişmedi)
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(44, 26);
            this.lblName.Text = "Guest Name : ";

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPhone.Location = new System.Drawing.Point(44, 67);
            this.lblPhone.Text = "Phone Number : ";

            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCheckIn.Location = new System.Drawing.Point(45, 114);
            this.lblCheckIn.Text = "Check-In Date : ";

            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCheckOut.Location = new System.Drawing.Point(44, 155);
            this.lblCheckOut.Text = "Check-Out Date : ";

            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRoom.Location = new System.Drawing.Point(44, 198);
            this.lblRoom.Text = "Select a Room : ";

            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(241, 26);
            this.txtName.Size = new System.Drawing.Size(200, 30);

            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPhone.Location = new System.Drawing.Point(241, 67);
            this.txtPhone.Size = new System.Drawing.Size(200, 30);

            this.dtpCheckIn.Location = new System.Drawing.Point(241, 114);
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);

            this.dtpCheckOut.Location = new System.Drawing.Point(241, 155);
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);

            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbRoom.Location = new System.Drawing.Point(241, 195);
            this.cmbRoom.Size = new System.Drawing.Size(121, 33);

            // Buton Stilleri
            Font btnFont = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            Size btnSize = new System.Drawing.Size(198, 45);
            Color btnColor = Color.FromArgb(100, 149, 237);
            Color textColor = Color.White;

            void StyleButton(Button btn, string text, Point location)
            {
                btn.Text = text;
                btn.Size = btnSize;
                btn.Location = location;
                btn.Font = btnFont;
                btn.BackColor = btnColor;
                btn.ForeColor = textColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            StyleButton(this.btnReserve, "📝 Reserve", new Point(320, 250));
            StyleButton(this.btnBack, "⬅ Back", new Point(20, 250));

            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form ayarları
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 308);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBack;
    }
}