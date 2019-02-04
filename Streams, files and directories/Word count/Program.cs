using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            
            using (var wordReader = new StreamReader("../../../words.txt"))
            {
                while (true)
                {
                    string line = wordReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] splittedLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                    words.AddRange(splittedLine);
                }
            } // reading the words and adding them into List<>.
            

            var wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }
            } // adding the words into dict to follow their count.


            using (var reader = new StreamReader("../../../text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string symbols = " ";
                    foreach (var @char in line)
                    {
                        if (char.IsPunctuation(@char) && @char != '\'')
                        {
                            symbols += @char;
                        }
                    }

                    string[] splittedLine = line.Split(symbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                    foreach (var word in splittedLine) 
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    } // checking if the given words exist in the given line. If they do add +1 to their kvp.value;
                }
            } // checking if the given words exist in the given line. If they do add +1 to their kvp.value;

            
            var sortedDictionary = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            using (var readerResult = new StreamReader("../../../expectedResult.txt"))
            {
                bool isSame = true;
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    string line = readerResult.ReadLine();

                    if (output != line)
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    Console.WriteLine(true);
                }
            } // read how our result need to look from the given file and compare MY result with real one.


            using(var writer = new StreamWriter("../../../actualResult.txt")) // if the comparison is all good we create the file actualResult.txt and write everything there.
            {
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    writer.WriteLine(output);
                }
            } // if the comparison is all good we create the file actualResult.txt and write everything there.

            
        }
    }
}


