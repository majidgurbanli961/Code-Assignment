using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            // reads from user the length of array and exit from program if there is given a wrong data
            Console.WriteLine("Give a quantity of numbers which You want to check(it must be strictly between 1 and 1000)");
            int.TryParse(Console.ReadLine(), out int customLength);
            if (customLength > 1000 || customLength<0){
                Console.WriteLine("You give wrong number");
                return;




                }
            // reads from user numbers which he want to check and ask again if there is wrong data
            double[] myArr = new double[customLength] ;
            double eachNumber;
            Console.WriteLine("Give numbers which you want to check");
            for (int i = 0; i < myArr.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out eachNumber);


                if (eachNumber > 1000 || eachNumber < -1000)
                {
                    Console.WriteLine("You give wrong number please give it again");
                    i--;
                    continue;
                }
                myArr[i] = eachNumber;
               

            }
            List<int> customList = new List<int>();
            customList = CountNumbOfRepeated(myArr);
            if (CheckSameNumbers(customList) == true)
            {
                Console.WriteLine("Given array by you is true");
            }
            else
            {
                Console.WriteLine("Given array by you is false");
            }
           
            

        }
        // return a list with the numbers of each number
        static List<int> CountNumbOfRepeated(double [] myArr)
        {
            List<int> numbOfRepeated = new List<int>();
         
            int counter = 0;
            Array.Sort(myArr);
            for (int i = 0; i < myArr.Length; i++)
            {
                if (i == myArr.Length - 1)
                {
                    numbOfRepeated.Add(counter + 1);
                    break;

                }
                if (myArr[i] == myArr[i + 1])
                {
                    counter++;
                }
                else
                {
                    numbOfRepeated.Add(counter + 1);
                    counter = 0;

                }

            }

            return numbOfRepeated;

        }
        // return true if int the list there is no repeated number
        static bool CheckSameNumbers( List<int> numbOfRepeated)
        {
            int countSameNumbs = 0;
            numbOfRepeated.Sort();


            for (int i = 0; i < numbOfRepeated.Count; i++)
            {
                if (i == numbOfRepeated.Count - 1)
                {
                    break;
                }
                if (numbOfRepeated[i] == numbOfRepeated[i + 1])
                {
                    countSameNumbs++;
                    break;
                }

            }
            if (countSameNumbs == 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }
}
