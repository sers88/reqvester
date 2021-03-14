using System;
using System.Collections.Generic;

namespace Reqvester
{
    public class Show
    {
        public void ShowText(Dictionary<string, int> buffer)
        {
            foreach (var buf in buffer)
                Console.WriteLine("{0} - {1}", buf.Key, buf.Value);
        }
    }
}
