using System;
using System.Collections.Generic;

namespace TicketSalling2._0
{
    public class Flight
    {
        private Airplane Airplane;
        public Airplane airplane
        {
            get => Airplane;
            private set => Airplane = value;
        }
        
        private Path PathOfFlight;
        public Path pathOfFlight
        {
            get => PathOfFlight;
            private set => PathOfFlight = value;
        }
/*
        private Time TimeOfFlight;
*/
        public Time timeOfFlight { get; private set; }

        private int CostOfFlight;

        public int costOfFlight
        {
            get { return CostOfFlight; }
            private set
            {
                if (value >= 0)
                {
                    CostOfFlight = value;
                }
                else { throw new InvalidOperationException("cost of flight"); }
            }
        }
        private int RaceNumber;
/*
        private Seat[,] SeatsArr;
*/
        public Guid raceId { get; private set; }
        public Seat[,] seatsArr { get; private set; }
        public int raceNumber {
            get { return RaceNumber; }
            private set {
                if (value > 0) {
                    RaceNumber = value;
                }
                else
                {
                    throw new InvalidOperationException("race number set exp");
                }
            }
                }
        public Flight(Airplane airplane, Path pathOfFlight, Time timeOfFlight, int raceNumber, Seat[,] seatsArr, int costOfFlight = 0) {
            this.airplane = airplane;
            this.pathOfFlight = pathOfFlight;
            this.timeOfFlight = timeOfFlight;
            this.raceNumber = raceNumber;
            this.seatsArr = seatsArr;
            this.costOfFlight = costOfFlight;
            raceId = Guid.NewGuid();
        }
        public static Seat[,] SeatsMaking(int a)
        {
            int counter = 0;
            Seat[,] seats = new Seat[6, 15];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    bool atWindow = false;
                    SeatType type = SeatType.Bussines;
                    if (counter % 3 == 0) { atWindow = true; }
                    if (counter < (a / 2)) { type = SeatType.Economy; }
                    if (counter > (a / 2)) { type = SeatType.Bussines; }
                    seats[i, j] = new Seat(atWindow, type, null);
                    counter++;
                }
            }
            return seats;
        }
        public Seat Reserv(Passenger passenger, SeatType type)
        {
            for (int i = 0; i < airplane.numberOfRows; i++)
            {
                for (int j = 0; j < airplane.numberOfColumns; j++)
                {
                    if (seatsArr[i, j].ReservSeat(passenger, type))
                    {
                        return seatsArr[i, j];
                    }
                }
            }
            return null;
        }
        public int FreeSeats(SeatType seatType)
        {
            int counter = 0;
            
            for (int i = 0; i < airplane.numberOfRows; i++)
            {
                for (int j = 0; j < airplane.numberOfColumns; j++)
                {
                    if (seatType.Equals(SeatType.Bussines))
                    {
                        if (seatsArr[i, j].type.Equals(SeatType.Bussines) && !seatsArr[i, j].IsReserved(seatType)) { counter++; }
                    }
                    else
                    {
                        if (seatsArr[i, j].type.Equals(SeatType.Economy) && !seatsArr[i, j].IsReserved(seatType)) { counter++; }
                    }
                }
            }
            return counter;
        }
        public int CalculateCost(SeatType type, int durationOfFlight) {
            double costOfflight;
            Random rnd = new Random();
            DateTimeOffset currentDate = DateTimeOffset.Now;
            if (type.Equals(SeatType.Economy)) { costOfflight = rnd.Next(40, 50); }
            else { costOfflight = rnd.Next(70, 80); }
            if ((timeOfFlight.departureTime - currentDate).TotalDays > 14 && (timeOfFlight.departureTime - currentDate).TotalDays <= 21)
            {
                costOfflight *= 1.2;
            }
            if ((timeOfFlight.departureTime - currentDate).TotalDays > 7 && (timeOfFlight.departureTime - currentDate).TotalDays <= 14)
            {
                costOfflight *= 1.4;
            }
            if ((timeOfFlight.departureTime - currentDate).TotalDays > 3 && (timeOfFlight.departureTime - currentDate).TotalDays <= 7)
            {
                costOfflight *= 1.5;
            }
            if ((timeOfFlight.departureTime - currentDate).TotalDays > 1 && (timeOfFlight.departureTime - currentDate).TotalDays <= 3)
            {
                costOfflight *= 1.7;
            }
            if ((timeOfFlight.departureTime - currentDate).TotalDays >= 0 && (timeOfFlight.departureTime - currentDate).TotalDays <= 1)
            {
                costOfflight *= 0.8;
            }
            return (int)costOfflight * durationOfFlight;
        }
        public bool Equals(Flight other, SeatType type)
        {
            if (pathOfFlight.Equals(other.pathOfFlight) && timeOfFlight.Equals(other.timeOfFlight) && other.FreeSeats(type)>0)
            {
                return true;
            }
            return false;
        }
        public static bool Exist(List<Flight> flights, Flight flight, SeatType type)
        {
            var ex = false;
            for (var i = 0; i < flights.Count; i++)
                if (flights[i].Equals(flight, type))
                {
                    ex = true;
                    break;
                }
            return ex;
        }
        public override string ToString()
        {
            return airplane +"; " + pathOfFlight +"; " + timeOfFlight + "; Race: " + raceNumber + "; cost: " + costOfFlight + "$ ;";
        }
    }
}
