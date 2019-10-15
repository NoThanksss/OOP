using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TicketSalling;

namespace TicketSalling
{
    public partial class RaceForm : Form
    {
        private Flight flight2;
        private List<Flight> flights2;
        private int numb2;
        private int index;
        private List<Flight> flightT = new List<Flight>();
        public RaceForm(List<Flight> flights, Flight flight, int numb)
        {
            numb2 = numb;
            flight2 = flight;
            flights2 = flights;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < flights2.Count; i++)
            {
                if (flight2.type.Equals(ClassEnum.Any))
                {
                    flightT.Add(flights2[i]);
                   // MessageBox.Show("id " + flights2[i].Id);
                }
                else
                {
                    if (flight2.Equals(flights2[i]))
                    {
                        flightT.Add(flights2[i]);
                    }
                    else
                    {
                        continue;
                    } 
                }
            }

            //if (flight2.type.Equals(ClassEnum.Bussines))
            //{
            //}

            for (int i = 0; i < flightT.Count; i++)
            {
                TrueF.Items.Add(flightT[i].ToString());
            }
            //MessageBox.Show("da" + flightT.Count);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Flight flight3 = flightT[index];
            //flight3 = (Flight)flight3;
            //MessageBox.Show(flight3.ToString());
            PassengerForm form3 = new PassengerForm(flight3, numb2);
            form3.Show();
            Hide();
        }

        private void TrueF_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = TrueF.SelectedIndex;

        }
    }
}
