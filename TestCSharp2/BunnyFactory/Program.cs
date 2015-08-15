using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bunniesInCages = new List<string>();

            for (int i = 0; ; i++)
            {
                string inputNumber = Console.ReadLine();
                if (inputNumber == "END")
                {
                    break;
                }
                bunniesInCages.Add(inputNumber);
            }

            int firstSum = int.Parse(bunniesInCages[0]);
            bunniesInCages.RemoveAt(0);
            int sum = 0;
            BigInteger product = new BigInteger();
            product = 1;
            int counter = 2;
            
            for (int j = 0; j < firstSum; j++)
            {
                sum += int.Parse(bunniesInCages[j]);
                product *= BigInteger.Parse(bunniesInCages[j]);
            }

            string sumPlusProduct = sum + product.ToString();
            bunniesInCages.RemoveRange(0, firstSum);
            List<string> newList = new List<string>();
            newList.AddRange(sumPlusProduct.Select(c => c.ToString()).ToList());
            newList.AddRange(bunniesInCages);
            newList.Remove("0");
            newList.Remove("1");
            bunniesInCages = newList;
            while (counter < bunniesInCages.Count || firstSum < bunniesInCages.Count - firstSum)
            {
                sum = 0;
                product = 1;
                firstSum = 0;
                for (int k = 0; k < counter; k++)
                {
                    firstSum += int.Parse(bunniesInCages[k]);
                }
                bunniesInCages.RemoveRange(0,counter);
                bunniesInCages.RemoveAll(item => item == null);
                for (int a = 0; a < firstSum; a++)
                {
                    sum += int.Parse(bunniesInCages[a]);
                    product *= int.Parse(bunniesInCages[a]);
                }
                newList.RemoveAll(item => item == null);
                sumPlusProduct = sum + product.ToString();
                bunniesInCages.RemoveRange(0,firstSum);
                bunniesInCages.RemoveAll(item => item == null);
                newList.Clear();
                newList.AddRange(sumPlusProduct.Select(c => c.ToString()).ToList());
                newList.AddRange(bunniesInCages);
                newList.Remove("0");
                newList.Remove("1");
                bunniesInCages = newList;
                counter++;
            }

            for (int f = 0; f < bunniesInCages.Count - 1; f++)
            {
                Console.Write(bunniesInCages[f] + " ");
            }
            Console.Write(bunniesInCages[bunniesInCages.Count - 1]);
        }
    }
}
