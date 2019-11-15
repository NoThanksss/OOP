using System;

namespace TicketSalling2._0
{
    public class Person
    {
        public Gender sex { get; protected set; }
        private string Name;
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
