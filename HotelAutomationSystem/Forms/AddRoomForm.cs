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
    public partial class AddRoomForm : Form
    {
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all areas.");
                return;
            }

            if (!int.TryParse(txtNumber.Text, out int roomNumber) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Room number and price must be valid numbers!");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Rooms (RoomNumber, Type, Price, IsAvailable) VALUES (@number, @type, @price, 1)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@number", roomNumber);
                cmd.Parameters.AddWithValue("@type", txtType.Text.Trim());
                cmd.Parameters.AddWithValue("@price", price);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room added succesfully.");
                    this.Close();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Adding room failed. " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

