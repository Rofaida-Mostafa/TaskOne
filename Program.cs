using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Task_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
//===========================================================
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            const double taxRate = 0.06;

           Console.WriteLine(
               "{" +
               "List of price:\n " +
               "Price per small room: $25, \n " +
               "Price per large room: $35, \n " +
               "Tax: $6.6, \n" +
               " This estimate is valid for 30 days" +
               "}\n" );

            Console.WriteLine("What's the number of small carpets? ");
            int? numOfSmallCarpet= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What's the number of small carpets? ");
            int? numOfLargeCarpet= Convert.ToInt16(Console.ReadLine());
            int? costBeforeTaxes = ((numOfSmallCarpet * smallCarpetPrice) + (numOfLargeCarpet * largeCarpetPrice));
            double? costAfterTaxes = (costBeforeTaxes * taxRate) + costBeforeTaxes;

            Console.WriteLine($"Number of small carpets: ${numOfSmallCarpet},\n" +
                $"Number of large carpets: ${numOfLargeCarpet},\n" +
                $"Price per small room: {(numOfSmallCarpet * smallCarpetPrice)}\n" +
                $"Price per large room: {(numOfLargeCarpet * largeCarpetPrice)}\n" +
                $"Total estimate:{costAfterTaxes}");

//===========================================================

            //   Islam's Carpet Cleaning Service
            //    Charges:
            //        $25 per small
            //        $35 per large
            //    Sales tax rate is 6 %
            //    Estimates are valid for 30 days

            //    Prompt the user for the number of small and large rooms they would like cleaned
            //    and provide an estimate such as:
            //Estimate for carpet cleaning service
            //Number of small carpets: 3 < --
            //Number of large carpets: 1 < --
            //Price per small room: $25
            //Price per large room: $35
            //Cost : $110
            //Tax: $6.6
            //===============================
            //Total estimate: $116.6
            //This estimate is valid for 30 days

            //hint: + - * /
        }
    }
}
