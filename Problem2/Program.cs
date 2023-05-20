using System;

namespace HelloWorldCodeSpaces
{

    class Program
    {
        static void Main(String[] args)
        {
            int sum = 0;
            int limit = 4000000;
            int previous = 1;
            int current = 2;


            while (current <= limit) {

                if (current % 2 == 0) {
                    sum += current;
                }

                int next = previous + current;
                previous = current;
                current = next;
            }

            Console.WriteLine("Sum: " + sum);


        }
    }
}