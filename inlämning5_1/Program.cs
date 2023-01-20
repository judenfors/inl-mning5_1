using System;
namespace inlämning5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = { "Mening1", "Mening2", "Mening3", "Mening4" };

            for(int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine(sentences[i]);
                Console.WriteLine();
            }
        }
    }
}