using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Wk3Ex1_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Goals: Take a numberic overall score from 0 to 100
             * from the user and convert it to a letter grade using a 
             * switch statement */

            // Declare variables
            double numberGrade = 0; // Declare a double variable for numberGrade and initialize it to 0
            double roundedGrade = 0; // Declare a double variable for roundedGrade and initialize it to 0
            string gradeString = ""; // Declare a double variable for gradeString and initialize it to 0

            // Do-While statement with a nested if to ensure the grade inputted is between 0 and 100
            // start with a do statement to ensure numberGrade gets changed at least once by the user
            do
            {
                // Output statement prompting the user to input a overall number grade of a student
                Console.Write("What is a numberic score (0 to 100)? ");
                // Collect input from user and store it in numberGrade
                numberGrade = Convert.ToDouble(Console.ReadLine());

                // if statement to determine if the grade is within range
                if (!(numberGrade >= 0 && numberGrade <= 100))
                    // if it is not in range, output a statement telling the user it is not in range
                    Console.WriteLine("You input a number out of range.");
            }
            // while it continues to be not in range, return to the statement to prompt the user to input the number grade
            while (!(numberGrade >= 0 && numberGrade <= 100));


            roundedGrade = Math.Round(numberGrade);
            
            // if statement to ensure grades which start with a 1 or single digit grades don't get misplaced (i.e. 19 != 100 and 8 != 80 in their results)
            // check if roundedGrade is < 20
            if (roundedGrade < 20) {
                // if true, convert roundedGrade to 0
                roundedGrade = 0;
            }

            // convert roundedGrade to a string and store it in the variable gradeString
            gradeString = roundedGrade.ToString();


            // Select the first character in gradeString to compare to the cases
            switch (gradeString[0])
            {
                // run this case if numberGrade = 1
                case '1':
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("100");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: A");
                    // Jump out of switch here
                    break;

                // run this case if numberGrade = 9
                case '9':
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("90");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: A");
                    // Jump out of switch here
                    break;

                // run this case if numberGrade = 8
                case '8':
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("80");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: B");
                    // Jump out of switch here
                    break;

                // run this case if numberGrade = 7
                case '7':
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("70");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: C");
                    // Jump out of switch here
                    break;

                // run this case if numberGrade = 6
                case '6':
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("60");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: D");
                    // Jump out of switch here
                    break;

                // for the rest of numbers input, default to F
                default:
                    // Output the near-value we got the letter grade from upon conversion 
                    Console.WriteLine("Less than 60");
                    // Output the original number and what it's letter grade is 
                    Console.WriteLine($"The letter grade for score {numberGrade} is: F");
                    // Jump out of switch here
                    break;
            }

            // pause at end of program for user to read screen
            Console.ReadLine();
        }
    }
}
