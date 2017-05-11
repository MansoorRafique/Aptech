using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static List<Student> Std = new List<Student>
        {
            new Student{Name="Shuja",Id=1,Scores=new List<int>{10,20,30,40,50}},
            new Student{Name="ALi",Id=2,Scores=new List<int>{100,200,300,400,500}},
            new Student{Name="Kazim",Id=3,Scores=new List<int>{1,2,3,4,5}},
            new Student{Name="Haider",Id=4,Scores=new List<int>{11,22,33,44,55}}
        };
        static void Main(string[] args)
        {
            IEnumerable<Student> StudentQuery =
                from Student in Std
                where Student.Scores[0] > 90
                select Student;
            foreach (Student Student in StudentQuery)
            {
                Console.WriteLine("{0},{1}", Student.Name,Student.Id,Student.Scores);
            }
            Console.ReadKey();
        }
    }
}
