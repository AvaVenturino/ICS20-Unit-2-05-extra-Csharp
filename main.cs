// Created by: Ava Venturino
// Created on: March 22 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int hoursworked;
        int hourlyrate;

        Console.WriteLine("This program determines your pay and the amount you have to give the government.");
        Console.WriteLine("");
        Console.Write("Enter the amount of hours worked: ");
        hoursworked = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your hourly rate: ");
        hourlyrate = Convert.ToInt32(Console.ReadLine());

        Double pay = (hoursworked * hourlyrate) * (1.00 - 0.18);
        Double taxes = (hoursworked * hourlyrate) * 0.18;
        Console.WriteLine("");
        Console.Write("Your pay will be: " + " $" + pay.ToString("0.00"));
        Console.ReadKey();
        Console.WriteLine("");
        Console.Write("The government will take: " + " $" + taxes.ToString("0.00"));
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}