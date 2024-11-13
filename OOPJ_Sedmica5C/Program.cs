internal class Program
{
    public static class Matematika
    {
        public static int broj = 5;

        public static int Kvadrat( int x)
        {
            return x*x;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Matematika.broj);
        Console.WriteLine(Matematika.Kvadrat(3));
    }
}