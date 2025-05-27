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
    public partial class RoomManagementForm : Form
    {

        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            LoadRooms();

        }

        private void LoadRooms()
        {
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomNumber, Type, Price, IsAvailable FROM Rooms";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRooms.DataSource = dt;
                conn.Close();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addForm = new AddRoomForm();
            addForm.FormClosed += (s, args) => LoadRooms();
            addForm.ShowDialog();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                int roomNumber = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomNumber"].Value);
                string type = dgvRooms.CurrentRow.Cells["Type"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvRooms.CurrentRow.Cells["Price"].Value);

                EditRoomForm editForm = new EditRoomForm(roomNumber, type, price);
                editForm.FormClosed += (s, args) => LoadRooms();
                editForm.ShowDialog();
            }

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                int roomNumber = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomNumber"].Value);

                DialogResult result = MessageBox.Show("Bu odayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Rooms WHERE RoomNumber = @roomNo";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@roomNo", roomNumber);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadRooms();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
