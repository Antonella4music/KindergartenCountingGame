using System;
using System.Linq;
using System.IO;

namespace CountWordsNnr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file and display it line by line.
            StreamReader file = new StreamReader("in.txt");
            string[] lines = File.ReadAllLines("in.txt").ToArray();
            string final = "";
            int contor = 0;
            
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("line " + i + ": " + lines[i] + "--> " + CountWords(lines[i]) + " words");
                contor++;
                final += CountWords(lines[i]) + Environment.NewLine;
            }

            final += Environment.NewLine + "Lines number: " + contor;
            File.WriteAllText("out.txt", final );

            Console.WriteLine("\nPress any key to exit!");
            Console.ReadLine();
        }

        public static int CountWords(string linie) //Count words with loop and character tests.
        {
            int counter = 0;
            for (int i = 1; i < linie.Length; i++)
            {
                if (char.IsWhiteSpace(linie[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(linie[i]) == true )//|| char.IsPunctuation(linie[i]))
                    {
                        counter++;
                    }
                }
            }
            if (linie.Length > 2)
            {
                counter++;
            }
            return counter;
        }

    }
}
