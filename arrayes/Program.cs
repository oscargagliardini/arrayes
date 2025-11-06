namespace arrayes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  selezione esercizi 

            Console.WriteLine("dammi il numero dell esercizio che vuoi vedere");
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
            else if (z == 2)
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

            if (z == 3)
            {
                    //Esercizio 3:

                    int[] numD = { 4, 7, 8, 2, 9, 7 };
                    for (int i = 0; i < numD.Length; i++)
                        if (numD[i] % 2 == 1)
                        {
                            Console.Write("[" + numD[i] + "]");

                        }

            }
            if (z == 6)
            {
                    //Esercizio 6: 


                    int[] vet1 = { 1, 5, -2, 9, 4 };

                    int v2c = 0;
                    int v3c = 0;
                    int x = 3;
                    //for per la lunghezza di v2 e v3
                    for (int i = 0; i < vet1.Length; i++)
                    {


                        if (vet1[i] >= x)
                        {
                            v2c++;
                        }
                        else
                        {
                            v3c++;
                        }
                    }
                    //creo i due vettori
                    int[] vet2 = new int[v2c];
                    int[] vet3 = new int[v3c];
                    //creo i gli indici
                    int indexv2 = 0;
                    int indexv3 = 0;
                    for (int i = 0; i < vet1.Length; i++)
                    {
                        if (vet1[i] > x)
                        {
                            vet2[indexv2] = vet1[i];
                            indexv2++;
                        }
                        else
                        {
                            vet3[indexv3] = vet1[i];
                            indexv3++;
                        }
                    }
                    //output vettori 
                    for (int i = 0; i < vet2.Length; i++)
                    {
                        Console.WriteLine(vet2[i]);
                    }
                    for (int i = 0; i < vet3.Length; i++)
                    {
                        Console.WriteLine(vet3[i]);
                    }
            }

            if(z==7)
            {
                Console.WriteLine("dammi il tipo di  esercizio che vuoi vedere: media - somma - min - max - indicemin - indicemax");
                string t=Console.ReadLine();
                if (t == "media") {

                    float media = 0;
                    int s = 0;
                    int[] v1 = { 1, 5, -2, 9 };
                    for (int i = 0; i < v1.Length; i++)
                    {
                        s = s + v1[i];
                    }
                    media = s / 4;
                    Console.WriteLine(media);
                }
                if (t == "min")
                {
                    int minimo = 0;
                    int[] v1 = { 4, 9, -2, 5 };
                    for(int i =0; i < v1.Length; i++)
                    {
                        if(v1[i] < minimo)
                        {
                            minimo = v1[i];
                        }
                    }
                    Console.WriteLine(minimo);
                }
                if (t == "max") 
                {
                    int massimo = 0;
                    int[] v1 = { 4, 9, -2, 5 };
                    for (int i = 0; i < v1.Length; i++)
                    {
                        if (v1[i] > massimo)
                        {
                            massimo = v1[i];
                        }
                    }
                    Console.WriteLine(massimo);
                }
                
            }

        }
    }
}
