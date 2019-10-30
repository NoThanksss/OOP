using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSalling2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTimeOffset data1 = new DateTimeOffset(2020, 5, 1, 8, 6, 32, new TimeSpan(1, 0, 0));
            DateTimeOffset data2 = new DateTimeOffset(2021, 5, 1, 8, 6, 32, new TimeSpan(1, 0, 0));
            DateTime data = new DateTime(2008, 5, 1, 8, 6, 32);
            DateTime data3 = new DateTime(2025, 5, 1, 8, 6, 32);
            Airports airports = new Airports("t1","t2");
            Time time = new Time(data1, data2);
            //Seat seat = new Seat();
            
            Seat[,] seatsArr;
            
            Airplane airplane = new Airplane("don'tKill", "yourself)");
            seatsArr = airplane.seats(airplane.amount);
           // int amount = airplane.amount;
          //  seatsArr = seat.seats(amount); 
          //seatsArr = new Seat().seats(amount);
            Flight race = new Flight(airplane, airports, time, 452625, seatsArr );

            Passenger pessanger = new Passenger(SexEnum.Woman, "Galya", ".jpg", data, 234562849265, data3);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    race.seatsArr[i, j].ReservSeat(pessanger);
                    MessageBox.Show("i:"+i+"j: "+j+"   AAAAAAAAAAAAAAAAAAAAAa" + race.seatsArr[i, j]);
                }
            }
        }
    }
}
