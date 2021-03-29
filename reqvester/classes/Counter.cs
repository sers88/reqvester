using System;
using System.Collections.Generic;

namespace Reqvester
{
    interface ICounter
    {
        Dictionary<string, int> WordsCount(List<string> words);
    }
    public class Counter:ICounter
    {
        public Dictionary<string, int> WordsCount(List<string> words)
        {
            Dictionary<string, int> buffer = new Dictionary<string, int>();

            for(var i = 1; i < words.Count; i++)
            {
                var word = words[i];
                if (buffer.ContainsKey(word))
                {
                    int count = buffer[word];
                    count++;
                    buffer[word] = count;
                }
                else
                {
                    buffer.Add(word, 1);
                }
            }

            return buffer;
        }
    }
}
