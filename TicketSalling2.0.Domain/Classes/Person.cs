using System;
using System.Runtime.Serialization;

namespace TicketSalling2._0
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public Gender sex { get; protected set; }
        private string Name;
        [DataMember]
        public string name
        {
            get { return Name; }
            protected set
            {
                if (value.Length > 0)
                {
                    Name = value;
                }
            }
        }
        private string SecondName;
        [DataMember]
        public string secondName
        {
            get { return SecondName; }
            protected set
            {
                if (value.Length > 0)
                {
                    SecondName = value;
                }
            }
        }
        private DateTime Birthday;
        [DataMember]
        public DateTime birthday
        {
            get { return Birthday; }
            protected set
            {
                if (value.Year > 1900)
                {
                    Birthday = value;
                    if (value > DateTime.Today)
                    {
                        throw new Exception("impossible");
                    }
                }
            }
        }
        [DataMember]
        public Guid id { get; protected set; }
        public Person(Gender sex, string name, string secondName, DateTime birthday)
        {
            this.sex = sex;
            this.name = name;
            this.secondName = secondName;
            this.birthday = birthday;
            id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return "Sex: " + sex + "; Name: " + name + "; Surname: " + secondName + "; Birthday: " + birthday;
        }
    }
}
