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
using System.Data;

namespace HotelAutomationSystem.Forms
{
    public partial class CheckInForm : Form
    {

        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";

        public CheckInForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(CheckInForm_Load);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            
            LoadAvailableRooms();
            
        }

        private void LoadAvailableRooms()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomNumber FROM Rooms WHERE IsAvailable = 1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRoomNumber.DisplayMember = "RoomNumber";
                cmbRoomNumber.ValueMember = "RoomNumber";
                cmbRoomNumber.DataSource = dt;

                conn.Close();
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            int roomNumber = Convert.ToInt32(cmbRoomNumber.SelectedValue);

            if (guestName == "" || phoneNumber == "")
            {
                MessageBox.Show("Please fill all inputs.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                
                string insertGuest = "INSERT INTO Guests (Name, PhoneNumber) VALUES (@name, @phone)";
                SQLiteCommand cmd1 = new SQLiteCommand(insertGuest, conn);
                cmd1.Parameters.AddWithValue("@name", guestName);
                cmd1.Parameters.AddWithValue("@phone", phoneNumber);
                cmd1.ExecuteNonQuery();

                
                string updateRoom = "UPDATE Rooms SET IsAvailable = 0 WHERE RoomNumber = @roomNo";
                SQLiteCommand cmd2 = new SQLiteCommand(updateRoom, conn);
                cmd2.Parameters.AddWithValue("@roomNo", roomNumber);
                cmd2.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Guest successfully checked-in!.");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckInForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
