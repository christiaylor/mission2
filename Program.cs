﻿using System;
using mission1;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to my dice simulation!!");
        System.Console.WriteLine("How many times would you like to roll the dice?");
        int numOfTimes = int.Parse(System.Console.ReadLine());

        Class1 class1 = new Class1();

        int[] rollSums = class1.rollDice(numOfTimes);
        
        DisplayPercentage(rollSums, numOfTimes);

    }


    public static void DisplayPercentage(int[] rollSums, int sumTotal)
    {
        Console.WriteLine("Dice Results!!");
        for (int i = 2; i < 13; i++)
        {
            double pct = (double)rollSums[i] / sumTotal * 100;
            Console.Write($"{i}: {pct:F2}% ");

            int stars = (int)pct;
            Console.WriteLine(new string('*', stars));
        }
    }
}