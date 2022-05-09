using System;
using POP_Assigment.Entities;

namespace POP_Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Student studentnew = default;
            while (loop)
            {
                DisplayMenu();
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                       studentnew = AddStudent();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(studentnew);
                        Console.WriteLine("\n\nPress enter to continue.");
                        Console.ReadLine();
                        break;
                    case "0":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Input is not correct, try again");
                        Console.WriteLine("\n\nPress enter to continue.");
                        Console.ReadLine();
                        break;
                }
            }

        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Information about the student");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please enter your choice (1-2)");

        }
        private static Student AddStudent()
        {
            bool ValidMark = true;
            Console.WriteLine("Enter the first name of the student");
            string StName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the student");
            string StSurName = Console.ReadLine();

            Console.WriteLine("Enter the age of the student");
            int Age = 0;
            Age = validateInput(Age, "The input is not intenger. Please, try again");

            Console.WriteLine("Enter the student number");
            string number = Console.ReadLine();

            Console.WriteLine("Enter the contry of the student");
            string Contry = Console.ReadLine();

            Console.WriteLine("Enter the city of the student");
            string City = Console.ReadLine();

            Console.WriteLine("Enter the street of the student");
            string Street = Console.ReadLine();

            Console.WriteLine("Enter the adress of the student(number of house, number of flat if needed)");
            string Adress = Console.ReadLine();

            Console.WriteLine("Enter all marks of the student(using the space as separator)");
            string Marks = Console.ReadLine();
            char[] separators = new char[] { ',', ' ', };
            string[] MarksStr = Marks.Split(separators);
            int[] MarksInt = new int[MarksStr.Length];
            for(int i = 0; i < MarksStr.Length; ++i)
            {
                int mark = 0;
                try
                {
                    mark = int.Parse(MarksStr[i]);
                }

                catch { Console.WriteLine("Some marks is not intenger. Please try again from the beggining");
                    ValidMark = false;
                    Console.WriteLine("\n\nPress enter to continue.");
                    Console.ReadLine();
                    break;
                }
                MarksInt[i] = mark;
            }
            if (ValidMark)
            {
                Adress adress = new Adress() { Country = Contry, City = City, Street = Street, Address = Adress };
                Student student = new Student() { FirstName = StName, LastName = StSurName, StudentNumber = number, Adress = adress, Age = Age, Scores = MarksInt };
                return student;
            }
            else
            {
                return default;
            }
            
        }
        private static int validateInput(int input, string message)
        {
            bool inputValid = false;
            while (inputValid == false)
            {

                try
                {
                    input = int.Parse(Console.ReadLine());
                    inputValid = true;
                }
                catch
                {
                    Console.WriteLine(message);
                }

            }
            return input;
        }


    }
}



