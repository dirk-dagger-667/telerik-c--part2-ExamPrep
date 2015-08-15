using System;
using System.Collections.Generic;
using System.Numerics;

class TRES4Numbers
{
    static void Main()
    {
        string inputForTrimZeros = Console.ReadLine();
        if (inputForTrimZeros == "0")
        {
            Console.WriteLine("LON+");
        }
        else
        {
            BigInteger input = BigInteger.Parse(inputForTrimZeros);
            TenToAny(input);
        }
    }

    static void TenToAny(BigInteger decimalNumber)
    {
        List<BigInteger> number = new List<BigInteger>();

        while (decimalNumber > 0)
        {
            number.Add(decimalNumber % 9);
            decimalNumber /= 9;
        }

        for (int i = number.Count - 1; i >= 0; i--)
        {
            if (number[i] < 9 && number[i] >= 0)
            {
                if (number[i] == 0) { Console.Write("LON+"); }
                if (number[i] == 1) { Console.Write("VK-"); }
                if (number[i] == 2) { Console.Write("*ACAD"); }
                if (number[i] == 3) { Console.Write("^MIM"); }
                if (number[i] == 4) { Console.Write("ERIK|"); }
                if (number[i] == 5) { Console.Write("SEY&"); }
                if (number[i] == 6) { Console.Write("EMY>>"); }
                if (number[i] == 7) { Console.Write("/TEL"); }
                if (number[i] == 8) { Console.Write("<<DON"); }
            }
            else
            {
                Console.Write(number[i]);
            }
        }
    }
}
