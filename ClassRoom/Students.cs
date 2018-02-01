using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Students
    {
        //Instance fields
        string _name;
        int _monthOfBirth;
        int _dayOfBirth;

        //Constructor
        public Students(string name, int monthOfBirth, int dayOfBirth)
        {
            _name = name;
            _monthOfBirth = monthOfBirth;
            _dayOfBirth = dayOfBirth;
        }

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MonthOfBirth
        {
            get { return _monthOfBirth; }
            set { _monthOfBirth = value; }
        }

        public int DayOfBirth
        {
            get { return _dayOfBirth; }
            set { _dayOfBirth = value; }
        }

        //Methode
        public override string ToString()
        {
            return $"{Name} {MonthOfBirth} {DayOfBirth}";
        }
    }
}