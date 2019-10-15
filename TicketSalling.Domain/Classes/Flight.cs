using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalling;

namespace TicketSalling
{
    public class Flight : IEquatable<Flight>
    { 
        //public Airplane airplane;
        public int race;
        public int cost;
        private int PassengersN;
        public Time time;
        public Airports airport;
        private int AmountE;
        private int AmountB;
        public ClassEnum type { get; set; }
        public Guid Id { get; private set; }

        public int amountE
        {
            get { return AmountE; }

            private set { AmountE = value; }
        }
        public int amountB
        {
            get { return AmountB; }

            private set { AmountB = value; }
        }
     

        public int passengersN
        {
            get { return PassengersN; }
            private set
            {
                if (value > 0)
                {
                    PassengersN = value;
                }
            }
        }
    

        public Flight(Time time, Airports airport, ClassEnum type = 0, int amountE = 0, int amountB = 0, int race = 0, int cost= 0)
        {
            //this.airplane = airplane;
            this.airport = airport;
            this.time = time;
            this.amountE = amountE;
            this.amountB = amountB;
            this.race = race;
            this.cost = cost;
            this.type = type;
            Id = Guid.NewGuid();
        }
        public int ReduceE(int passengersN)
        {
            amountE -= passengersN;
            return amountE;
        }
        public int ReduceB(int passengersN)
        {
            amountB -= passengersN;
            return amountB;
        }
        //public int Reduce()
        //{
        //    this.airplane.amount = amount - passengersN;
        //    return this.amount;
        //}
        public int PassN(int numb)
        {
            passengersN = numb;
            return numb;
        }
        
        public override string ToString()
        {
            return airport.from + " --> " + airport.to + ";     there: " + time.there + ";    back: " + time.back + ";   Class: " + type.ToString() + ";    economy places: " + amountE+ ";     business places: "+ amountB + ";    Race: " + race + ";     cost: " + cost + "$" ;
        }

        public bool Equals(Flight other)
        {
            if (airport.Equals(other.airport) && time.Equals(other.time) && type.Equals(other.type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

