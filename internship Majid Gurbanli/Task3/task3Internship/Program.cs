using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4 };
           int min =  CountMinCombination(arr);
            int max=  CountMaxCombination(arr);
            Console.WriteLine($"Total output is {min+max}");

        }
        static int CountMaxCombination( int [] arr)
        {
         

            int maksFirstValue;
            int maksFirstIndex;
            int maksSecondValue;
            int maksSecondIndex;
            int maksThirdValue;
            int maksThirdIndex;
            int outputCount = 0;
            List<int> markedIds = new List<int>();
            List<int[]> combinationsMaks = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {

                maksFirstValue = arr[i];
                maksFirstIndex = i;
                //Console.WriteLine("First maximum is" + maksFirstValue);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        maksSecondValue = arr[j];
                        maksSecondIndex = j;

                        //Console.WriteLine("         Second Maksimum is " + maksSecondValue);

                        for (int t = maksSecondIndex + 1; t < arr.Length; t++)
                        {
                            if (arr[t] > arr[j])
                            {
                                maksThirdValue = arr[t];
                                int[] customCombination = new int[3] { maksFirstValue, maksSecondValue, maksThirdValue };
                                combinationsMaks.Add(customCombination);

                                maksThirdIndex = t;
                                //Console.WriteLine("                         THird value is " + maksThirdValue);


                                outputCount++;


                            }

                        }


                    }


                }



            }

            for (int i = 0; i < combinationsMaks.Count; i++)
            {
                Console.WriteLine($"({combinationsMaks[i][0]},{combinationsMaks[i][1]},{combinationsMaks[i][2]})");
            }
            return outputCount;

        }
        static int CountMinCombination(int[] arr)
        {

            int minFirstValue;
            int minFirstIndex;
            int minSecondValue;
            int minSecondIndex;
            int minThirdValue;
            int minThirdIndex;
            int outputCount = 0;
            List<int> markedIds = new List<int>();
            List<int[]> combinationsMaks = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {

                minFirstValue = arr[i];
                minFirstIndex = i;
                //Console.WriteLine("First maximum is" + maksFirstValue);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        minSecondValue = arr[j];
                        minSecondIndex = j;

                        //Console.WriteLine("         Second Maksimum is " + maksSecondValue);

                        for (int t = minSecondIndex + 1; t < arr.Length; t++)
                        {
                            if (arr[t] < arr[j])
                            {
                                minThirdValue = arr[t];
                                int[] customCombination = new int[3] { minFirstValue, minSecondValue, minThirdValue };
                                combinationsMaks.Add(customCombination);

                                minThirdIndex = t;
                                //Console.WriteLine("                         THird value is " + maksThirdValue);


                                outputCount++;


                            }

                        }


                    }


                }



            }

            for (int i = 0; i < combinationsMaks.Count; i++)
            {
                Console.WriteLine($"({combinationsMaks[i][0]},{combinationsMaks[i][1]},{combinationsMaks[i][2]})");
            }
            return outputCount;
        }
    }
}
