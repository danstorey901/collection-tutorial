using System;
using System.Collections.Generic;

namespace collection_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var frames = new List<int>();

            for (var idx = 0; idx < 30; idx++) // var = 0, run it, is it less than 30? well yes because it increased by 1, so run it again...right??
            {
                var frame = rnd.Next(0, 31);
                frames.Add(frame);
            }

            var game = 0;
               foreach (var score in frames) 
               {
                   game += score;
               }
                Console.WriteLine($"Game is {game}");



            //    var listofNumbers = new List<int>();
            //    listofNumbers.Add(98);
            //    listofNumbers.Add(7);
            //    listofNumbers.Add(56);
            //    listofNumbers.Add(13);
            //    listofNumbers.Add(72);
            //    listofNumbers.Add(42);
            //    listofNumbers.Add(44);

            //    var sum = 0;
            //    foreach (var nbr in listofNumbers) {
            //        sum += nbr;
            //    }
            //    Console.WriteLine($"Sum is {sum}");
            //




            // *****************************THIS CODE IS SEPERATE!**********************************************************
            // int Add1(int n) {
            //      return n + 1;
            // }
            // var value = Add1(7);   - after this is executed, value = 8
            // void Print(string s)
            // {
            //    Console.WriteLine(s);
            // }
            //  Print("MAX"); - Displays MAX on the console

        }

    }
}
