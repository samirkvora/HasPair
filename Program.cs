using System;

namespace CodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 4, 3, 2 }; //-> true: Found pair of 3s
            int[] array2 = { 3, 3, 3 }; //-> true: OK to have more than a pair
            int[] array3 = { 1, 2, 3 }; //-> false: no pair found
            Console.WriteLine(HasPair(array1));
            Console.WriteLine(HasPair(array2));
            Console.WriteLine(HasPair(array3));
        }

        /* TODO: Implement HasPair
         *       
         * Search array of integers and determine if the array contains
         * at least one pair of the same integer value
         * 
         * Examples:
         * { 3, 4, 3, 2} -> True (found a pair of 3's)
         * { 3, 3, 3} -> True (still found a pair of 3's)
         * { 1, 2, 3} -> False (no pair found)     
         */
        static Boolean HasPair(int[] arr)
        {
            //TODO: Implement HasPair
            return false;
        }
    }
}
