using System;
using Vigenere.Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereCode v = new VigenereCode("ucu", 8);
            Console.WriteLine(v.Decrypt("ISVJED"));
            Console.WriteLine(v.Decrypt("WMWFKN"));
            Console.WriteLine(v.Decrypt("TORQ"));
            Console.WriteLine(v.Decrypt("JSFFOP"));
        }
    }
}
