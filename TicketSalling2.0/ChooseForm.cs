using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSalling2._0
{
    public partial class ChooseForm : Form
    {
        private Flight flight;
        private List<Flight> flights;
        private SeatType type;
        private List<Flight> flightT = new List<Flight>();
        public ChooseForm(List<Flight> flights, Flight flight, SeatType type)
        {
            this.flights = flights;
            this.flight = flight;
            this.type = type;
            InitializeComponent();
        }
        private void ChooseForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < flights.Count; i++)
            {
          
                    if (flight.Equals(flights[i], type))
                    {
                        flightT.Add(flights[i]);
                    }
            }
            for (int i = 0; i < flightT.Count; i++)
            {
                TrueF.Items.Add(flightT[i].ToString() +" free seats: "+ flightT[i].FreeSeats(type));
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Flight choosenFlight = flightT[TrueF.SelectedIndex];
                PassengerForm form3 = new PassengerForm(choosenFlight, type);
                form3.Show();
                Hide();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

