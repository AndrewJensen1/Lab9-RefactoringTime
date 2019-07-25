using System;
using System.Collections.Generic;

namespace Lab9_Refactoring_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>
            {
                "Bill", "Mike","Meagan","Dave", "Lisa"
            };
            List<string> hometowns = new List<string>
            {
                "Detroit", "White Lake", "Waterford", "Commerce", "Clarkston"
            };
            List<string> food = new List<string>
            {
                "Pizza", "Hotdogs", "Nachos", "Tacos", "Mac & Cheese"
            };
            List<string> color = new List<string>
            {
                "Blue", "Green", "Red", "Orange", "Brown"
            };

            Console.WriteLine("Welcome to the 2019 C# Class");
            
            DisplayPeople(students);
            Console.WriteLine("Would you like to learn about a student or add a student");
            Console.WriteLine("If you would like to learn about a student please enter y; Or n to add a student.");
            bool go = true;
            while (go)
            {

                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine("Please select a student by number to learn about them.");
                    int studentNumber = GetStudentNumber();
                    Console.WriteLine($"Great! You Selected {students[studentNumber]}");
                    Console.WriteLine("Would you like know  1: hometown 2: food 3: color 4: exit ");
                    int selection = UserInput();
                    if (selection == 1)
                    {
                        Console.WriteLine($"{hometowns[studentNumber]}");
                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine($"{food[studentNumber]}");
                    }
                    else if (selection == 3)
                    {
                        Console.WriteLine($"{color[studentNumber]}");
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input == "n")
                {
                    Console.WriteLine("Enter student's name.");
                    input = Console.ReadLine();
                    AddToList(students, input);

                    Console.WriteLine("Enter hometown");
                    input = Console.ReadLine();
                    AddToList(hometowns, input);

                    Console.WriteLine("Enter favorite food.");
                    input = Console.ReadLine();
                    AddToList(food, input);

                    Console.WriteLine("Enter favorite color");
                    input = Console.ReadLine();
                    AddToList(color, input);

                    DisplayPeople(students);
                    Continue();
                }
                else
                {
                    Console.WriteLine("Incorrect option please try again.");
                }
            }
        }
        public static int GetStudentNumber()
        {
            return (int.Parse(Console.ReadLine())-1);
        }
        public static int UserInput()
        {
            return (int.Parse(Console.ReadLine()));
        }
        public static void DisplayPeople(List<string> students)
        {
            int counter = 1;
            foreach (string student in students)
            {
                Console.WriteLine($"{counter}: {student}");
                counter++;
            }
        }
        public static void AddToList(List<string> list, string input)
        {
            list.Add(input);
        }
        public static bool Continue()
        {
            Console.WriteLine($"Press {'y'} to continue or any other key to exit. . .");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                return true;
            }
            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}