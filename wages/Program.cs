using System;

namespace wages
{
    class Program
    {
        public static void WageCalc(double[] stats)
        {
            double start = stats[0];
            double end = stats[1];
            double rate = stats[2];
            double or = stats[3];
            double total;
            double overtime;
            if(end > 17)
            {
                overtime = end - 17;
                double pay = (17-start)*rate;
                double ot = overtime*rate*or;
                total = pay + ot;
            }
            else
            {
                total = (end-start)*rate;
            }
            Console.WriteLine(total);
        }
        static void Main(string[] args)
        {
            double a = 9;
            double b = 17;
            double c = 30;
            double d = 1.5;

            double[] stats = {a, b, c, d};
            WageCalc(stats);
        }
    }
}
