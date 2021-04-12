using System;

namespace Tip_Tax_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //VAriables
            double meal;
            double tip;
            double tax;
            double taxtotal;
            double tiptotal;
            double total;


            //Inputs
            Console.Write("Please Enter Your Meal Amount $");
            meal = double.Parse(Console.ReadLine());

            Console.Write("Please Enter the Tip %");
            tip = double.Parse(Console.ReadLine());

            Console.Write("Please Enter the Tax %");
            tax = double.Parse(Console.ReadLine());

            tiptotal = meal * (tip / 100);
            taxtotal = meal * (tax/100);
            total = meal + taxtotal + tiptotal;


            //Outputs
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Summary");
            Console.WriteLine("Meal -------------- ${0}",meal);
            Console.WriteLine("Tip --------------- {0}%",tip);
            Console.WriteLine("Tax --------------- {0}%",tax);
            Console.WriteLine("Total Tip --------- ${0}",tiptotal);
            Console.WriteLine("Total Tax --------- ${0:f2}",taxtotal);
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Total ------------- ${0}",total);

            Console.ReadKey();
        }
    }
}
