using System;

namespace TicketSalling2._0
{
   public class Airport
    {
        private string NameOfAirport;

        public string nameOfAirport
        {
            get { return NameOfAirport; }
            private set
            {
                if (value.Length > 0)
                {
                    NameOfAirport = value;
                }
                else
                {
                    throw new InvalidOperationException("airports from set");
                }
            }
        }
        public double coordinateX { get; private set;}
        public double coordinateY { get; private set;}

        public Airport(string nameOfAirport, double coordinateX, double coordinateY)
        {
            this.nameOfAirport = nameOfAirport;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
        public bool Equals(Airport other)
        {
            if (nameOfAirport == (other.nameOfAirport))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return nameOfAirport;
        }
    }
}
