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
    public partial class CheckOutForm : Form
    {
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";

        public CheckOutForm()
        {
            InitializeComponent();
            this.Load += CheckOutForm_Load;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            btnCheckOut.Click += btnCheckOut_Click;

        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            LoadOccupiedRooms();
            

        }

        private void LoadOccupiedRooms()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT RoomNumber FROM Rooms WHERE IsAvailable = 0";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRoom.DisplayMember = "RoomNumber";
                cmbRoom.ValueMember = "RoomNumber";
                cmbRoom.DataSource = dt;

                conn.Close();
            }

            
        }


        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

    





        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem == null)
            {
                MessageBox.Show("Please select a room to check out.");
                return;
            }

            int roomNumber = Convert.ToInt32(((DataRowView)cmbRoom.SelectedItem)["RoomNumber"]);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string updateRoomQuery = "UPDATE Rooms SET IsAvailable = 1 WHERE RoomNumber = @room";
                SQLiteCommand updateRoomCmd = new SQLiteCommand(updateRoomQuery, conn);
                updateRoomCmd.Parameters.AddWithValue("@room", roomNumber);
                int rows = updateRoomCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show($"Room {roomNumber} has been checked out successfully.");
                    LoadOccupiedRooms(); 
                     
                }
                else
                {
                    MessageBox.Show("Check-out failed.");
                }

                conn.Close();
            }
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOutForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

