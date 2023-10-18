using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv in ett heltal");
        int tal = int.Parse(Console.ReadLine());

        int störst = tal;

        string svar = "";

        do
        {
            Console.WriteLine("Vill du skriva in ett till heltal? (j/n)");
            svar = Console.ReadLine();

            if (svar == "n")
            {
                break;
            }

            Console.WriteLine("Skriv in ett till heltal");
            int nyttTal = int.Parse(Console.ReadLine());

            if (nyttTal > störst)
            {
                störst = nyttTal;
            }

            Console.WriteLine($"Det största talet du skrev in var {störst}");
        } while (svar != "n");
    }
}