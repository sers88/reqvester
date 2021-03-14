using System;
using System.Collections.Generic;

namespace Reqvester
{
    public class Counter
    {
        public Dictionary<string, int> wordsCount(List<string> words)
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
