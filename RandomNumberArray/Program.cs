using System;
using System.Linq;

namespace RandomNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("How many random numbers would you like to generate?\n");
            int input = Convert.ToInt32(Console.ReadLine());//Takes user input and converts it to int32, input for amount of random numbers
            Console.WriteLine ("Your random numbers are:\n");
            Random gen1 = new Random();//Instances a new Random object

            int[] RandNum = new int[input];//creates an array with a size based on the requested amount of random numbers


            for (int zero = 0; zero < input; zero++) // Creates a for loop that runs the random number generator with the input variable defining the number of loops
            {
                int num = gen1.Next(100);
               RandNum[zero] = num;
            }//Implements the random number generator and assigns its outputs to num, .Next(##) defines the maximum allowed output number
            //"RandNum[zero] = num" outputs num to the array and uses the loop cycle count "zero" as the identifier

            Array.Sort(RandNum);// Sorts the Array
            RandNum.ToList().ForEach(Console.WriteLine);//Prints the contents of the Array

            Console.WriteLine("The max is {0}",RandNum.Max());//Prints the max for the range of outputted random numbers
            Console.WriteLine("The min is {0}",RandNum.Min());//Prints the min for the range of outputted random numbers
        }
    }
}
