using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFrequency
{
    class Program
    {
        public static Stopwatch time = new Stopwatch();
        static void Main(string[] args)
        {
            //Console.WriteLine("press any key to start");
            //Console.ReadLine();
            time.Start();
            Dictionary<char, int> freq = new Dictionary<char, int>();
            string fileName =
                "C:\\Users\\nikol\\OneDrive\\Documents\\Code\\LetterFrequency\\LetterFrequency\\FoundationSeries.txt";
            TallyChars(fileName,freq);
            PrintTally(freq);
        }

        public static void TallyChars(string filePath, Dictionary<char, int> freq)
        {
            int b;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    char c = (char) sr.Read();
                    if (freq.ContainsKey(c))
                    {
                        freq[c]++;
                    }
                    else
                    {
                        freq.Add(c,1);
                    }
                }
            }

        }


        public static void PrintTally(Dictionary<char,int> freq)
        {
            Dictionary<char, int> upperLower = new Dictionary<char, int>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                upperLower.Add(c, freq[c] + freq[Char.ToLower(c)]);
            }

            List<KeyValuePair<char, int>> sorted = upperLower.ToList();

            sorted.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            foreach (var c in sorted)
            {
                Console.WriteLine($"{c.Key} represented {c.Value} times");
            }

            Console.WriteLine("it took: " + time.Elapsed);
        }
    }
}
