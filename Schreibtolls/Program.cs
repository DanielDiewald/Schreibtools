using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtolls
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> farben = new List<int>() { 0, 9, 11, 1, 3, 8, 2, 5, 4, 6, 7, 10, 13, 12, 15, 14 };
            Random random = new Random();
            List<Stift> stifte = new List<Stift>();
            stifte.Add(new Kugelschreiber(random.Next(1,25), (ConsoleColor)farben[random.Next(0,farben.Count)]));
            stifte.Add(new Kugelschreiber(random.Next(1, 25), (ConsoleColor)farben[random.Next(0,farben.Count)]));
            stifte.Add(new Buntstifte(random.Next(1, 25), (ConsoleColor)farben[random.Next(0,farben.Count)]));
            stifte.Add(new Buntstifte(random.Next(1, 25), (ConsoleColor)farben[random.Next(0,farben.Count)]));
            stifte.Add(new Buntstifte(random.Next(1, 25),(ConsoleColor)0));
            //ist zwar hässlich könnte man aber ansonsten nicht lesen
            foreach (var item in stifte)
            {
                Console.WriteLine(item.SchreibeTest(LoremIpsum(3, 10, 1, 3, 1)));
            }
            Console.ReadKey();
        }


        static string LoremIpsum(int minWords, int maxWords,
    int minSentences, int maxSentences,
    int numParagraphs)
        {

            var words = new[]{"sdads", "saffs", "asdsaf", "avssv", "wedw", "safasf",
        "tjfjt", "fgh", "rgdhdrh", "hrrdsg", "geesge", "agdgd", "asfgfgd",
        "ftjerdr", "rgrhdh", "rdhfh", "drhdhvd", "dfhdhr", "dhrf", "dhfb"};

            var rand = new Random();
            int numSentences = rand.Next(maxSentences - minSentences)
                + minSentences+1;
            int numWords = rand.Next(maxWords - minWords) + minWords + 1;

            StringBuilder result = new StringBuilder();

            for (int p = 0; p < numParagraphs; p++)
            {
                
                for (int s = 0; s < numSentences; s++)
                {
                    for (int w = 0; w < numWords; w++)
                    {
                        if (w > 0) { result.Append(" "); }
                        result.Append(words[rand.Next(words.Length)]);
                    }
                    result.Append(". ");
                }
                
            }
            return result.ToString();
        }
    }
}
