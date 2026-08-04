namespace EventHub
{
    partial class MemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.nudTickets = new System.Windows.Forms.NumericUpDown();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblselectEvent = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(95, 141);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // cboEvents
            // 
            this.cboEvents.FormattingEnabled = true;
            this.cboEvents.Location = new System.Drawing.Point(292, 44);
            this.cboEvents.Name = "cboEvents";
            this.cboEvents.Size = new System.Drawing.Size(121, 21);
            this.cboEvents.TabIndex = 2;
            // 
            // nudTickets
            // 
            this.nudTickets.Location = new System.Drawing.Point(293, 89);
            this.nudTickets.Name = "nudTickets";
            this.nudTickets.Size = new System.Drawing.Size(120, 20);
            this.nudTickets.TabIndex = 3;
            this.nudTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(293, 213);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(113, 23);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book Tickets";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(293, 242);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(113, 23);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "View Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(666, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblselectEvent
            // 
            this.lblselectEvent.AutoSize = true;
            this.lblselectEvent.Location = new System.Drawing.Point(95, 47);
            this.lblselectEvent.Name = "lblselectEvent";
            this.lblselectEvent.Size = new System.Drawing.Size(68, 13);
            this.lblselectEvent.TabIndex = 7;
            this.lblselectEvent.Text = "Select Event";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(95, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(292, 134);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(120, 20);
            this.txtTotalCost.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Location = new System.Drawing.Point(293, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblselectEvent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.nudTickets);
            this.Controls.Add(this.cboEvents);
            this.Controls.Add(this.lblTotalCost);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MemberForm";
            this.Text = "Event Hub";
            ((System.ComponentModel.ISupportInitialize)(this.nudTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ComboBox cboEvents;
        private System.Windows.Forms.NumericUpDown nudTickets;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblselectEvent;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCalculate;
    }
}