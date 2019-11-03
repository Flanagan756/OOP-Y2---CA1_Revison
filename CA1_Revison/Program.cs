using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_Revison
{
    class Program
    {
        //Constant Varibles
        const double TRAVEL_COST = 0.45;
        const double FITTING_COST_SQUARE_METER = 3.25;

        static void Main(string[] args)
        {
            //Varibles
            double distanceInKM;
            double carpetSize;
            double totalCost;
            double finalCost = 0;
            int numberOfFittings = 0;
            bool doAgain = true;

            Console.WriteLine("The Carpet Fitting Cost Calculator");


            while (doAgain == true)
            {
                Console.Write("Enter a distance in Kilometers: ");
                distanceInKM = double.Parse(Console.ReadLine());

                Console.Write("Enter a carpet size: ");
                carpetSize = double.Parse(Console.ReadLine());

                totalCost = CalculateCost(distanceInKM, carpetSize);

                Console.Write("Cost of fitting: {0:c}", totalCost);
                Console.WriteLine();

                //final costs additons
                finalCost = finalCost + totalCost;
                numberOfFittings++;

                Console.WriteLine();
                Console.Write("Enter a 0 to end or 1 to input aanother fitting detail: ");
                int awnser = int.Parse(Console.ReadLine());

                if (awnser == 1)
                {
                    doAgain = true;
                }
                else
                {
                    doAgain = false;
                }
            }

            //Display final total figures
            Console.WriteLine("Total Costs: {0:c}", finalCost);

            double averageCost = finalCost / numberOfFittings;
            Console.WriteLine("Average Costs: {0:c}", averageCost);

        }
        static double CalculateCost(double enteredDistance, double enteredCarpetSize)
        {
            double totalCost = (TRAVEL_COST * enteredDistance) + (FITTING_COST_SQUARE_METER * enteredCarpetSize);

            if (totalCost >= 250)
            {
                totalCost = totalCost * 0.9;
            }

            return totalCost;
        }





    }
}
