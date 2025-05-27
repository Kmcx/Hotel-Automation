using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class CheckOutForm
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
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Out";
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Label (sadece lblSelectRoom tutuldu)
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectRoom.Location = new System.Drawing.Point(40, 30);
            this.lblSelectRoom.Text = "Select a Room:";

            // ComboBox (dokunulmadı)
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRoom.Location = new System.Drawing.Point(200, 26);
            this.cmbRoom.Size = new System.Drawing.Size(180, 29);

            // Buton Stil Fonksiyonu
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

            // Modern butonlar
            StyleButton(this.btnCheckOut, "✅ Check-Out", new Point(250, 80));
            StyleButton(this.btnBack, "⬅ Back", new Point(80, 80));

            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Ekle
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnBack);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
    }
}