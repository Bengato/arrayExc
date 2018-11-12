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
            int[] filterThisArray = new int []{ 1, 2, 3, 4, 5, 6,7,8,9,10,11,12 };
            int[] filteredArray =FilterEvanNumbers(filterThisArray);
            for(int i = 0; i < filteredArray.Length; i++)
            {
                Console.Write(filteredArray[i]+" ");
            }
            Console.WriteLine();
        }

        static int[] FilterEvanNumbers(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] evanNumbersArray = new int[count];
            for(int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evanNumbersArray[j++] = array[i];
                }
            }
            return evanNumbersArray;
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
