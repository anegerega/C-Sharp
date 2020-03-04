using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Student_Info
{
    class operations
    {
        // method to show list of operations to be performed
        public static void Show_Menu()
        {
            Console.WriteLine("                Operations");
            Console.WriteLine("===============================================");
            Console.WriteLine("1. Add a new student record");
            Console.WriteLine("2. Retrive a student record by ID");
            Console.Write("What would you like to do?: ");

            int userdecision = Convert.ToInt32(Console.ReadLine());
            switch (userdecision)
            {
                case 1:
                    Register_Student();
                    break;
                case 2:
                    DisplayStudentRecord();
                    break;
            }
        }

        // method to register a new student
       public static Students Register_Student() 
        {           
            Students newstudent = new Students();            
            Console.WriteLine("To Register a new student, fill in the details below.");

            var writer = new StreamWriter(@"C:\Users\Angela Egerega\Desktop\C-Sharp\Student_Info\bin\Debug\netcoreapp3.0\Student_Info.txt", true);

            Console.Write("Student\'s firstname: " + newstudent.Fname);
            newstudent.Fname = Console.ReadLine();

            Console.Write("Student\'s lastname: " + newstudent.Lname);
            newstudent.Lname = Console.ReadLine();          

            Console.Write("Student\'s ID number: " + newstudent.Id);
            newstudent.Id = Console.ReadLine();

            Console.Write("Student\'s Gender(F/M): " + newstudent.Gender);
            newstudent.Gender = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Course of Study: " + newstudent.Course);
            newstudent.Course = Console.ReadLine();

            Console.Write("Campus: " + newstudent.Campus);
            newstudent.Campus = Console.ReadLine();

            var StudentList = new List<Students>()
            {
                new Students {Fname = "", Lname = "", }
            };

            //Console.Write("Level: " + newstudent.Level);
            //newstudent.Level = Convert.ToInt32(Console.ReadLine());
            writer.WriteLine($"" +
                $"{newstudent.Fname}|" +
                $"{newstudent.Lname}|" +
                $"{newstudent.Id}|" +
                $"{newstudent.Gender}|" +
                $"{newstudent.Course}|" +
                $"{newstudent.Campus}");

            writer.Close();
            Console.WriteLine("Student has been registered successfuly");
            PerformAgain();
            return newstudent;            
        }

        //method to display a student's record
        public static void DisplayStudentRecord()
        {
            int counter = 0;
            var reader = new StreamReader(@"C:\Users\Angela Egerega\Desktop\C-Sharp\Student_Info\bin\Debug\netcoreapp3.0\Student_Info.txt");            
            Console.Write("Enter Student's ID: ");
            string searchid = Console.ReadLine();
           
            while (reader.Peek() > -1)
            {
                counter++;
                var Line = reader.ReadLine();

                if (searchid == Line.Split('|')[2])
                {
                 Console.WriteLine("First Name: {0}",Line.Split('|')[0]);;
                 Console.WriteLine("Last Name: {0}", Line.Split('|')[1]);
                 Console.WriteLine("Student ID: {0}", Line.Split('|')[2]);
                 Console.WriteLine("Gender: {0}", Line.Split('|')[3]);
                 Console.WriteLine("Course of Study: {0}", Line.Split('|')[4]);
                 Console.WriteLine("Campus: {0}", Line.Split('|')[5]);
                    break;
                }
                else
                {
                    counter++;   
                }              
            }
            PerformAgain();
        } 

        //method to allow user perform another operation
        public static void PerformAgain()
        {
            Console.Write("Do you want to perform another operation? Enter Yes or No: ");
            string performagain = Console.ReadLine().ToUpper();
            if (performagain == "YES")
            {
                Show_Menu();
            }
            else if (performagain == "NO")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                while ((performagain != "YES") || (performagain != "NO"))
                {
                    Console.WriteLine("Invalid Input! Please enter \"Yes\" or \"No\"");
                }
            }
        }
    }
}
