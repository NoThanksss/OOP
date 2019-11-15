namespace TicketSalling2._0
{
    public class Ticket
    {
        private readonly Flight Flight;
        private readonly Seat Seat;
        public Ticket(Flight flight,Seat seat)
        {
            Flight = flight;
            Seat = seat;
        }
        public override string ToString()
        {
            return Flight.pathOfFlight + "; " + Flight.timeOfFlight + "; " + "Seat: " + Seat.type + Seat.passenger;
        }
    }
}
