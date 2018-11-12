using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companies = { "Apple", "Microsoft", "IBM", "Intel" };
            int[] array= { 1, 2, 3, 1};
            Console.WriteLine(WhatsMyMaxNum(array)+" is the biggest number in the array.");
            Console.WriteLine(MaxEarningsCompany(array,companies)+" is the highest earning company.");
        }
        static int WhatsMyMaxNum(int[] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        static string MaxEarningsCompany(int[] array,string[] companies)
        {
            int max = array[0],index=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return companies[index];
        }
    }
}
