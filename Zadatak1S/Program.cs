internal class Program
{
    public static class Matematika
    {
        public static int Zbir(int x, int y)
        {
            return x + y;
        }    
    }
    private static void Main(string[] args)
    {
        //Napisati staticku klasu Matematika koja sadrzi jednu staticku metodu Zbir. Metoda prima 2 parametra i vraca njihov zbir
        Console.WriteLine(Matematika.Zbir(6,90));
    }
}