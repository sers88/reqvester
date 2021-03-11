using System;
using System.Collections.Generic;
using System.Text;

namespace Reqvester
{
    public class Counter
    {
        public void wordsCount(List<string> words)
        {
            Dictionary<string, int> bufer = new Dictionary<string, int>();

            for(int i = 1; i < words.Count; i++)
            {
                string word = words[i];
                if (bufer.ContainsKey(word))
                {
                    int count = bufer[word];
                    count++;
                    bufer[word] = count;
                }
                else
                {
                    bufer.Add(word, 1);
                }
            }

            foreach (var buf in bufer)
                Console.WriteLine("{0} - {1}", buf.Key, buf.Value);
        }
    }
}
