using System;
using System.Collections.Generic;
using System.Linq;

namespace fractions
{
    class Program
    {
        public static double UniqueFraq()
        {
            List<double> fraq = new List<double>();
            List<double> nope = new List<double>();
            for(int i =1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    double f = (double)i/j;
                    bool check = fraq.Contains(f);
                    if(f < 1 && check == false)
                    {
                        fraq.Add(f);
                    }
                    else if(f >= 1 || check == true)
                    {
                        nope.Add(f);
                    }
                    
                }
            }
            double ans = fraq.Sum();
            return Math.Round(ans,3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueFraq());
        }
    }
}
