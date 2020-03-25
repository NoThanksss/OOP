using System;

namespace TicketSalling2._0
{
    public class Ticket
    {
        private readonly Flight Flight;
        public Seat Seat;
        public Guid id { get; protected set; }
        public Ticket(Flight flight,Seat seat)
        {
            Flight = flight;
            Seat = seat;
            id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return Flight.pathOfFlight + "; " + Flight.timeOfFlight + "; " + "Seat: " + Seat.type +" at window: " +Seat.atWindow +" Passenger: " +  Seat.passenger +" TicketId: " + id;
        }
        public bool EqualsG(Guid id)
        {
            if (this.id.Equals(id))
            {
                return true;
            }
            return false;
        }
    }
}
