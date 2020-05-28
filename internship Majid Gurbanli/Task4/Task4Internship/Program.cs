using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] covidPeople = new int[1000];
            int yuzluk;
            int myResultSecond;
            for (int i = 0; i < covidPeople.Length; i++)
            {
                covidPeople[i] = 1;
                if (i == 326)
                {
                    covidPeople[i] = 2;

                }

            }
            int myResult=0;
            int myResultThird = 0;
            int myResultFourth = 0;
            for (int i = 0; i < 10; i++)
            {
                myResult=CheckCovidPositiveFirst(covidPeople, i);
              
                if (myResult > 0)
                {
                    yuzluk = myResult;
                   
                    for (int j = 0; j < 9; j++)
                    {
                        myResultSecond= CheckCovidPositiveSecond(covidPeople, j,myResult);
                     
                        if (myResultSecond > 0)
                        {
                            for (int t = 0; t < 8; t++)
                            {
                                myResultThird = checkCovidPositiveThird(covidPeople, t, myResultSecond);
                                if (myResultThird > 0)
                                {
                                    for (int z = 0; z < 5; z++)
                                    {
                                        myResultFourth = checkCovidPostiveFourth(covidPeople, z, myResultThird);


                                    }
                                }

                            }
                            
                      
                            break;
                        }

                    }
                    break;
                }



            }

      
            
            
        }
        static int CheckCovidPositiveFirst(int[] covidPeople,int tubeId)
        {
            int sum = 0;
            for (int i = tubeId*100; i < (tubeId* 100 + 100); i++)
            {
                sum = sum + covidPeople[i];
            }
            if (sum == 100)
            {
                return -1;

            }
            return tubeId*100;

        }
        static int CheckCovidPositiveSecond(int[] covidPeople,int tubeId,int entryPointFirst)
        {
            int sum = 0;
            for (int i= entryPointFirst+(tubeId*11); i  < entryPointFirst+ ((tubeId+1)*11); i ++)
            {
                if (i == 388)
                {
                    break;
                }
                sum += covidPeople[i];
            
            }
            if (entryPointFirst == 388)
            {
                for (int i = entryPointFirst + tubeId * 11; i <= (tubeId + 1) * 11; i++)
                {
                sum += covidPeople[i];

                }

            }
            if (sum == 11)
            {
                return -1;
            }
            return entryPointFirst + tubeId * 11;
        }
        static int checkCovidPositiveThird(int[] covidPeople,int tubeId,int entryPointFirst)
        {
            int sum = 0;
           
            if (tubeId == 7)
            {
                for (int i = tubeId+entryPointFirst; i < tubeId+entryPointFirst+4; i++)
                {
                    sum += covidPeople[tubeId];
                    
                }
                if (sum == 4)
                {
                    return tubeId + entryPointFirst;
                }
               
            }
                
               


            if (covidPeople[tubeId+entryPointFirst] == 2)
                {
                    Console.WriteLine("Korona vakasinin indexi "+ (tubeId+entryPointFirst));
                    return tubeId;
                }

            
            return -1;

        }
        static int checkCovidPostiveFourth(int[] covidPeople, int tubeId, int entryPointFirst)
        {
           
            if (covidPeople[entryPointFirst+tubeId] == 2)
            {
                Console.WriteLine("index of corona virus"+(entryPointFirst+tubeId));
            }
            return 1;
        }
       
    }
}
