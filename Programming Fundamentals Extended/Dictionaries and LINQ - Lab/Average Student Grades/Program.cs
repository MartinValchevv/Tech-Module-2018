using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Double>> students = new Dictionary<string, List<Double>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();


                if (!(students.Keys.Contains(input[0])))
                {
                    students[input[0]] = new List<Double>() { Double.Parse(input[1]) };
                }
                else
                {
                    students[input[0]].Add(Double.Parse(input[1]));
                }
            }


            foreach (var student in students)
            {
                int counter = 0;
                double avarge = 0;
                Console.Write("{0} -> ", student.Key);
                foreach (var estimates in student.Value)
                {

                    avarge = avarge + estimates;
                    counter++;
                    Console.Write("{0:f2} ", estimates);

                }
                double result = avarge / counter;
                Console.WriteLine("(avg: {0:f2})", result);
                counter = 0;
                avarge = 0;
            }

        }
    }
}
