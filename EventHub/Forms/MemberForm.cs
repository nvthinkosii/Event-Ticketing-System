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
    // Loads available events for the logged in member
    public partial class MemberForm : Form
    {
        private Member currentMember;
        public MemberForm(Member member)
        {
            InitializeComponent();

            currentMember = member;

            cboEvents.DataSource = DataStore.Events;
            cboEvents.DisplayMember = "EventName";
        }

        // Calculates total ticket cost based on quantity selected
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Event ev = (Event)cboEvents.SelectedItem;

                int quantity = (int)nudTickets.Value;

                decimal total = ev.Price * quantity;

                txtTotalCost.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Please select an event.");
            }
        }

        // Processes ticket booking
        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEvents.SelectedItem == null)
                {
                    MessageBox.Show("Select an event.");
                    return;
                }
                Event ev = (Event)cboEvents.SelectedItem;

                int qty = (int)nudTickets.Value;

                decimal total = ev.Price * qty;

                if (qty > ev.AvailableTickets)
                {
                    MessageBox.Show("Not enough tickets available.");
                    return;
                }

                if (total > currentMember.Balance)
                {
                    MessageBox.Show("Insufficient balance.");
                    return;
                }

                // Deduct values
                currentMember.Balance -= total;
                ev.AvailableTickets -= qty;

                // Create transaction (CLEAN WAY)
                Transaction t = new Transaction(
                    ev.EventName,
                    total,
                    currentMember.Email
                );

                DataStore.Transactions.Add(t);

                MessageBox.Show("Booking successful!");
            }
            catch
            {
                MessageBox.Show("Booking failed. Check inputs.");
            }
        }

        // Transaction history
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm frm = new TransactionsForm(currentMember);

            frm.Show();
        }

        // Returns user to login screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();

            frm.Show();

            this.Close();
        }
    }
}