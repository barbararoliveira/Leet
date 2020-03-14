using System;

namespace leet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva e traduza para Leet Speak.");
            string leet = Console.ReadLine();
            leet= leet.Replace("A", "4");
            leet= leet.Replace("a", "4");
            leet= leet.Replace("E", "3");
            leet= leet.Replace("e", "3");
            leet= leet.Replace("I", "1");
            leet= leet.Replace("i", "1");
            leet= leet.Replace("L", "1");
            leet= leet.Replace("l", "1");
            leet= leet.Replace("O", "0");
            leet= leet.Replace("o", "0");
            leet= leet.Replace("T", "7");
            leet= leet.Replace("t", "7");
            leet= leet.Replace("S", "5");
            leet= leet.Replace("s", "5");
            Console.WriteLine(leet);
            
        }
    }
}
