using System;

namespace D01
{
    public class SecondPart
    {
        static int a ;
        static int b;
        static int c;
        public static void IsEqualTo()
        {
            InputFetcher.getD01Data();
            for(int i = 0; i < InputFetcher.getD01Data().Count; i++)
            {
                for (int j = 0; j < InputFetcher.getD01Data().Count; j++)
                {
                    for (int k = 0; k < InputFetcher.getD01Data().Count; k++)
                    {
                        if (a+b+c != 2020)
                        {
                            a = InputFetcher.getD01Data()[i];
                            b = InputFetcher.getD01Data()[j];
                            c = InputFetcher.getD01Data()[k];
                            Console.WriteLine(a + ", "+ b+ ", "+c);
                            Console.WriteLine(a +b+c);
                        } else if (a+b+c == 2020)
                        {
                            Console.WriteLine("Trouvé !");
                            Console.WriteLine(a + ", "+ b+ ", "+c);
                            Console.WriteLine(a*b*c);
                            break;
                        }
                    }
                }
            }
        }
    }
}