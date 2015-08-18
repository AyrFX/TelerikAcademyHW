﻿/*
 * Problem 14.* Print the ASCII Table
 * Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints
 * the entire ASCII table of characters on the console (characters from 0 to 255).
 */
using System;

    class ASCIITable
    {
        static void Main()
        {
            char chr;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int i = 0; i < 256; i++)
            {
                chr = (char)i;
                if (char.IsSymbol(chr) || char.IsLetter(chr) || char.IsNumber(chr))
                {
                    Console.WriteLine("Символът с ASCII код {0} е \"{1}\"", i, chr);
                }
                else
                {
                    Console.WriteLine("Символът с ASCII код {0} е със специално предназначение", i);
                }
            }
        }
    }