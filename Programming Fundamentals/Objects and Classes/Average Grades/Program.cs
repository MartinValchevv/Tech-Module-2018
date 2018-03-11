using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> ourCllass = new List<Student>();
            
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                Student student = new Student();
                student.Name = input[0];
                input.RemoveAt(0);
                student.Grade = input.Select(double.Parse).ToList();
                ourCllass.Add(student);
            }

            foreach (var person in ourCllass.Where(x =>x.AvarageGreade >= 5).OrderBy(x => x.Name).ThenByDescending(x=>x.AvarageGreade))
            {
                Console.WriteLine($"{person.Name} -> {person.AvarageGreade:F2}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double AvarageGreade { get { return Grade.Average(); } }
    }
}
