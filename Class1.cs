using System;

namespace Homework_CS
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter exercise(1-5): ");
            byte ex = byte.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    double pi = Math.PI;
                    int tenThousand = 10000; // Исправьте тип
                    double tenThousandPi = pi * tenThousand; // Исправьте тип
                    int roundedTenThousandPi = (int)Math.Round(tenThousandPi); // Исправьте тип
                    int integerPartOfTenThousandPi = (int)tenThousandPi; // Исправьте тип
                    Console.WriteLine(integerPartOfTenThousandPi);
                    Console.WriteLine(roundedTenThousandPi);
                    Program.Exit();
                    break;
                case 2:
                    double amount = 1.11; // количество биткоинов от одного человека
                    int peopleCount = 60; // количество человек
                    int totalMoney = (int)(amount * peopleCount); // Исправьте строку
                    Console.WriteLine(totalMoney);
                    Program.Exit();
                    break;
                case 3:
                    string doubleNumber = "894376.243643";
                    int number = (int)Convert.ToDouble(doubleNumber); // Исправьте строку
                    Console.WriteLine(number + 1);
                    Program.Exit();
                    break;
                case 4:
                    double a = 5; // Исправьте эту строку
                    a += 0.5;
                    Program.Exit();
                    break;
                case 5:
                    Console.Write("Enter first rounded num: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Enter second not-rounded num: ");
                    double num_2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sum: " + (double)((double)num + num_2));
                    Console.WriteLine("Diff: " + (double)(num - num_2));
                    Console.WriteLine("Quo: " + (double)(double)num / num_2);
                    Console.WriteLine("Pro: "  + (double)(double)num * num_2);

                    Program.Exit();
                    break;
            }
        }
    }
}
