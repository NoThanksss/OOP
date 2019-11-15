﻿using System;

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
/*
        private Passenger Passenger;
*/
        public Passenger passenger
        {
            get; private set;
        }
       // private Boolean AtWindow;
        private Guid seatId { get; }
        public bool atWindow
        {
            get; private set;
        }
        public Seat(bool atWindow,SeatType type, Passenger passenger)
        {
            this.type = type;
            this.passenger = passenger;
            this.atWindow = atWindow;
            //this.partOfPlain = partOfPlain;
            seatId = Guid.NewGuid();
        }
        public bool IsReserved(SeatType typeOfSeat)
        {
            if ((passenger == null) && (this.type.Equals(typeOfSeat)))
            {
                return false;
            }
            else { return true; }
        }
        public bool ReservSeat(Passenger passenger, SeatType typeOfSeat)
        {
            if ((this.passenger == null) && (this.type.Equals(typeOfSeat)))
            {
                this.passenger = passenger;
                return true;
            }
            return false;
        }
        public Seat Remove()
        {
            if (passenger != null)
            {
                passenger = null;
            }
            return this;

        }
        public bool Equals(Seat other)
        {
            if (seatId == other.seatId) 
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return Type + " " + seatId + "; passenger: " + passenger + "; atWindow: " + atWindow;
        }
    }
}
