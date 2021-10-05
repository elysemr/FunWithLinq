using System;
using System.Linq;

namespace FunWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //create collection of ints
            int[] ints = new int[]
            {
                620, 849, 649, 989, 993, 524, 216, 173, 136, 482,
                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
                621, 981, 103, 482, 917, 124, 276, 839, 476 ,789,
                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
            };

            var newSum = ints.Sum() - ints.Max() - ints.Min();
            var amendedAvg = newSum / (ints.Count() - 2.0); //need () for right answer because of division with subtraction,
                                                            //did 2.0 to return a decimal instead of an int
            Console.WriteLine(amendedAvg);

            Console.WriteLine($"Avg is {ints.Average()}"); //always use variable name with linq method
                                                           //takes integers in but outputs a double
            Console.WriteLine($"Highest is {ints.Max()} and lowest is {ints.Min()}");
            Console.WriteLine($"There are {ints.Count()} ints in this array.");
           
        }
    }
}
