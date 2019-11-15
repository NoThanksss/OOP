using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSalling2._0
{
    public partial class FlightForm : Form
    {
        DateTimeOffset departureTime;
        DateTimeOffset destinationTime;
        static List<Flight> flights = new List<Flight>();
        public FlightForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Airport[] fromArr = { new Airport("Borispol", 50.0, 30.0), new Airport("Wall Street", 40, -74 ), new Airport("Domodedovo", 55,37), new Airport("Orly",48, 2), new Airport("Berlin - Tegel", 52,13)  };
            Airport[] toArr = { new Airport("Borispol", 50.0, 30.0), new Airport("Wall Street", 40, -74), new Airport("Domodedovo", 55, 37), new Airport("Orly", 48, 2), new Airport("Berlin - Tegel", 52, 13) };
            From.Items.AddRange(fromArr);
            To.Items.AddRange(toArr);
            Class.DataSource = Enum.GetValues(typeof(SeatType));

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Path path = new Path((Airport)From.SelectedItem, (Airport)To.SelectedItem);
                Airplane airplane = new Airplane("Boeing 737", "USA", 900);
                departureTime = There.Value.Date.AddHours(12.0);
                destinationTime = departureTime.AddHours(path.CalculatingTimeOfFlight(airplane.cruisingSpeed));
                //MessageBox.Show("time: " + departureTime + " " + destinationTime+"method: "+ path.CalculatingTimeOfFlight(airplane.cruisingSpeed));
                Random rnd = new Random();
                Time time = new Time(departureTime,destinationTime);
                SeatType type = (SeatType)Class.SelectedItem;
                Flight flight = new Flight(airplane, path, time,rnd.Next(Int32.MaxValue),  Flight.SeatsMaking(airplane.amountOfSeats));
                if (Flight.Exist(flights, flight, type))
                {
                    for (int i = 0; i < flights.Count; i++)
                    {
                        if (flights[i].Equals(flight, type))
                        {
                            flights[i].CalculateCost(type, path.CalculatingTimeOfFlight(airplane.cruisingSpeed));
                        }
                    }
                }
                else
                {
                    flights.Add(new Flight(airplane, path, time, rnd.Next(Int32.MaxValue), Flight.SeatsMaking(airplane.amountOfSeats), flight.CalculateCost(type, path.CalculatingTimeOfFlight(airplane.cruisingSpeed))));
                    flights.Add(new Flight(airplane, path, time, rnd.Next(Int32.MaxValue), Flight.SeatsMaking(airplane.amountOfSeats), flight.CalculateCost(type, path.CalculatingTimeOfFlight(airplane.cruisingSpeed))));
                }
         
                ChooseForm form2 = new ChooseForm(flights, flight, type);
                form2.Show();
                Hide();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    
    }
}
