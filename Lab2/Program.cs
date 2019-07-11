using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 0;
            double w;
            double h;
            double param;
            bool cont = true;

            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            while (cont == true)
            {

                Console.WriteLine("Enter Length:");
                l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Weidth:");
                w = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area:" + l * w);
                param = 2 * l + 2 * w;
                Console.WriteLine("Perimeter:" + param);


                Console.WriteLine("Continue? Y/N");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "y")
                {
                    cont = true;
                }
                else

                {
                    cont = false;

                    Console.WriteLine("Thanks");
                }

            }


            Console.ReadKey();


        }


    }
}
