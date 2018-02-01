using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom CRoom = new ClassRoom();

            Students s1 = new Students("Ahmed Metin Donmez", 8, 29);
            Students s2 = new Students("Hassan Raza Hussain", 4, 20);
            Students s3 = new Students("Chad Thundercock", 9, 11);

            CRoom.SemesterStart = DateTime.Parse ("2017, 8, 28");
            CRoom.ClassName = "3A";

            CRoom.ClassList.Add(s1);
            CRoom.ClassList.Add(s2);
            CRoom.ClassList.Add(s3);

            Console.WriteLine("Name of the class");
            Console.WriteLine(CRoom.ClassName);
            Console.WriteLine("");
            Console.WriteLine("The semester starts at");
            Console.WriteLine(CRoom.SemesterStart);
            Console.WriteLine("");
            Console.WriteLine("The participating students are");

            foreach (var students in CRoom.ClassList)
            {
                Console.WriteLine(students);
            }

            Console.WriteLine("");
            Console.WriteLine("Number of birthdays for each season");

            CRoom.Season();

            Console.ReadKey();
        }
    }
}