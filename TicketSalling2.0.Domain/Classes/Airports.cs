using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling2._0
{
   public class Airports
    {
        private string From;
        public string from
        {
            get { return From; }
            private set
            {
                if (value.Length > 0)
                {
                    From = value;
                }
                else
                {
                    throw new InvalidOperationException("airports from set");
                }
            }
        }
        private string To;
        public string to
        {
            get { return To; }
            private set
            {
                if (value.Length > 0)
                {
                    To = value;
                }
                else
                {
                    throw new InvalidOperationException("airoports to set");
                }
            }
        }
        public Airports(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

    }
}
