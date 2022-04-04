// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the area of a trapezoid.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseA;
        int baseB;
        int height;
        int area;
        //input
        Console.WriteLine("This program finds the area of a trapezoid.");
        Console.WriteLine("");
        Console.WriteLine("Formula = ((A + B) ÷ 2) x H");
        Console.WriteLine("");
        Console.Write("Enter the A base of the trapezoid (mm): ");
        baseA = int.Parse(Console.ReadLine());
        Console.Write("Enter the B base of the trapezoid (mm): ");
        baseB = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the pyramid (mm): ");
        height = int.Parse(Console.ReadLine());
        //process
        area = ((baseA + baseB) / 2) * height;
        //output
        Console.WriteLine("");
        Console.Write("Area of the trapezoid = " + area.ToString("0.00") + " mm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}