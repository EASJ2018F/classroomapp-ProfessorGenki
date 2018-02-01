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
            ClassRoom ClassRoom = new ClassRoom();

            Students s1 = new Students("Ahmed Metin Donmez", 8, 29);
            Students s2 = new Students("Hassan Raza Hussain", 4, 20);
            Students s3 = new Students("Chad Thundercock", 9, 11);

            ClassRoom.SemesterStart = DateTime.Parse ("2017, 8, 28");
            ClassRoom.ClassName = "3A";

            List<Students> StudentsList = new List<Students>
            {
                s1,
                s2,
                s3
            };

            Console.WriteLine(ClassRoom.ClassName);
            Console.WriteLine(ClassRoom.SemesterStart);

            foreach (var students in StudentsList)
            {
                Console.WriteLine(students);
            }

            Console.ReadKey();
        }
    }
}