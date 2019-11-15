using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSalling2._0
{
    public partial class PassengerForm : Form
    {
        private Flight ChoosenFlight;
        private SeatType type;
        Random rnd = new Random();
        private Pilot pilot;
        public PassengerForm(Flight flight, SeatType type)
        {
            rnd = new Random();
            DateTime pilotB = new DateTime(1971, 03, 21);
            pilot = new Pilot(Gender.Male, "Vitaliy", "Ivanovich", pilotB, rnd.Next(5000, 14000), rnd.Next(6, 10));
            ChoosenFlight = flight;
            this.type = type;
            InitializeComponent();
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {
            FlightInf.Text = ChoosenFlight  + " Pilot: " + pilot;
            //string[] SexArr =
            //{
            //    "Abimegender", "Aethergender", "Archaigender", "Astergender", "Astralgender", "Biogender", "Blizzgender", "Boggender", "Caelgender", "Carmigender", "Circgender", "Colorgender", "Contigender", "Crystagender", "Daimogender", "Delphigender", "Dryagender",
            //    "Earthgender", "Ekragender", "Digitalgender", "Frostgender", "Leukogender", "Orbgender", "Pictogender", "Absorgender", "Cadensgender", "Anongender"
            //};
            SexBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Gender sex = (Gender)SexBox.SelectedItem;
                string Name = NameBox.Text;
                string LastN = SecBox.Text;
                DateTime passengerBirthDay = BirthTime.Value.Date;
                long document = Int64.Parse(Document.Text);
                DateTime date = Date.Value.Date;
                Passenger passanger = new Passenger(sex, Name, LastN, passengerBirthDay, document, date);
                Seat choosenSeat = ChoosenFlight.Reserv(passanger, type);
                Ticket ticket = new Ticket(ChoosenFlight, choosenSeat);
                TicketForm form4 = new TicketForm(ticket);
                Hide();
                form4.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numb = e.KeyChar;
            if (char.IsDigit(numb))
            {
                e.Handled = true;
            }
        }

        private void SecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numb = e.KeyChar;
            if (char.IsDigit(numb))
            {
                e.Handled = true;
            }
        }

        private void Document_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numb = e.KeyChar;
            if (!char.IsDigit(numb))
            {
                e.Handled = true;
            }
        }
    }
}

