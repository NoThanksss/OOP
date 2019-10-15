using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSalling;

namespace TicketSalling
{
    public partial class FlightForm : Form

    {   // ClassEnum type = new ClassEnum();
        Random rnd = new Random();
        private int value = 0;
        DateTimeOffset there;
        DateTimeOffset back;
        static List<Flight> flights = new List<Flight>();
        private bool Exist(List<Flight> flights, Flight flight)
        {
            var ex = false;
            for (var i = 0; i < flights.Count; i++)
                if (flights[i].Equals(flight))
                {
                    ex = true;
                    break;
                }

            return ex;
        }

        public FlightForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fromArr = { "Borispol", "Zhulany", "Wall Street", "Battery Park", "Domodedovo", "Vnukovo" };
            string[] toArr = { "Borispol", "Zhulany", "Wall Street", "Battery Park", "Domodedovo", "Vnukovo" };
            From.Items.AddRange(fromArr);
            To.Items.AddRange(toArr);

            //ClassEnum[] classArr = {ClassEnum.Any,ClassEnum.Bussines,ClassEnum.Any};
            //{ "Any", "Business", "Economy" };
            string[] PassNum = { "1", "2", "3", "4" };
            Passengers.Items.AddRange(PassNum);
            Class.DataSource = Enum.GetValues(typeof(ClassEnum));
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                there = There.Value.Date;
                back = Back.Value.Date;
                
                int numb = Convert.ToInt16(Passengers.Text);

                Random rnd = new Random();
                //string[] fromArr = { "Borispol", "Zhulany", "Wall Street", "Battery Park", "Domodedovo", "Vnukovo" };
                //string[] toArr = { "Borispol", "Zhulany", "Wall Street", "Battery Park", "Domodedovo", "Vnukovo" };
                Time time = new Time(There.Value.Date, Back.Value.Date);
                Airports airports = new Airports(From.Text, To.Text);
                //MessageBox.Show(time.there + " " + time.back + "\n"
                //     + place.to + " " + place.from);
                ClassEnum type = (ClassEnum)Class.SelectedItem;
                //MessageBox.Show(type.ToString() + "32rdsc");
                Flight flight = new Flight(time, airports, type);
                
               
              
                if (Exist(flights, flight))
                { }
                else
                {
                    if (type.Equals(ClassEnum.Bussines))
                    {
                        flights.Add(new Flight(time, airports, type, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(1000, 2000)));
                        flights.Add(new Flight(time, airports, type, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(1000, 2000)));
                    }
                    else if (type.Equals(ClassEnum.Economy))
                    {
                        flights.Add(new Flight(time, airports,type, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(500, 1000)));
                        flights.Add(new Flight(time, airports,type, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(500, 1000)));
                    }
                    else if (type.Equals(ClassEnum.Any))
                    {
                        flights.Add(new Flight(time, airports, ClassEnum.Bussines, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(1000, 2000)));
                        flights.Add(new Flight(time, airports, ClassEnum.Bussines, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(1000, 2000)));
                        flights.Add(new Flight(time, airports, ClassEnum.Economy, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(500, 1000)));
                        flights.Add(new Flight(time, airports, ClassEnum.Economy, rnd.Next(50, 200), rnd.Next(50, 150), rnd.Next(Int32.MaxValue), rnd.Next(500, 1000)));
                        //MessageBox.Show(type.ToString());
                    }
                }
                //for (int i = 0; i < From.Items.Count; i++) {
                //    for (int k = 0; k < To.Items.Count; k++) {
                //        if (i != k) {
                //            flights.Add(new Flight(time, new Place(fromArr[i], toArr[k]), rnd.Next(Int32.MaxValue).ToString(), rnd.Next(500, 2000)));
                //        }
                //    }
                //}
                //for (int i = 0; i < From.Items.Count; i++)
                //{
                //    for (int k = 0; k < To.Items.Count; k++)
                //    {
                //        if (i != k)
                //        {
                //            flights.Add(new Flight(time, new Place(fromArr[i], toArr[k]), rnd.Next(Int32.MaxValue).ToString(), rnd.Next(500, 2000)));
                //        }
                //    }
                //}
                //MessageBox.Show(flights[4].place.to + flights[4].race + "   " + flights.Count + "daaaaaaaaaa " + numb );
                //for (int i = 0; i < flights.Count; i++)
                //{
                //    MessageBox.Show(flights[i].place.from + flights[i].place.to + " AAAAAAAAAAAAAAAAAAAAAA");
                //}

                RaceForm form2 = new RaceForm(flights, flight, numb);
                form2.Show();
                this.Hide();
            }
          
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }




        }

    }
}

