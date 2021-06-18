using System;

namespace D01
{
    public class FirstPart
    {
        static int a;
        static int b;
        static int c;

        public static void IsEqualTo()
        {
            InputFetcher.getD01Data();
            foreach (var number in InputFetcher.getD01Data())
            {
                if (number < 1000)
                {
                    a = number;
                }
                else
                {
                    b = number;
                }

                c = a + b;
                if (c != 2020)
                {
                    Console.WriteLine("Non");
                }
                else
                {
                    Console.WriteLine(a +","+ b);
                    Console.WriteLine(a*b);
                }
            }
        }
    }
}