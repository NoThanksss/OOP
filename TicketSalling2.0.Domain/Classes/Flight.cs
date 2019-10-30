using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling2._0
{
    public class Flight
    {
        private Airplane Airplane;
        public Airplane airplane
        {
            get
            {
                return Airplane;
            }
            private set {
                
                    Airplane = value;
                }
            }
        
        private Airports Airports;
        public Airports airports
        {
            get
            { 
                return Airports;
            }
            private set
            {

                Airports = value;
            }
        }
        private Time TimeOfFlight;
        public Time timeOfFlight { get; private set; }

        private int RaceNumber;
        private Seat[,] SeatsArr;
        public Guid RaceId { get; private set; }
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

        
        public Flight(Airplane airplane, Airports airports, Time timeOfFlight, int raceNumber, Seat[,] seatsArr) {
            this.airplane = airplane;
            this.airports = airports;
            this.timeOfFlight = timeOfFlight;
            this.raceNumber = raceNumber;
            this.seatsArr = seatsArr;
            RaceId = Guid.NewGuid();
        }
    }
}
