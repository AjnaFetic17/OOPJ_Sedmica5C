internal class Program
{
    public static class Matematika
    {
        public static int brojPoziva = 0;

        public static int Zbir(int x, int y)
        {
            brojPoziva++;
            return x + y;
        }

        public static int Najveci(int x, int y, int z)
        {
            brojPoziva++;
            return Math.Max(x, Math.Max(y,z));
        }
    }

    private static void Main(string[] args)
    {
        //U staticku klasu Matematika dodati staticko polje brojPoziva koji broji koliko puta su pozvane metode Zbir i Najveci
        //metoda Najveci prima 3 broja i vraca najveci
        Console.WriteLine(Matematika.brojPoziva);
        Console.WriteLine(Matematika.Zbir(1,2));
        Console.WriteLine(Matematika.brojPoziva);
        Console.WriteLine(Matematika.Najveci(12, 1, 2));
        Console.WriteLine(Matematika.Najveci(12, 1, 2));
        Console.WriteLine(Matematika.Najveci(12, 1, 2));
        Console.WriteLine(Matematika.brojPoziva);


    }
}