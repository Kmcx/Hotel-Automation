using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace HotelAutomationSystem.Forms
{
    public partial class GuestSearchForm : Form
    {
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        public GuestSearchForm()
        {
            InitializeComponent();
            this.Load += GuestSearchForm_Load;
            btnSearch.Click += btnSearch_Click;

        }

        private void GuestSearchForm_Load(object sender, EventArgs e)
        {
            LoadGuests(); 
        }
        private void LoadGuests(string nameFilter = "")
        {
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT GuestId, Name, PhoneNumber FROM Guests";

                if (!string.IsNullOrWhiteSpace(nameFilter))
                {
                    query += " WHERE Name LIKE @name";
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                if (!string.IsNullOrWhiteSpace(nameFilter))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + nameFilter + "%");
                }

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGuests.DataSource = dt;

                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            LoadGuests(name); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuestSearchForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
