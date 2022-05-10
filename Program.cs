using System;      //Riferimento alla libreria di base

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //namespace, classe, metodo

            Console.WriteLine("inserisci il primo numero:");
            Console.WriteLine("Inserisci il secondo numero:");
            string v1 = Console.ReadLine();
            string v2 = Console.ReadLine();

            int V1 = Convert.ToInt32(v1);
            int V2 = Convert.ToInt32(v2);

            Console.WriteLine("Hai inserito: {0}, {1}", V1, V2);
            Console.WriteLine("Il loro prodotto: {0}", Moltiplica(V1, V2));
        }

        static int Moltiplica(int v1, int v2)
        {
            return v1 * v2;
        }

        /*int v1, v2;
         * Console.Write("Inserisci un numero: ");
        if (!int.TryParse(Console.ReadLine(), out v1)) 
                {
            Console.WriteLine("Errore non è stato digitato nessun numero");
            System.Environment.Exit(1);
        }
        Console.Write("Inserisci un numero: ");
        if (!int.TryParse(Console.ReadLine(), out v2))
                {
            Console.WriteLine("Errore non è stato digitato nessun numero");
            System.Environment.Exit(1);
        }

        System.Console.WriteLine("Hello World: {0}, {1}",
            Add(v1, v2), "Ciao");
    }

    static int Add(int v1, int v2)
    {
        return v1 * v2;
    }*/
    }
}
