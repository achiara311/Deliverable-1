using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv_1
{
    class Program
    {
        static void Main(string[] args)
        {
             
             int amounts;
             double[] numberOfAmountsArray;

            //Enter number of amounts as 3
             Console.WriteLine("Please enter the number of deposits you would like to make. ");
             amounts = Convert.ToInt32(Console.ReadLine());

             numberOfAmountsArray = new double[amounts];

             //Enter three different amounts
             for (int i = 0; i < amounts;i++)
             {
                 Console.WriteLine("Dollar amount #{0}: ", i + 1);
                 numberOfAmountsArray[i] = Convert.ToDouble(Console.ReadLine());
             }

             //Total Sum
             double sum = numberOfAmountsArray.Sum();
             Console.WriteLine("Total sum of dollar amount is {0:C2} ", sum);


             //Average 
              double average = (sum) / amounts;
             Console.WriteLine("The average of dollar amounts is {0:C2} ", average);

             //Biggest and Smallest Amount
             double largestAmount, smallestAmount;
             largestAmount = numberOfAmountsArray[0];
             smallestAmount = numberOfAmountsArray[0];
             for (int i = 1; i < amounts; i++)
             {
                 if (numberOfAmountsArray[i] > largestAmount)
                     largestAmount = numberOfAmountsArray[i];
                 else if (numberOfAmountsArray[i] < smallestAmount)
                     smallestAmount = numberOfAmountsArray[i];
             }
             Console.WriteLine("Largest amount entered is {0:C2}", largestAmount);
             Console.WriteLine("Smallest amount entered is {0:C2}", smallestAmount);

             //Currencies
            decimal usAmount = (decimal)numberOfAmountsArray.Sum();
           
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //US Total
            Console.Out.WriteLine("\u2022 US: {0:C2} ", usAmount.ToString("C", new CultureInfo("us-US")));

            //Sweden Total
            Console.Out.WriteLine("\u2022 Swedish: {0:C2}", usAmount.ToString("C", new CultureInfo("sv-SE")));

            //Japan Total
            Console.Out.WriteLine("\u2022 Japanese: {0} ", usAmount.ToString("C", new CultureInfo("ja-JP")));

            //Thailand Total
            Console.Out.WriteLine("\u2022 Thai: {0:C2}", usAmount.ToString("C", new CultureInfo("th-TH")));
           

            Console.ReadKey();
        }
    }
}
