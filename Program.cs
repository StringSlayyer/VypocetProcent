namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Vypocet vypocet = new Vypocet();
            bool isCounting = true;
            while (isCounting)
            {
                Console.WriteLine("Zadej celkovy pocet hodin");
                long celkemHodin = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Zadej pocet hodin, ktere jsi chybel");
                long chybelHodin = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Kolik hodin zbyva do uzavreni znamek?");
                long zbyvaHodin = Convert.ToInt64(Console.ReadLine());
                
                vypocet.VypocetHodin(celkemHodin, chybelHodin, zbyvaHodin);
                Console.WriteLine("Chceete vypocitat dalsi? 1 - Ano, 2 - Ne");
                int pokracuj = Convert.ToInt32(Console.ReadLine());
                switch (pokracuj)
                {
                    case 1: isCounting = true; break;
                    case 2: isCounting = false; break;
                    default:
                        Console.WriteLine("spatna volba, pokracujes xd");
                        isCounting = true; break;
                }

            }
        }
    }
}
