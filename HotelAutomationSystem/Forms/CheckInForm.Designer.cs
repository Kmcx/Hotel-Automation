using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class CheckInForm
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblRomNumber = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form ayarları
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Check-In";

            // Modern fontlar
            Font labelFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            Font inputFont = new Font("Segoe UI", 11F);

            // lblGuestName
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = labelFont;
            this.lblGuestName.Location = new System.Drawing.Point(35, 28);
            this.lblGuestName.Text = "Guest Name:";

            // txtGuestName
            this.txtGuestName.Font = inputFont;
            this.txtGuestName.Location = new System.Drawing.Point(180, 25);
            this.txtGuestName.Size = new System.Drawing.Size(250, 27);

            // lblPhoneNumber
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = labelFont;
            this.lblPhoneNumber.Location = new System.Drawing.Point(35, 75);
            this.lblPhoneNumber.Text = "Phone Number:";

            // txtPhoneNumber
            this.txtPhoneNumber.Font = inputFont;
            this.txtPhoneNumber.Location = new System.Drawing.Point(180, 72);
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 27);

            // lblRomNumber
            this.lblRomNumber.AutoSize = true;
            this.lblRomNumber.Font = labelFont;
            this.lblRomNumber.Location = new System.Drawing.Point(35, 122);
            this.lblRomNumber.Text = "Available Rooms:";

            // cmbRoomNumber — dokunulmuyor
            this.cmbRoomNumber.Location = new System.Drawing.Point(180, 120);
            this.cmbRoomNumber.Size = new System.Drawing.Size(250, 21); // özgün yapı korunuyor

            // Buton stili
            Font btnFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            Color btnColor = Color.FromArgb(100, 149, 237);
            Color textColor = Color.White;

            void StyleButton(Button btn, string text, Point location)
            {
                btn.Text = text;
                btn.Size = new Size(130, 45);
                btn.Location = location;
                btn.Font = btnFont;
                btn.BackColor = btnColor;
                btn.ForeColor = textColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            StyleButton(this.btnCheckIn, "✅ Check-In", new Point(300, 170));
            StyleButton(this.btnBack, "⬅ Back", new Point(35, 170));

            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Kontrolleri ekle
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblRomNumber);
            this.Controls.Add(this.cmbRoomNumber); // untouched
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnBack);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblRomNumber;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBack;
    }
}