using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace D01

{
    public static class InputFetcher
    {
        //Fonction qui parse mon fichier de nombres.
        public static List<int> getD01Data()
        {
            string fileContent = File.ReadAllText("InputNumber.txt");
            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            for (int n =  0; n < integerStrings.Length; n++)
                integers[n] = int.Parse(integerStrings[n]);
            return integers.ToList();
        }
            

        
    }
}