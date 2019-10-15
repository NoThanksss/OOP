using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace TicketSalling
{ 
   public class Ticket
    {
        private Flight flight;
        
        private Passenger passenger;
        


        public Ticket(Flight flight, Passenger passenger)
        {
            this.flight = flight;
            this.passenger = passenger;
        }

        public override string ToString()
        {
            return flight.ToString() + "" + 
                   ""+ passenger.ToString();

        }
    }
}
