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

        //Default Constructor
        public ClassRoom()
        {
        }

        ////Constructor
        //public ClassRoom(string className, List<Students> classList, DateTime semesterStart)
        //{
        //    _className = className;
        //    _classList = classList;
        //    _semesterStart = semesterStart;
        //}

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

        //Methode
        public override string ToString()
        {
            return $"{ClassName} {ClassList} {SemesterStart}";
        }
    }
}