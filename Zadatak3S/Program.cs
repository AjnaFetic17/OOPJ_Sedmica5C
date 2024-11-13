internal class Program
{
    public static class StringHelper
    {
        public static bool isVocal(char c)
        {
            switch(c)
            {
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
                default: return false;
            }
        }
        public static int BrojVokala(string s)
        {
            int broj = 0;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (isVocal(s[i]))
                {
                    broj++;
                }
                //if ("aeiou".Contains(s[i]))
                //{
                //    broj++;
                //}
            }

            return broj;
        }

        public static string ObrniString(string s)
        {
            string temp = "";

            for (int i = s.Length-1; i >= 0; i--)
            {
                temp += s[i];
            }

            return temp;
        }
    }
    private static void Main(string[] args)
    {
        //kreiraj staticku klasu StringHelper koja sadrzi 2 metode:
        //BrojVokala koja broj samoglasnika u stringu
        //ObrniString koja vraca obrnuti string
        Console.WriteLine(StringHelper.BrojVokala("Starča"));
        Console.WriteLine(StringHelper.BrojVokala("Starčo"));
        Console.WriteLine(StringHelper.ObrniString("Starčo"));
    }
}