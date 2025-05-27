using System.Drawing;
using System.Windows.Forms;
using System;

namespace HotelAutomationSystem
{
    partial class DashboardForm
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
            this.label1 = new Label();
            this.btnRoomManagement = new Button();
            this.btnGuestSearch = new Button();
            this.btnReservation = new Button();
            this.btnViewReservations = new Button();
            this.btnLogout = new Button();
            this.btnCheckIn = new Button();
            this.btnCheckOut = new Button();
            this.btnRoomStatus = new Button();
            PictureBox logoIcon = new PictureBox();

            this.SuspendLayout();

            // Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(780, 620);
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "🏨 Hotel Dashboard";
            this.label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);

            // Başlık ikonu
            logoIcon.Size = new Size(48, 48);
            logoIcon.Location = new Point(30, 20);
            logoIcon.SizeMode = PictureBoxSizeMode.Zoom;

            // Başlık yazısı
            this.label1.Text = "🏨 Hotel Automation";
            this.label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.label1.ForeColor = Color.FromArgb(40, 40, 40);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(90, 25);

            // Ortak buton stili
            Font buttonFont = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            Size longButtonSize = new Size(260, 60);
            Size squareButtonSize = new Size(140, 100);
            Color primaryColor = Color.FromArgb(63, 114, 175); // mavi
            Color textColor = Color.White;

            // Yardımcı fonksiyon
            void StyleButton(Button btn, string text, Point location, Size size, Color color)
            {
                btn.Text = text;
                btn.Size = size;
                btn.Location = location;
                btn.Font = buttonFont;
                btn.BackColor = color;
                btn.ForeColor = textColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            int xLeft = 40, xRight1 = 350, xRight2 = 520;
            int yStart = 100, spacing = 90;

            StyleButton(btnRoomManagement, "🛏 Room Management", new Point(xLeft, yStart + spacing * 0), longButtonSize, primaryColor);
            StyleButton(btnGuestSearch, "👤 Guest Search", new Point(xLeft, yStart + spacing * 1), longButtonSize, primaryColor);
            StyleButton(btnReservation, "📅 Make Reservation", new Point(xLeft, yStart + spacing * 2), longButtonSize, primaryColor);
            StyleButton(btnViewReservations, "📋 View Reservations", new Point(xLeft, yStart + spacing * 3), longButtonSize, primaryColor);
            StyleButton(btnLogout, "❌ Exit", new Point(xLeft, yStart + spacing * 4), longButtonSize, Color.IndianRed);

            StyleButton(btnCheckIn, "✅ Check-In", new Point(xRight1, yStart + spacing * 0), squareButtonSize, primaryColor);
            StyleButton(btnCheckOut, "⛔ Check-Out", new Point(xRight2, yStart + spacing * 0), squareButtonSize, primaryColor);
            StyleButton(btnRoomStatus, "📊 Room Status", new Point(xRight1, yStart + spacing * 2), new Size(300, 70), primaryColor);

            // Events
            btnRoomManagement.Click += new EventHandler(this.button1_Click);
            btnGuestSearch.Click += new EventHandler(this.btnGuestSearch_Click);
            btnReservation.Click += new EventHandler(this.btnReservation_Click);
            btnViewReservations.Click += new EventHandler(this.btnViewReservations_Click);
            btnLogout.Click += new EventHandler(this.btnLogout_Click);
            btnCheckIn.Click += new EventHandler(this.btnCheckIn_Click);
            btnCheckOut.Click += new EventHandler(this.btnCheckOut_Click);
            btnRoomStatus.Click += new EventHandler(this.btnRoomStatus_Click);

            // Controls
            this.Controls.Add(label1);
            this.Controls.Add(logoIcon);
            this.Controls.Add(btnRoomManagement);
            this.Controls.Add(btnGuestSearch);
            this.Controls.Add(btnReservation);
            this.Controls.Add(btnViewReservations);
            this.Controls.Add(btnLogout);
            this.Controls.Add(btnCheckIn);
            this.Controls.Add(btnCheckOut);
            this.Controls.Add(btnRoomStatus);

            this.ResumeLayout(false);
            this.PerformLayout();
        }




        #endregion

        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGuestSearch;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnRoomStatus;
    }
}