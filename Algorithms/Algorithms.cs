using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    public class Algorithms
    {
        //Takes the smallest number inside an array
        public void SmallestNumber()
        {
            int i = 0;
            int small = 0;

            //Integer array declaration
            int[] arr = new int[4];

            Console.WriteLine("Enter the array elements");
            //Read array elements
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Assign fist element to the 'small' 
            //Compare it with other array elements
            small = arr[0];

            for (i = 1; i < arr.Length; i++)
            {
                //Compare if small is greater than of any element of the array
                //Assign that element in it.
                if (small > arr[i])
                    small = arr[i];
            }

            //Finally print the smallest element of the integer array
            Console.WriteLine("Smallest element in array is: " + small);
            Console.ReadKey();
        }


        //Calculates the sum of all the numbers inside an array and take the average of it
        public void SumAndAverage()
        {
            int i, n, sum = 0;

            Console.Write("\n\nFind the sum of all the elements of an array\n");
            Console.Write("-------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array:\n", n);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Element [{0}]: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            int avg = sum / n;

            Console.Write("Sum of all elements stored in the array is: {0}\n\n", sum);
            Console.Write("Average of all elements stored in the array is: {0}\n\n", avg);
            Console.ReadKey();
        }


        /* Write a program that prints the numbers inside of an array.
        But for multiples of three, print "Fizz" instead of the number and for the multiples of five print "Buzz".
        For numbers which are multiples of both three and five print "FizzBuzz".
        */
        public void FizzBuzz()
        {
            List<int> collection = new List<int>();

            foreach (int x in collection)
            {
                bool insertNewline = false;
                if (x % 3 == 0)
                {
                    Console.Write("Fizz");
                    insertNewline = true;
                }
                if (x % 5 == 0)
                {
                    Console.Write("Buzz");
                    insertNewline = true;
                }

                if (insertNewline)
                {
                    Console.Write(Environment.NewLine);
                }
            }

        }


        //Fibonacci - Iterative way (take less time)
        public int Fibonacci_Iterative(int len)
        {
            //Move a and b across all the Fibonacci sequence
            int a = 0, b = 1;
            int temp = 0;
            for (int i = 0; i < len; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        //Fibonacci - Recursive way (take more time)
        public int Fibonacci_Recursive(int n)
        {
            if ((n == 0) || (n == 1))
            {
                //Fib(0) = 0 and Fib(1) = 1
                return n;
            }
            else
                //Call this method recursively
                return Fibonacci_Recursive(n - 1) + Fibonacci_Recursive(n - 2);
        }


        //This reverses a received string
        public void ReverseString()
        {
            string str;
            int l = 0;

            Console.Write("\n\nPrint individual characters of string in reverse order\n");
            Console.Write("----------------------------------------------------------\n");
            Console.Write("Input the string: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are: \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }

            Console.Write("\n\n");
            Console.Read();
        }


        //Show all the existent substrings inside a string
        public void GetAllSubstrings()
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.Read();
        }


        //Counts the type of characters inside a string
        public void CountCharacterType()
        {
            string str;
            int alp, digit, splch, i, l;
            alp = digit = splch = i = 0;

            Console.Write("\n\nCount total number of alphabets, digits and special characters\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Input the string: ");
            str = Console.ReadLine();
            l = str.Length;

            /* Checks each character of string */
            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is: {0}\n", alp);
            Console.Write("Number of Digits in the string is: {0}\n", digit);
            Console.Write("Number of Special characters in the string is: {0}\n\n", splch);
            Console.Read();
        }
    }
}