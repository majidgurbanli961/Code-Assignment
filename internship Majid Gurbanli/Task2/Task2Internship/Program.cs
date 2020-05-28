using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Internship
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string myText="";
            Console.WriteLine(returnText(703, myText));
        }
        // recursive way of doing task
        static string returnText(int number,string myText)

        {
            
            int remain = number % 26;
         
            if (remain == 0)
            {
                remain = 26;
            }
           
         
            if (number >= 27)
            {
               
                number = (number - remain) / 26;
               myText= returnText(number,myText);
              
            }
            Console.WriteLine(remain);
            char character = (char)((remain)+64);
                myText += character.ToString();
                return myText;
        }
        // iterative way of doing task
        static string returnSecondText(int number,string myText)
        {
            int remain;
            while (number > 0)
            {
                Console.WriteLine(number);
                remain = number % 26;
                if (remain == 0)
                {
                    remain = 26;
                }

                char character = (char)((remain) + 64);
                myText += character.ToString();
                number = (number - remain) / 26;
              

            }
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);


            return new string(charArray);
        }
    }
}
