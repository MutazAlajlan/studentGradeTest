using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Test
{
    class Program
    {
        static bool IsNumeric(String str)
        {
            bool result = int.TryParse(str, out _);
            return result;
        }

        static int GetMark(String str)
        {
            int mark;
            int.TryParse(str, out mark);
            return mark;
        }

        static bool IsCharacters(String str)
        {
            bool result = Regex.IsMatch(str, @"^[a-zA-Z]+$");

            return result;
        }

        static bool MarkInRange (int mark)
        {
            
            if (mark <= 100 && mark >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsQuit(string str)
        {
            return str.Equals("QUIT", StringComparison.OrdinalIgnoreCase);
        }

        static void Main(string[] args)
        {
            /* takes names array.
               takes marks array.
               arrays are not fixed length.
            at the end of insertion, display all the names and marks.
            Print Fail if mark is LESS than 60.
            Print Passed if the mark is 60 or more.
             */
            
            //Console.WriteLine("Hello World!");

            bool contBool = true;
            Student students = new Student();

            Console.WriteLine("Hello and welcome to the grading system!");
            while (contBool)
            {
                
                Console.WriteLine("Please enter the student name or write QUIT to exit the program:");
                String name = Console.ReadLine();
                if (IsQuit(name))
                {
                    students.Print();
                }
                if (!IsNumeric(name))
                {
                    if (IsCharacters(name))
                    {
                        //add
                        students.AddName(name);
                        //Add marks
                        Console.WriteLine("Please enter the student mark:");
                        String stringMark = Console.ReadLine();
                        while (!IsNumeric(stringMark))
                        {
                            Console.WriteLine("Please enter only digits.");
                            stringMark = Console.ReadLine();
                        }
                        if(IsNumeric(stringMark))
                        {
                            int intMark = GetMark(stringMark);
                            if(MarkInRange(intMark))
                            {
                                //add
                                students.AddMark(intMark);
                                Console.WriteLine("The student {0}, with a mark of {1} has been added.", name, intMark);
                            }
                            else
                            {
                                Console.WriteLine("Must be from 0 to 100");
                            }

                        }
                        else
                        {
                            Console.WriteLine("There has been an error in entering the marks. It should be digits only.");
                        }

                        
                    }
                    else
                    {
                        Console.WriteLine("Please enter only characters in the name field.");
                    }
                }
                else
                {
                    Console.WriteLine("Please only use characters. No digits are allowed");
                }

            }

        }
    }
     class Student
    {
         List<string> studentsName = new List<string>();
         List<int> studentsMark = new List<int>();

         public void Print()
        {
            //foreach 
            //Console.WriteLine()
            int index = studentsMark.Count-1;
            for (int i = 0; i <= index; i++)
            {
                string msg = "==========================";
                msg += "Student: " + studentsName[i];
                msg += "  |  His mark is: " + studentsMark[i];
                msg += "||  ";
                if (studentsMark[i] >= 60)
                {
                    msg += "Passed";
                }
                else if (studentsMark[i] < 60)
                {
                    msg += "Fail";
                }
                Console.WriteLine(msg + "\n ==========================");
            }

        }
        //function to add to names list
         public void AddName(String str)
        {
             studentsName.Add(str);
        }
        public void AddMark(int mark)
        {
            studentsMark.Add(mark);
        }
        public string GetName(int index)
        {
            if(studentsName.Count >= index)
            {
                return studentsName[index];
            }
            else
            {
                return "There has been an error accessing the student name.";
            }
        }
        public int GetMark(int index)
        {
            if(studentsMark.Count >= index)
            {
                return studentsMark[index];
            }
            else
            {
                throw new ArgumentException("There has been an error in getting marks list.");
            }
        }
        public Student()
        {
            studentsName = new List<string>();
            studentsMark = new List<int>();
        }
    }
}
