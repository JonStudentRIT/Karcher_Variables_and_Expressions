using System;

namespace Karcher_Variables_and_Expressions
{
     /*  Author: Jonathan Karcher
      *  Purpose: To find the product of 4 user enterd whole numbers
      *  Restrictions: none
      */
    class Program
    {
        /*  Method: Main
         *  Purpose: Storage of values and ensure that each question is asked in the correct order 
         *  Restrictions: none
         */
        static void Main(string[] args)
        {
            // storage for all the numbers that will be added
            int[] aNumbers = new int[4];
            // greet the user to give them instructions
            Greeting();
            for(int i = 0; i < 4; i++)
            {
                // store each acceptable value in "aNumbers"
                aNumbers[i] = NumbersEntered(i);
            }
            // Output the product of "aNumbers"
            Console.WriteLine("The product of the numbers that you have entered is\n" + Product(aNumbers));
            

            Console.ReadLine();
        }
        /*  Method: Greeting
         *  Purpose: Greet the player
         *  Restrictions: None
         */ 
        static void Greeting()
        {
            Console.WriteLine("Hello, I am going to ask you to enter 4 whole numbers");
        }
        /*  Method: NumbersEntered
         *  Purpose: To collect the numbers enterend from the user and to stop progress if they are not acceptable
         *  Restrictions: None
         */
        static int NumbersEntered(int num)
        {
            // temperary string to attampt to parse
            string sEntered;
            // ensure that the user cant proceede without correct input
            bool bIsAnInt = false;
            do
            {
                // prompt the user for a number and tell them what number in the series they are entering
                Console.WriteLine("Please enter number " + (num + 1));
                sEntered = Console.ReadLine();
                // check if the number enterd is correct and if so the user can continue
                bIsAnInt = CorrectInputCheck(sEntered);
            }
            while (!bIsAnInt);
            // once the number is confirmed to be an int then it can be stored in "aNumbers"
            return Int32.Parse(sEntered);
        }
        /*  Method: CorrectInputCheck
         *  Purpose: Verify that the chars entered are numbers and that they are whole numbers
         *  Restrictions: None
         */
        static bool CorrectInputCheck(string sEntered)
        {
            bool acceptable = false;
            // contain the entire parsed value
            int parse = 0;
            // find out if they entered a number
            if (Int32.TryParse(sEntered, out parse))
            {
                acceptable = true;
            }
            return acceptable;
        }
        /*  Method: Product
         *  Purpose: find the product of numbers entered 
         *  Restrictions: None
         */
        static long Product(int[] aNumbers)
        {
            // Manually set the first value to product
            // Note: long is used as it is very easy to break the integer limit
            long product = aNumbers[0];
            // Multiply each element of "aNumbers" one by one to the total product
            for(int i = 1; i < 4; i++)
            {
                product *= aNumbers[i];
            }

            return product;
        }
    }
}
