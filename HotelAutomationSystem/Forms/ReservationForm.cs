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
    public partial class ReservationForm : Form
    {
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";

        public ReservationForm()
        {
            InitializeComponent();
            CreateReservationsTableIfNotExist();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadAvailableRooms();

        }
        private void CreateReservationsTableIfNotExist()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                try
                {
                    string createQuery = @"
                    CREATE TABLE IF NOT EXISTS Reservations (
                    ReservationId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    PhoneNumber TEXT,
                    RoomNumber INTEGER,
                    CheckInDate TEXT,
                    CheckOutDate TEXT
                      )";
                    SQLiteCommand cmd = new SQLiteCommand(createQuery, conn);
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void LoadAvailableRooms()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomNumber FROM Rooms WHERE IsAvailable = 1";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRoom.DisplayMember = "RoomNumber";
                cmbRoom.ValueMember = "RoomNumber";
                cmbRoom.DataSource = dt;

                conn.Close();
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            

            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;
            int roomNumber = Convert.ToInt32(cmbRoom.SelectedValue);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Enter guest details.");
                return;
            }

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-Out date must be after than Check-In date.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Reservations (Name, PhoneNumber, RoomNumber, CheckInDate, CheckOutDate)
                                 VALUES (@name, @phone, @room, @inDate, @outDate)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@room", roomNumber);
                cmd.Parameters.AddWithValue("@inDate", checkIn.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@outDate", checkOut.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation succesfully created.");
                conn.Close();
                this.Close();
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

