using System.Drawing;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    partial class GuestSearchForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();

            // Label
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSearch.Location = new System.Drawing.Point(27, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(131, 25);
            this.lblSearch.Text = "Guest Name:";

            // TextBox
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(170, 53);
            this.txtSearch.Size = new System.Drawing.Size(180, 30);
            this.txtSearch.Name = "txtSearch";

            // DataGridView (dokunulmuyor)
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(43, 120);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.Size = new System.Drawing.Size(745, 192);

            // Modern buton stil ayarları
            Font btnFont = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            Size btnSize = new Size(140, 40);
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

            // Apply styles only to buttons
            StyleButton(this.btnSearch, "🔍 Search", new Point(397, 53));
            StyleButton(this.btnBack, "⬅ Back", new Point(32, 350));

            // Event bindings (değişmedi)
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form Ayarları
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.btnBack);
            this.Name = "GuestSearchForm";
            this.Text = "Guest Search";
            this.Load += new System.EventHandler(this.GuestSearchForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnBack;
    }
}