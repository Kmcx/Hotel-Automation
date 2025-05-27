using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class EditReservationForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtName
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(192, 42);
            this.txtName.Size = new System.Drawing.Size(268, 30);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(12, 47);
            this.lblName.Text = "Guest Name :";

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPhone.Location = new System.Drawing.Point(192, 117);
            this.txtPhone.Size = new System.Drawing.Size(268, 30);

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPhone.Location = new System.Drawing.Point(18, 117);
            this.lblPhone.Text = "Phone : ";

            // dtpCheckIn
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpCheckIn.Location = new System.Drawing.Point(192, 177);
            this.dtpCheckIn.Size = new System.Drawing.Size(268, 30);

            // lblCheckIn
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCheckIn.Location = new System.Drawing.Point(12, 177);
            this.lblCheckIn.Text = "Check-In Date :";

            // dtpCheckOut
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpCheckOut.Location = new System.Drawing.Point(192, 231);
            this.dtpCheckOut.Size = new System.Drawing.Size(268, 30);

            // lblCheckOut
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCheckOut.Location = new System.Drawing.Point(12, 231);
            this.lblCheckOut.Text = "Check-Out Date :";

            // Buton stilleri
            Font btnFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            Color btnColor = Color.FromArgb(100, 149, 237);
            Color textColor = Color.White;

            void StyleButton(Button btn, string text, Point location)
            {
                btn.Text = text;
                btn.Size = new System.Drawing.Size(116, 46);
                btn.Location = location;
                btn.Font = btnFont;
                btn.BackColor = btnColor;
                btn.ForeColor = textColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            StyleButton(this.btnSave, "💾 Save", new Point(344, 282));
            StyleButton(this.btnBack, "⬅ Back", new Point(17, 282));

            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(501, 340);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Name = "EditReservation";
            this.Text = "EditReservation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnBack;
    }
}