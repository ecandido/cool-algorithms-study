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
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();

                double distance = Math.Pow(x, 2) + Math.Pow(y, 2);

                if(distance <= 1)
                {
                    pointCircle += 1;
                }  
                    pointTotal += 1;
                

            }

            decimal pi = 4 * pointCircle/pointTotal;

            Console.WriteLine($"Points inside circle: {pointCircle.ToString()}");
            Console.WriteLine($"Total Points: {pointTotal.ToString()}");

            return pi;
        }
    }
}
