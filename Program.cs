using System;
using System.Linq;
using System.Globalization;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //First amount
            Console.WriteLine("Input first amount:");
            string userinput1 = Console.ReadLine();
            decimal amountOne = 0;

            bool TGPA = decimal.TryParse(userinput1, out amountOne);

            while (TGPA == false)
            {
                Console.WriteLine("{0} is not a valid number, please try again", userinput1);
                userinput1 = Console.ReadLine();
                amountOne = 0;
                TGPA = decimal.TryParse(userinput1, out amountOne);
            }

            //Second amount
            Console.WriteLine("Input second amount:");
            string userinput2 = Console.ReadLine();
            decimal amountTwo = 0;

            bool TGPA1 = decimal.TryParse(userinput2, out amountTwo);

            while (TGPA1 == false)
            {
                Console.WriteLine("{0} is not a valid number, please try again", userinput2);
                userinput1 = Console.ReadLine();
                amountTwo = 0;
                TGPA1 = decimal.TryParse(userinput2, out amountTwo);
            }

            //Third amount
            Console.WriteLine("Input third amount:");
            string userinput3 = Console.ReadLine();
            decimal amountThree = 0;

            bool TGPA2 = decimal.TryParse(userinput3, out amountThree);

            while (TGPA2 == false)
            {
                Console.WriteLine("{0} is not a valid number, please try again", userinput3);
                userinput3 = Console.ReadLine();
                amountOne = 0;
                TGPA2 = decimal.TryParse(userinput3, out amountThree);
            }


            decimal[] amountsArray = {amountOne, amountTwo, amountThree};

            //US
            Console.WriteLine("US:");
            decimal Max = (amountsArray.Max());
            Console.WriteLine("Maximum: "+ string.Format(new CultureInfo("en-US"), "{0:c}", Max)); 

            decimal Min = (amountsArray.Min());
            Console.WriteLine("Minimum: " + string.Format(new CultureInfo("en-US"), "{0:c}", Min));

            decimal Average = (amountsArray.Average());
            Console.WriteLine("Average: " + string.Format(new CultureInfo("en-US"), "{0:c}", Average));

            Console.WriteLine();

            //Swedish
            Console.WriteLine("Swedish:");
            decimal Max1 = (amountsArray.Max());
            Console.WriteLine("Maximum: "+ string.Format(new CultureInfo("sv-SE"), "{0:c}", Max1)); 

            decimal Min1 = (amountsArray.Min());
            Console.WriteLine("Minimum: " + string.Format(new CultureInfo("sv-SE"), "{0:c}", Min1));

            decimal Average1 = (amountsArray.Average());
            Console.WriteLine("Average: " + string.Format(new CultureInfo("sv-SE"), "{0:c}", Average1));

            Console.WriteLine();

            //Japanese
            Console.WriteLine("Japanese: ");
            decimal Max2 = (amountsArray.Max());
            Console.WriteLine("Maximum: " + string.Format(new CultureInfo("ja-JP"), "{0:c}", Max2));

            decimal Min2 = (amountsArray.Min());
            Console.WriteLine("Minimum: " + string.Format(new CultureInfo("ja-JP"), "{0:c}", Min2));

            decimal Average2 = (amountsArray.Average());
            Console.WriteLine("Average: " + string.Format(new CultureInfo("ja-JP"), "{0:c}", Average2));

            Console.WriteLine();

            //Thai
            Console.WriteLine("Thai:");
            decimal Max3 = (amountsArray.Max());
            Console.WriteLine("Maximum: " + string.Format(new CultureInfo("th-TH"), "{0:c}", Max3));

            decimal Min3 = (amountsArray.Min());
            Console.WriteLine("Minimum: " + string.Format(new CultureInfo("th-TH"), "{0:c}", Min3));

            decimal Average3 = (amountsArray.Average());
            Console.WriteLine("Average: " + string.Format(new CultureInfo("th-TH"), "{0:c}", Average3));

            Console.WriteLine();




        

        }
    }
}
