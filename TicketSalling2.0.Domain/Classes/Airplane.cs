using System;

namespace TicketSalling2._0
{
   public class Airplane
    {
        private string TypeOfAirplane;
        private string CountryOfOrigin;
        private int NumberOfRows;
        private int NumberOfColumns;
        private int AmountOfSeats;
        private int CruisingSpeed;

        public int cruisingSpeed
        {
            get { return CruisingSpeed; }
            private set
            {
                if (value > 250 && value < 1285)
                {
                    CruisingSpeed = value;
                }
                else { throw new InvalidOperationException("cruising speed"); }
            }
        }

        public int numberOfRows
        {
            get { return NumberOfRows; }

            private set
            {
                if (value > 0)
                {
                    NumberOfRows = value;
                }
                else { throw new InvalidOperationException("number of rows"); }
            }
        }
        public int numberOfColumns
        {
            get { return NumberOfColumns; }

            private set
            {
                if (value > 0)
                {
                    NumberOfColumns = value;
                }
                else { throw new InvalidOperationException("number of columns"); }
            }
        }
        public int amountOfSeats
        {
            get { return AmountOfSeats; }

            private set
            {
                if (value > 0)
                {
                    AmountOfSeats = value;
                }
                else {throw new InvalidOperationException("amount of seats"); }
            }
        }

        public string typeOfAirplane
        {
            get { return TypeOfAirplane; }
           private set { if (value.Length > 0) TypeOfAirplane = value;
               else
               {
                   throw new InvalidOperationException("Type of Airplane");
               }
            }
        }
        public string countryOfOrigin
        {
            get { return CountryOfOrigin; }
           private set
            {
                if (value.Length > 0) CountryOfOrigin = value;
                else
                {
                    throw new InvalidOperationException("country of Airplane");
                }
            }
        }
        public Airplane(string typeOfAirplane, string countryOfOrigin, int cruisingSpeed)
        {
            this.countryOfOrigin = countryOfOrigin;
            this.typeOfAirplane = typeOfAirplane;
            this.cruisingSpeed = cruisingSpeed;
            numberOfRows = 6;
            numberOfColumns = 15;
            amountOfSeats = numberOfRows * numberOfColumns;
        }

        public override string ToString()
        {
            return "Type of airplane: " + typeOfAirplane;
        }
    }
}
