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
using System.Diagnostics;

namespace HotelAutomationSystem.Forms
{
    public partial class EditRoomForm : Form
    {

        private int roomNumber;
        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        public EditRoomForm(int roomNumber, string type, decimal price)
        {
            InitializeComponent();

            this.roomNumber = roomNumber;
            txtNumber.Text = roomNumber.ToString();
            txtType.Text = type;
            txtPrice.Text = price.ToString("0.00");
            txtNumber.ReadOnly = true;
        }

        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            // 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtType.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Fill all areas.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Rooms SET Type = @type, Price = @price WHERE RoomNumber = @number";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", txtType.Text.Trim());
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@number", roomNumber);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room succesfully updated.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error: " + ex.Message);
                }
            }
        }  
    }
}
