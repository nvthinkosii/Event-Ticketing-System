/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

using System;
using System.Windows.Forms;

namespace EventHub
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            RefreshUsers(); 
            RefreshEvents(); 
        }

        private void RefreshUsers() // Refreshes the users DataGridView
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = DataStore.Members;
        }
        private void RefreshEvents() // Refreshes the events DataGridView
        {
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = DataStore.Events;
        }

        // Adds a new member to the system
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member(
                    txtName.Text,
                    txtEmail.Text,
                    decimal.Parse(txtBalance.Text),
                    txtPassword.Text
                );

                DataStore.Members.Add(member);

                RefreshUsers();

                MessageBox.Show("User Added Successfully");
            }
            catch
            {
                MessageBox.Show("Invalid User Data");
            }
        }

        // Adds a new event to the system
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Event ev = new Event(
                        txtEventName.Text,
                        decimal.Parse(txtPrice.Text),
                        int.Parse(txtTickets.Text));

                DataStore.Events.Add(ev);

                RefreshEvents();

                MessageBox.Show("Event Added Successfully");
            }
            catch
            {
                MessageBox.Show("Invalid Event Data");
            }
        }

        // Updates the selected event details
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow == null || dgvEvents.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            Event ev = dgvEvents.CurrentRow.DataBoundItem as Event;

            if (ev == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            ev.EventName = txtEventName.Text;
            ev.Price = decimal.Parse(txtPrice.Text);
            ev.AvailableTickets = int.Parse(txtTickets.Text);

            RefreshEvents();
        }

        // Removes the selected event from the system
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow == null || dgvEvents.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            Event ev = dgvEvents.CurrentRow.DataBoundItem as Event;

            if (ev == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            DataStore.Events.Remove(ev);

            RefreshEvents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }
    }
}
