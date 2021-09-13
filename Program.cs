/*
 Aruthor: Andrew Rodriguez
 Date: 9/13/2021
 Description:
*/

using System;

namespace Tech_Proj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user expected grade
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

             
             {
                string input = Console.ReadLine();

                decimal grade = decimal.Parse(input);

                
                // Conditional statement testing if input is less then 90
                if (grade >= 90)
                {
                    // If value is true, grade greater or equal to 90
                    // prints out "A"
                    Console.WriteLine("A");
                }
                else if (80 <= grade && grade < 90)
                {
                    // If grade is less then 90 and greater then 80
                    // prints out "B"
                    Console.WriteLine("B");
                }
                else if (70 <= grade && grade < 80)
                {
                    // If grade is less then 80 and greater then 70
                    // prints out "C"
                    Console.WriteLine("C");
                }
                else if (60 <= grade && grade < 70)
                {
                    // If grade is less then 70 and greater then 60
                    // prints out "D"
                    Console.WriteLine("D");
                }
                else if (grade < 60)
                {
                    // If value is less then 60 prints "F"
                    Console.WriteLine("F");
                }

            }




        }
    }
}
