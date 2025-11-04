using System;

namespace arrayes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  selezione esercizi 

            Console.WriteLine("dammi il numero dell esercizio che vuoi vedere  ");
            int z = Convert.ToInt32(Console.ReadLine());


            if (z == 1)
            {
                // Esercizio 1 :

                int[] num = new int[3];

                for (int i = 0; i < num.Length; i++)
                {

                    Console.WriteLine("dammi il valore del " + i + " numero ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    num[i] = n;


                }

                for (int I = num.Length - 1; I >= 0; I--)
                {
                    Console.WriteLine("la sequenza e " + num[I]);
                }
            }
            if (z == 2)
            {
                //Esercizio 2:

                int[] numeri = new int[5];

                for (int i = 0; i < numeri.Length; i++)
                {

                    Console.WriteLine("dammi il valore del " + i + " numero ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    numeri[i] = n;


                }
                
            }
        }
    }
}
