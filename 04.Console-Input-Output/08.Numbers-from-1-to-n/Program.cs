﻿/*
 * Problem 8. Numbers from 1 to n
 * Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
 * each on a single line.
 * Note: You may need to use a for-loop.
 * 
 * Examples:
 * input 	output
 * 3 	    1
 *          2
 *          3
 * 5 	    1
 *          2
 *          3
 *          4
 *          5
 * 1     	1
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number;
        int.TryParse(Console.ReadLine(), out number);
        Console.WriteLine(new String('=', 40));
        for (int cnt = 1; cnt <= number; cnt++)
        {
            Console.WriteLine(cnt);
        }
    }
}