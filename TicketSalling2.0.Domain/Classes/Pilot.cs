using System;

namespace TicketSalling2._0
{
    public class Pilot : Person
    {

        private int Hours;
        public int hours
        {
            get { return Hours; }
            private set
            {
                if (value > 0)
                {
                    Hours = value;
                }
            }
        }
        private int Rating;
        public int rating
        {
            get { return Rating; }
            private set
            {
                if (value > 0)
                {
                    Rating = value;
                }
            }

        }

        public Pilot(Gender sex, string name, string secondName, DateTime birthday, int hours, int rating) : base(sex, name,
            secondName, birthday)
        {
            this.hours = hours;
            this.rating = rating;
            id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return " Pilot: " + name + " " + secondName + "; Birthday: " + birthday + " y.o; Experience: " + hours + " hours; Rating: " + rating + "/10 ;";
        }
    }
}
