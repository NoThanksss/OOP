using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSalling2._0
{
    public partial class TicketForm : Form
    {
        private Ticket passengerTicket;
        public TicketForm(Ticket ticket)
        {
            this.passengerTicket = ticket;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            FlightForm form1 = new FlightForm();
            form1.Show();
            Hide();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            ticket.Text = passengerTicket.ToString();
        }
    }
}
