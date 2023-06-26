using System;

namespace ee1lab1
{
    class MainClass
    {
        /*
         * Scrieti un program care va calcula media aritmetica a trei numere citite de la
         * tastatura
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("introduceti numarul:");

            int valoareNumarului = int.Parse(Console.ReadLine());
            var textParSauImpar = "";

            if (valoareNumarului % 2 == 0)
            {
                textParSauImpar = " este par";
            } else
            {
                textParSauImpar = " este impar";
            }
            Console.WriteLine("numarul " + valoareNumarului + textParSauImpar);
        }
    }
}

