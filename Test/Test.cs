using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Test
{
    class Program2
    {
        class Student
        {
            static int id = 1;
            string name;
            int mark;
            string result;

            bool IsCharacters(string name)
            {
                return Regex.IsMatch(name, @"^[a-zA-Z]+$");
            }
            bool ValidateName(string name)
            {
                return IsCharacters(name);
            }
            bool IsNumeric(int mark)
            {
                return double.TryParse(mark, out _);
            }
            /*
            SetName(string name)
            {
                if(ValidateName(name))
                {
                    return name;
                }
            }
            */
            bool MarkInRange(int mark)
            {
                if (mark >= 0 && mark <= 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            bool ValidateMark(int mark)
            {
                if (IsNumeric(mark))
                {
                    if (MarkInRange(mark))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            string MarkResult(int mark)
            {
                if (mark >= 60)
                {
                    return "Passed";
                }
                else if (mark < 60)
                {
                    return "Fail";
                }
            }
            string ToString(string name, int mark, string result)
            {
                return "Student: " + name + " Mark: " + mark + " | " + result;
            }

            public static Student Create(string name, string stringMark)
            {
                if (ValidateName(name))
                {
                    if (ValidateMark(stringMark))
                    {
                        string result = MarkResult(mark);
                        //return Student Student = new Student;
                        id++;
                    }
                    else
                    {
                        return "mark";
                    }
                }
                else
                {
                    return "name";
                }
            }
            private Student(int studentId, string studentName, int studentMark, string grade)
            {
                //what if it fail? will still increment

                //validate first before insertion:
                this.id = studentId;
                this.name = studentName;
                this.mark = studentMark;
                this.result = grade;
            }
        }
        class Students
        {
            List<Student> studentsList;

            public AddStudent(Student studentObject)
            {
                this.Add(studentObject);
            }
            public print()
            {
                Console.WriteLine("The result of each student is: ");
                foreach (int index in studentsList)
                {
                    msg = studentsList[index].ToString();
                    Console.WriteLine("==========================\n" + msg);
                }
            }
            public bool IsEmpty()
            {
                if (this.studentsList.Any())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public Students()
            {
                studentsList = new List<Student>();
            }
        }
        public int ConvertToInt(string mark)
        {
            int intMark;
            if (int.TryParse(mark, out intMark))
            {
                return intMark;
            }
            else
            {
                return -1;
            }
        }
        public bool IsQuit(string input)
        {
            if (input.Equals("QUIT", StringComparison.OrdinalIgnoreCase))
            {
                /*
                bool ListNotEmpty = studentsList.Any();
                if (studentsList.IsEmpty())
                {
                    Environment.Exit(0);
                }
                else if (!studentsList.IsEmpty())
                {
                    studentsList.Print();
                    Environment.Exit(0);
                }
                */
                return true;
            }
            else
            {
                return false;
            }
        }
        public Quit(Students students)
        {
            bool ListNotEmpty = students.Any();
            if (students.IsEmpty())
            {
                Environment.Exit(0);
            }
            else if (!students.IsEmpty())
            {
                students.Print();
                Environment.Exit(0);
            }
        }
        public static void Main(String[] args)
        {
            Console.Write(
@"   _____               _ _                _____           _                 
  / ____|             | (_)              / ____|         | |                
 | |  __ _ __ __ _  __| |_ _ __   __ _  | (___  _   _ ___| |_ ___ _ __ ___  
 | | |_ | '__/ _` |/ _` | | '_ \ / _` |  \___ \| | | / __| __/ _ \ '_ ` _ \ 
 | |__| | | | (_| | (_| | | | | | (_| |  ____) | |_| \__ \ ||  __/ | | | | |
  \_____|_|  \__,_|\__,_|_|_| |_|\__, | |_____/ \__, |___/\__\___|_| |_| |_|
                                  __/ |          __/ |                      
                                 |___/          |___/                       
");
            Console.WriteLine("Please enter the student name or write QUIT to exit the program");
            string userName = Console.ReadLine();
            Students studentsList = new Students();
            if (isQuit)
            {
                quit(studentsList);
            }
            else
            {
                string stringMark = Console.ReadLine();
                userMark = ConvertToInt(stringMark);
            }
            string stringMark = Console.ReadLine();
            userMark = ConvertToInt(stringMark);

        }
    }
}