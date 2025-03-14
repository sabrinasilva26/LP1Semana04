using System;

namespace BetterDecorador
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            if (args.Length==3)
            {
                string phrase = args[0];
                char Char = char.Parse(args[1]);
                int times = int.Parse(args[2]);
                Console.WriteLine(Decor(phrase,Char,times));
            }
            else
            {
                Console.WriteLine("Incompatible Format!");
            }
        }

        private static string Decor(string s, char dec, int count)
        {
            string decor = new string(dec, count);
            return $"{decor} {s} {decor}";
        }

    }   
}