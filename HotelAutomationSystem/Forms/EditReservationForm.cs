using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAutomationSystem.Forms
{
    public partial class EditReservationForm : Form
    {

        private string connectionString = "Data Source=Database\\hotel.db;Version=3;";
        private int reservationId;
        public EditReservationForm(int id, string name, string phone, DateTime inDate, DateTime outDate)
        {

            InitializeComponent();
            reservationId = id;
            txtName.Text = name;
            txtPhone.Text = phone;
            dtpCheckIn.Value = inDate;
            dtpCheckOut.Value = outDate;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                MessageBox.Show("Check-Out date must be after than Check-In date");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Reservations
                            SET Name = @name, PhoneNumber = @phone,
                                CheckInDate = @inDate, CheckOutDate = @outDate
                            WHERE ReservationId = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@inDate", dtpCheckIn.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@outDate", dtpCheckOut.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id", reservationId);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Rezervation updated.");
            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

        
    
