using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        //Instance fields
        private string _className;
        private List<Students> _classList;
        private DateTime _semesterStart;


        //Constructor
        public ClassRoom()
        {
            _classList = new List<Students>();
        }

        //Properties
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public List<Students> ClassList
        {
            get { return _classList; }
            set { _classList = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

        public void Season()
        {
            int winter = 0;
            int spring = 0;
            int summer = 0;
            int fall = 0;

            foreach (var Students in _classList)
            {
                if (Students.Season() == "Winter")
                {
                    winter += 1;
                }
                if (Students.Season() == "Spring")
                {
                    spring += 1;
                }
                if (Students.Season() == "Summer")
                {
                    summer += 1;
                }
                if (Students.Season() == "Fall")
                {
                    fall += 1;
                }
            }

            Console.WriteLine($"Students born in winter: {winter}");
            Console.WriteLine($"Students born in spring: {spring}");
            Console.WriteLine($"Students born in summer: {summer}");
            Console.WriteLine($"Students born in fall: {fall}");
        }

        //Methode
        public override string ToString()
        {
            return $"{ClassName} {ClassList} {SemesterStart}";
        }
    }
}