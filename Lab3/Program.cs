1using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
          bool isSkyBlue = true;
          bool isKyleRed = false;

          bool result1 = isSkyBlue;
          bool result2 = isKyleRed;

         System.Console.WriteLine(result1);
         System.Console.WriteLine(result2);

         System.Console.ReadLine();
            
            //Temperature Fahrenheit to Celsius

         System.Console.WriteLine("THe Temperature value in Fahrenheit to Celsius");
         int fah = int.Parse(System.Console.ReadLine());
         System.Console.WriteLine();


         int FtoC = ((fah - 32) / 9) * 5;

           
            
            int i = 0;
            while(i < 10) 

                System.Console.WriteLine(i);
            i = i + 1;



            int i = 60;
            while(i > 20)
                System.Console.WriteLine(i);
            i = i - 5;

            // Single-selection statement and repetition statement are both simaler in the way the decide what to do with the infomation. The big diffrence is  repetition statements have two choices while
            //single selection is either yes or no.


        }
    }
}
