using System;
using BasicAlgorithms;

namespace BasicAlgorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Algorithms algorithms = new Algorithms();
            algorithms.SmallestNumber(); //Smallest number execution
            algorithms.SumAndAverage(); //Sum and Average execution
            algorithms.ReverseString(); //Reverse String execution
            algorithms.GetAllSubstrings(); //Get All Substrings execution
            algorithms.CountCharacterType(); // Count Character Type execution

            //Fibonacci execution
            var num = 42;
            //Iterative way
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var fib = algorithms.Fibonacci_Iterative(num);
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Fibonacci Iterative({0}) = {1}", num, fib);
            Console.WriteLine("Elapsed Time: {0} miliseconds", elapsedTime);
            Console.WriteLine();

            //Recursive way
            watch = System.Diagnostics.Stopwatch.StartNew();
            fib = algorithms.Fibonacci_Recursive(num);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Fibonacci Recursive({0}) = {1}", num, fib);
            Console.WriteLine("Elapsed Time: {0} miliseconds - ({1} seconds)", elapsedTime, elapsedTime / 1000);

            Console.ReadKey();
        }
    }
}
