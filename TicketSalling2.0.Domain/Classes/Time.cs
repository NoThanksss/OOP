using System;
using System.Runtime.Serialization;

namespace TicketSalling2._0
{
    [DataContract]
   public class Time
    {
        Exception Ex = new Exception("choose correct Date");
        private DateTimeOffset DepartureTime;
        [DataMember]
        public DateTimeOffset departureTime
        {
            get { return DepartureTime; }
            private set
            {
                DepartureTime = value;
                if (value < DateTime.Today)
                {
                    throw Ex;
                }
            }
        }

        private DateTimeOffset DestinationTime;
        [DataMember]
        public DateTimeOffset destinationTime
        {
            get { return DestinationTime; }
            private set
            { 
                DestinationTime = value;
                if (value < DateTime.Today || value < departureTime)
                {
                    throw Ex;
                }
            }
        }
        public Time(DateTimeOffset departureTime, DateTimeOffset destinationTime)
        {
            this.departureTime = departureTime;
            this.destinationTime = destinationTime;
        }
        public bool Equals(Time other)
        {
            if (this.departureTime == other.departureTime && this.destinationTime == other.destinationTime)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return departureTime + "-->" + destinationTime;
        }
    }
}
