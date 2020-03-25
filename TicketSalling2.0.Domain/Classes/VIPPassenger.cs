using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TicketSalling2._0
{
    [DataContract]
    //[KnownType(typeof(Passenger))]
    public class VIPPassenger: Passenger
    {
 

        public VIPPassenger(Gender sex, string name, string secondName, DateTime birthday, long document, DateTime date) : base(sex, name, secondName, birthday, document, date)
        {
            //this.specialAbilities = specialAbilities;
        }
        public override string ToString()
        {
            return "Passenger: Sex: " + sex + "; Name: " + name + "; Surname: " + secondName + "; Birthday: " + birthday + "; Document: " + document + "; Date of Expire:  " + date ;
        }
    }
}
