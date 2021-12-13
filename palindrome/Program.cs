using System;

namespace palindrome
{
    class Program
    {
        public static void palindromeTest(string input)
        {
            int num = input.Length;
            int same = 0;
            int dif = 0;
            char[] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            for(int i = 0; i< num; i++)
            {

                if(input[i] == reverse[i])
                {
                    same++;
                    
                }
                else if(input[i] != reverse[i])
                {
                    dif++;

                    
                }
            }
            if(dif>2)
            {
                Console.WriteLine("False");
            }
            else if(dif == 2)
            {
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("Is not almost Palindrome");
            }
        }
        static void Main(string[] args)
        {
            string input = "racdcar";

            palindromeTest(input);

        }
    }
}
