using System;

namespace Pi
{
    class Program
    {
         static void Main(string[] args)
        {
            decimal pi = EstimatedPi(Int32.Parse(args[0]));

            Console.WriteLine(pi.ToString());
        }

        public static decimal EstimatedPi(int n)
        {
            decimal pointCircle = 0;
            decimal pointTotal = 0;

            Random rnd = new Random();

            for( int i =0; i < n; i += 1)
            {
                int x = rnd.Next(0, 2);
                int y = rnd.Next(0, 2);

                //Console.WriteLine($"randoms at cycle {i}: x:{x} y:{y}");

                decimal distance = x*x + y*y;

                if(distance <= 1)
                {
                    pointCircle += 1;
                }  
                    pointTotal += 1;
                

            }

            decimal pi = 4 * pointCircle/pointTotal;

            Console.WriteLine($"Points inside circle: {pointCircle.ToString()}");
            Console.WriteLine($"Total Points: {pointTotal.ToString()}");

            return Math.Round(pi, 3);
        }
    }
}
