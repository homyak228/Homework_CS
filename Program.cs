using System;

namespace Homework_CS
{
    internal class Program
    {
        public static void Exit()
        {
            Console.Write("Enter any key to exit...");
            Console.ReadKey();
        }
        public static void Homework(string[] args)
        {
            Console.Write("Enter number of exercise(1-5): ");
            byte ex = byte.Parse(Console.ReadLine());
            Console.Clear();
            switch (ex)
            {
                case 1:
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("Enter third number: ");
                    int c = int.Parse(Console.ReadLine());

                    Console.WriteLine(a + "*" + b + "*" + c + " = " + a * b * c);
                    Exit();
                    break;

                case 2:
                    Console.Write("Enter length in sm: ");
                    double sm = double.Parse(Console.ReadLine());


                    Console.WriteLine("Here is your length in meters: " + sm / 100 + ".");
                    Exit();
                    break;
                case 3:
                    Console.Write("Enter height of cylinder: ");
                    double height = double.Parse(Console.ReadLine());

                    Console.Write("Enter radius of cylinder: ");
                    double radius = double.Parse(Console.ReadLine());

                    Console.WriteLine("Volume of cylinder: " + Math.PI * Math.Pow(radius, 2) * height + ".");
                    Exit();
                    break;
                case 4:
                    Console.Write("Enter time in minuts: ");
                    int mins = int.Parse(Console.ReadLine());

                    int hours = mins / 60;
                    int minutes = mins - hours * 60;

                    Console.WriteLine("Your time is: " + hours + " hours, " + minutes + " minutes.");
                    Exit();
                    break;
                case 5:
                    Console.Write("Enter distance int km: ");
                    double kilometers = double.Parse(Console.ReadLine());

                    Console.Write("Enter time in hours: ");
                    double hours_v = double.Parse(Console.ReadLine());

                    Console.WriteLine("Speed of your object is " + kilometers / hours_v + "km/h.");
                    Exit();
                    break;
            }
        }
    }
}