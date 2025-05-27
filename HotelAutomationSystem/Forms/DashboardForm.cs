using HotelAutomationSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAutomationSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomManagementForm roomManagementForm = new RoomManagementForm();
            roomManagementForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.ShowDialog(); 
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            checkOutForm.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }

        private void btnGuestSearch_Click(object sender, EventArgs e)
        {
            GuestSearchForm guestSearchForm = new GuestSearchForm();
            guestSearchForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            ReservationListForm form = new ReservationListForm();
            form.ShowDialog();
        }

        private void btnRoomStatus_Click(object sender, EventArgs e)
        {
            RoomStatusForm form = new RoomStatusForm();
            form.ShowDialog();
        }
    }
}
