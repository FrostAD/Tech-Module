﻿using System;

namespace _03._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {ID:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
