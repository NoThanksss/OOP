using System;

namespace TicketSalling2._0
{
   public class Path
    {
        private Airport DepartureAirport;
        public Airport departureAirport
        {
            get { return DepartureAirport; }
            private set
            {
                if (value.nameOfAirport.Length > 0)
                {
                    DepartureAirport = value;
                }
                else
                {
                    throw new InvalidOperationException("airports from set");
                }
            }
        }
        private Airport DestinationAirport;
        public Airport destinationAirport
        {
            get { return DestinationAirport; }
            private set
            {
                if (value.nameOfAirport.Length > 0 && value.nameOfAirport != departureAirport.nameOfAirport)
                {
                    DestinationAirport = value;
                }
                else
                {
                    throw new InvalidOperationException("airoports to set");
                }
            }
        }
        public Path(Airport departureAirport, Airport destinationAirport)
        {
            this.departureAirport = departureAirport;
            this.destinationAirport = destinationAirport;
        }
        public bool Equals(Path other)
        {
            if ((this.departureAirport.Equals(other.departureAirport)) && (this.destinationAirport.Equals(other.destinationAirport)))
            {
                return true;
            }

            return false;
        }

        public int CalculatingTimeOfFlight(int speed)
        {
            double result = Math.Sqrt(Math.Pow((destinationAirport.coordinateX - departureAirport.coordinateX), 2)
                                      + Math.Pow((destinationAirport.coordinateY - departureAirport.coordinateY), 2));
            return (int)(result*125 / speed);
        }

        public override string ToString()
        {
            return departureAirport + "-->" + destinationAirport;
        }
    }
}
