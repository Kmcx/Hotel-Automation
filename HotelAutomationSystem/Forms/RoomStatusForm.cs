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
    public partial class RoomStatusForm : Form
    {
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        public RoomStatusForm()
        {
            InitializeComponent();
            this.Load += RoomStatusForm_Load;
        }

        private void RoomStatusForm_Load(object sender, EventArgs e)
        {
            LoadRooms(); 
        }

        private void LoadRooms()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomNumber, Type, Price, CASE WHEN IsAvailable = 1 THEN 'Empty' ELSE 'Occupied' END AS Status FROM Rooms";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRoomStatus.DataSource = dt;
                conn.Close();
            }

            // Set layout and coloring
          


            dgvRoomStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in dgvRoomStatus.Rows)
            {
                var statusCell = row.Cells["Status"];
                if (statusCell.Value?.ToString() == "Empty")
                {
                    statusCell.Style.BackColor = Color.LightGreen;
                }
                else
                {
                    statusCell.Style.BackColor = Color.LightCoral;
                }
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
