/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EventHub
{
    // Loads transaction belonging to current member
    public partial class TransactionsForm : Form
    {
        private Member currentMember;
        public TransactionsForm(Member member)
        {
            InitializeComponent();

            currentMember = member;

            loadTransactions();
        }

        // Displays member transactions in DataGridView
        private void loadTransactions()
        {
            dgvTransactions.DataSource = null;

            dgvTransactions.DataSource = DataStore.Transactions
                .Where(t => t.MemberEmail == currentMember.Email)
                .ToList();
        }

        // Closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}