using System;
// Kelub Thorn
// IT112 
// NOTES: This was incredibly hard for me,
// this was due to me not being able to focus during the last couple of weeks because I priortized my C++ videogame project.
//I got the help of 2-3 classmates to pull through (we didn't break any rules,
//no code was viewed by people who weren't completed with their assignment already)
// BEHAVIORS NOT IMPLEMENTED AND WHY: I believe all behaviours were implemented.
namespace Thorn_CashFlowManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random arghhhh_an_geee= new Random(DateTime.Now.Millisecond);
            IPayable ADDTHING;
            Info info = new Info();
            ADDTHING = new SalariedEmployee("Barbara", "Gordon", "777-77-7771", 1001);
            info.Add(ADDTHING);
            ADDTHING = new SalariedEmployee("Jason", "Todd", "789-47-7971", 1000);
            info.Add(ADDTHING);
            ADDTHING = new SalariedEmployee("Bruce", "Wayne", "667-93-0271", 5500);
            info.Add(ADDTHING);
            ADDTHING = new HourlyEmployee("Therion", "Strife", "555-31-7935", 2000, 45);
            info.Add(ADDTHING);
            ADDTHING = new HourlyEmployee("Kain", "Highwind", "994-02-8009", 3500, 20);
            info.Add(ADDTHING);
            ADDTHING = new HourlyEmployee("Frankenstein", "Frankenstein", "300-000-0001", 3030, 80);
            info.Add(ADDTHING);
            ADDTHING = new InVoice(arghhhh_an_geee.Next(99999, 1000000) + "_4444", "Tool of Mass Destruction", 4, 6.99M);
            info.Add(ADDTHING);
            ADDTHING = new InVoice(arghhhh_an_geee.Next(99999, 1000000) + "_5797", "BouncyHammer", 7, 4.99M);
            info.Add(ADDTHING);
            ADDTHING = new InVoice(arghhhh_an_geee.Next(99999, 1000000) + "_2044", "Plastic Sword", 8, 2.99M);
            info.Add(ADDTHING);
            bool Breakout = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Salary Employee.");
                Console.WriteLine("2. Add a Hourly Employee.");
                Console.WriteLine("3. Add an Invoice.");
                Console.WriteLine("4. Show the report.");
                Console.WriteLine("5. Exit.");
                ConsoleKeyInfo Selection = Console.ReadKey();

                if (Selection.Key == ConsoleKey.D1 || Selection.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    string FirstName;
                    string LastName;
                    string SSN;
                    decimal WeeklySalary;
                    Console.WriteLine("What is the first name?");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("What is the last name?");
                    LastName = Console.ReadLine();
                    Console.WriteLine("What is the SSN?");
                    SSN = Console.ReadLine();
                    Console.WriteLine("What is the weekly salary?");
                    WeeklySalary = Convert.ToDecimal(Console.ReadLine());
                    ADDTHING = new SalariedEmployee(FirstName, LastName, SSN , WeeklySalary);
                    info.Add(ADDTHING);
                    Console.Clear();
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D2 || Selection.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    string FirstName;
                    string LastName;
                    string SSN;
                    decimal HourlyWage;
                    int TimeWorked;
                    Console.WriteLine("What is the first name?");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("What is the last name?");
                    LastName = Console.ReadLine();
                    Console.WriteLine("What is the SSN?");
                    SSN = Console.ReadLine();
                    Console.WriteLine("What is the hourly salary?");
                    HourlyWage = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("How many hours did they work?");
                    TimeWorked = Convert.ToInt32(Console.ReadLine());
                    ADDTHING = new HourlyEmployee(FirstName, LastName, SSN , HourlyWage , TimeWorked);
                    info.Add(ADDTHING);
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D3 || Selection.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    string PartNumber;
                    string PartDes;
                    int Quant;
                    decimal pwice;
                    Console.WriteLine("What is the Part Number?");
                    PartNumber = Console.ReadLine();
                    Console.WriteLine("What is the Part Description?");
                    PartDes = Console.ReadLine();
                    Console.WriteLine("What is the quantity?");
                    Quant = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the price?");
                    pwice = Convert.ToDecimal(Console.ReadLine());
                    ADDTHING = new InVoice(arghhhh_an_geee.Next(99999, 1000000) + "_"+ PartNumber, PartDes, Quant, pwice );
                    info.Add(ADDTHING);
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D4 || Selection.Key == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    Console.WriteLine("Weekly Cash Flow Analysis is as follows");
                    Console.WriteLine(info.SalariedList());
                    Console.WriteLine(info.HourlyList());
                    Console.WriteLine(info.InvoiceList());
                    Console.WriteLine(info.HowMuch());
                    Console.WriteLine("Category Breakdown:");
                    Console.WriteLine(info.SalaryHowMuch());
                    Console.WriteLine(info.HourlyHowMuch());
                    Console.WriteLine(info.InvoiceHowMuch());
                    Console.WriteLine("press any key to return to the main menu.");
                    Console.ReadKey();
                }
                else if (Selection.Key == ConsoleKey.D5 || Selection.Key == ConsoleKey.NumPad5)
                {
                    Console.Clear();
                    Breakout = true;

                }
             
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please press the 1-5 key. ");
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                    Breakout = false;
                }
            } while (Breakout == false);
        }
    }
}
