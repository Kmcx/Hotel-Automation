using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HotelAutomationSystem.Forms
{
    public partial class ReservationListForm : Form
    {

        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";

        public ReservationListForm()
        {
            InitializeComponent();
            this.Load += ReservationListForm_Load;
            btnSearch.Click += btnSearch_Click;

        }

        private void ReservationListForm_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }
        private void LoadReservations(string nameFilter = "")
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT ReservationId, Name, PhoneNumber, RoomNumber, CheckInDate, CheckOutDate FROM Reservations";

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

                dgvReservations.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            LoadReservations(filter);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null)
            {
                MessageBox.Show("Select a reservation to edit");
                return;
            }

            int id = Convert.ToInt32(dgvReservations.CurrentRow.Cells["ReservationId"].Value);
            string name = dgvReservations.CurrentRow.Cells["Name"].Value.ToString();
            string phone = dgvReservations.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            DateTime inDate = Convert.ToDateTime(dgvReservations.CurrentRow.Cells["CheckInDate"].Value);
            DateTime outDate = Convert.ToDateTime(dgvReservations.CurrentRow.Cells["CheckOutDate"].Value);

            EditReservationForm editForm = new EditReservationForm(id, name, phone, inDate, outDate);
            editForm.FormClosed += (s, args) => LoadReservations(); // listeyi yenile
            editForm.ShowDialog();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null)
            {
                MessageBox.Show("Please select a reservation to delete.");
                return;
            }

            int reservationId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["ReservationId"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete selected reservation?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Reservations WHERE ReservationId = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Rezervation deleted.");
                LoadReservations(); 
            }
        }
    }
}
