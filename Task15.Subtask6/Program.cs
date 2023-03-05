using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15.Subtask6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = from classroom in classes from s in classroom.Students select s;
            return result.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
