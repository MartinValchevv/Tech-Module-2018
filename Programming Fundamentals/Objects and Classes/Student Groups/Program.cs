using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Groups
{
    class StudentGroups
    {

        class Student
        {
            public string StudentName { get; set; }

            public string Email { get; set; }

            public DateTime EnrollmentDate { get; set; }
        }

        class Town
        {
            public string City { get; set; }

            public List<Student> Students { get; set; }

            public int MaximumAvalableSeats { get; set; }
        }

        class Group
        {
            public Town Town { get; set; }

            public List<Student> Studnets { get; set; }
        }

        static void Main(string[] args)
        {
            List<Town> studentEnrollmentByTowns = AddStudents();

            List<Group> groups = new List<Group> { };


            int groupCounter = 0;
            int townCounter = 0;
            foreach (var item in studentEnrollmentByTowns.OrderBy(name => name.City))
            {
                Group currentGroup = new Group { };

                int studentsQuantity = item.Students.Count;
                int availableSpaces = item.MaximumAvalableSeats;
                int result = 0;
                if (studentsQuantity % availableSpaces == 0) result = studentsQuantity / availableSpaces;
                else result = (studentsQuantity / availableSpaces) + 1;
                var students = item.Students.OrderBy(date => date.EnrollmentDate).ThenBy(name => name.StudentName).ThenBy(email => email.Email).ToList();

                for (int i = 0; i < result; i++)
                {
                    currentGroup = new Group
                    {
                        Town = new Town
                        {
                            City = item.City,
                            MaximumAvalableSeats = item.MaximumAvalableSeats,
                            Students = new List<Student> { }
                        },
                    };
                    currentGroup.Studnets = new List<Student> { };

                    currentGroup.Studnets = students.Take(availableSpaces).ToList();
                    students = students.Skip(availableSpaces).ToList();

                    groups.Add(currentGroup);
                }
                groupCounter += result;
                townCounter++;
            }

            Console.WriteLine($"Created {groupCounter} groups in {townCounter} towns:");

            foreach (var item in groups)
            {
                Console.Write($"{item.Town.City} => ");

                var currentStudentSection = new List<string> { };

                foreach (var items in item.Studnets) currentStudentSection.Add(items.Email);

                Console.WriteLine(String.Join(", ", currentStudentSection));

            }
        }


        private static List<Town> AddStudents()
        {
            List<Town> StudentEnrollmentByTowns = new List<Town> { };
            Town currentTown = new Town { };
            int startingPosition = 0;

            for (int i = 0; ; i++)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    if (currentTown.Students.Count != 0)
                    {
                        currentTown.Students.OrderBy(date => date.EnrollmentDate).ThenBy(name => name.StudentName).ThenBy(email => email.Email);
                        StudentEnrollmentByTowns.Add(currentTown);
                    }
                    break;
                }

                if (inputData.Contains("=>"))
                {
                    if (i != startingPosition)
                    {
                        currentTown.Students.OrderBy(date => date.EnrollmentDate).ThenBy(name => name.StudentName).ThenBy(email => email.Email);
                        StudentEnrollmentByTowns.Add(currentTown);
                    }

                    string[] inputDataTownInformation = inputData.Split(new string[] { "=>" }, StringSplitOptions.None).ToArray();
                    currentTown = new Town
                    {
                        City = inputDataTownInformation[0].TrimEnd(),
                        MaximumAvalableSeats = int.Parse(inputDataTownInformation[1].Split(
                            new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()),
                        Students = new List<Student> { },
                    };
                    currentTown.Students = new List<Student> { };
                }
                else
                {
                    string[] inputDataAboutStudents = inputData.Split('|').ToArray();
                    string name = inputDataAboutStudents[0].TrimEnd();
                    name = name.TrimStart();
                    string email = inputDataAboutStudents[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                    string registrationDate = inputDataAboutStudents[2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();

                    Student currentStudent = new Student
                    {
                        StudentName = name,
                        Email = email,
                        EnrollmentDate = DateTime.ParseExact(registrationDate, "d-MMM-yyyy", CultureInfo.InvariantCulture),
                    };
                    if (currentTown.Students.Count == 0)
                    {
                        currentTown.Students = new List<Student> { };
                        currentTown.Students.Add(currentStudent);
                    }
                    else currentTown.Students.Add(currentStudent);
                }
            }
            return StudentEnrollmentByTowns;
        }
    }
}