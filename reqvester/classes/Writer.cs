using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Reqvester
{
    interface IWriter
    {
        Task WriteToFile(Dictionary<string, int> buffer);
    }
    public class Writer:IWriter
    {
        public async Task WriteToFile(Dictionary<string, int> buffer)
        {
            string[] lines = new string[buffer.Count];
            var i = 0;

            foreach (var buf in buffer)
            {
                lines[i] = buf.Key + " - " + buf.Value;
                i++;
            }

            await File.WriteAllLinesAsync("WriteLines.txt", lines);
        }
    }
}
