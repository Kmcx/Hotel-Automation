using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class RoomManagementForm
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();

            // dgvRooms - orijinal hali korunuyor
            this.dgvRooms.Location = new System.Drawing.Point(12, 12);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(776, 231);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Ortak buton stilleri
            Font btnFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            Size btnSize = new Size(140, 55);
            Color btnColor = Color.FromArgb(100, 149, 237); // mavi
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

            
            StyleButton(this.btnAddRoom, "➕ Add", new Point(30, 260));
            StyleButton(this.btnEditRoom, "✏ Edit", new Point(190, 260));
            StyleButton(this.btnDeleteRoom, "🗑 Delete", new Point(350, 260));
            StyleButton(this.btnBack, "⬅ Back", new Point(510, 260));

            
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnBack);
            this.Name = "RoomManagementForm";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnBack;
    }
}