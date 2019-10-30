using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling2._0
{
    public class Seat
    {
        private SeatType Type;
        public SeatType type
        {
            get { return Type; }
            private set
            {
                if (value > 0) { Type = value; }
            }
        }
        private Passenger Passenger;
        public Passenger passenger
        {
            get; private set;
        }
        private Boolean AtWindow;
        public Guid SeatId { get; }
        public Boolean atWindow
        {
            get { return AtWindow; }
            private set { }
        }
        private PlainPart PartOfPlain;
        public PlainPart partOfPlain
        {
            get { return PartOfPlain; }
            private set
            {
                if (value > 0)
                {
                    PartOfPlain = value;
                }
            }
        }
        public Seat(SeatType type = 0, Passenger passenger = null, Boolean atWindow = false, PlainPart partOfPlain = 0)
        {
            this.type = type;
            this.passenger = passenger;
            this.atWindow = atWindow;
            this.partOfPlain = partOfPlain;
            SeatId = Guid.NewGuid();
        }
        public bool IsReserved(Seat seat)
        {
            if (seat.passenger == null)
            {
                return false;
            }
            else { return true; }
        }
        public Seat ReservSeat(Passenger passenger)
        {
            if (this.passenger == null)
            {
                this.passenger = passenger;
            }
            return this;
        }
        public Seat Remove()
        {
            if (this.passenger != null)
            {
                this.passenger = null;
            }
            return this;

        }
        public Seat[,] seats(int a)
        {
            int counter = 0;
            Seat[,] seats = new Seat[6, 15];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (counter % 3 == 0) { atWindow = true; }
                    if (counter < (a / 2)) { Type = SeatType.Economy; }
                    if (counter > (a / 2)) { Type = SeatType.Bussines; }
                    if (counter < (a / 3)) { PartOfPlain = PlainPart.InTheTail; }
                    if (counter > (a / 3) && counter < (2 * a / 3)) { PartOfPlain = PlainPart.AtTheExit; }
                    if (counter > (2 * a / 3) && counter < (a)) { PartOfPlain = PlainPart.InTheNose; }
                    seats[i, j] = new Seat(Type, null, atWindow, PartOfPlain);
                    counter++;
                }
            }
            return seats;
        }
        public override string ToString()
        {
            return Type + " " + SeatId + "passenger: " + passenger;
        }
    }
}
