/*
 Author: Ashlee Sewell
Date: 2/5/2021
Comments: This is the program file for the Array deliverable.
*/
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                try
                {
                    //manually populated array
                    int[] numbers = { 1, 4, 6, 8, 9, 2, 22, 29, 32, 35, 37, 38, 40, 41, 43, 47, 49, 52, 54, 57, 58, 63, 67, 69, 72 };
                    Console.WriteLine(" Here are the values of the array:");
                    //Interate through array with foreach loop
                    foreach (int i in numbers)
                    //Display array values
                    {

                        Console.Write("Element Value = " + i + " ");

                    }
                }



                catch
                {
                    Console.WriteLine(" Press any key to exit the program");
                    Console.ReadKey(true);
                }

            }
        }
    }
}

