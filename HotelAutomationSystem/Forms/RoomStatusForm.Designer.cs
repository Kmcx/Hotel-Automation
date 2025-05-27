using System.Drawing;

namespace HotelAutomationSystem.Forms
{
    partial class RoomStatusForm
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
            this.dgvRoomStatus = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomStatus)).BeginInit();
            this.SuspendLayout();

            // DataGridView — dokunulmadı
            this.dgvRoomStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomStatus.Location = new System.Drawing.Point(12, 102);
            this.dgvRoomStatus.Name = "dgvRoomStatus";
            this.dgvRoomStatus.Size = new System.Drawing.Size(610, 487);
            this.dgvRoomStatus.TabIndex = 0;

            // Buton stil ayarları
            Font btnFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Color btnColor = System.Drawing.Color.FromArgb(100, 149, 237);
            Color textColor = System.Drawing.Color.White;

            this.btnBack.Text = "⬅ Back";
            this.btnBack.Size = new System.Drawing.Size(130, 45);
            this.btnBack.Location = new System.Drawing.Point(12, 25);
            this.btnBack.Font = btnFont;
            this.btnBack.BackColor = btnColor;
            this.btnBack.ForeColor = textColor;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 638);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvRoomStatus);
            this.Name = "RoomStatusForm";
            this.Text = "Room Status";
            this.Load += new System.EventHandler(this.RoomStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomStatus)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvRoomStatus;
        private System.Windows.Forms.Button btnBack;
    }
}