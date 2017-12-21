using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice13
{
    class Program
    {
        static void Main(string[] args)
        {   //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            string userInput;
            var intList = new List<int>();//create a list to hold all numbers entered

            do
            {
                Console.WriteLine("Please enter a whole number or type 'Quit' to exit the program:");
                userInput = Console.ReadLine();

                if (userInput == "quit" || userInput == "Quit") //exit message
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                int temp;
                bool indicator = int.TryParse(userInput, out temp); //only if number when parsed, add it to the list
                                
                if (indicator == true)
                {
                    intList.Add(temp);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

                Console.WriteLine(); //blank
                Console.WriteLine();//blank

                Console.WriteLine("The unique numbers you have entered are: ");
                var uniqueItems = intList.Distinct();  //grab only the distinct values

                foreach (var item in uniqueItems)
                {
                    Console.WriteLine(item);
                }

            } while (userInput != "quit" || userInput != "Quit");
        }
    }
}
