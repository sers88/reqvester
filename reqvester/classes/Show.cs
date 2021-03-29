using System;
using System.Collections.Generic;

namespace Reqvester
{
    interface IShow
    {
        void ShowText(Dictionary<string, int> buffer);
    }
    public class Show:IShow
    {
        public void ShowText(Dictionary<string, int> buffer)
        {
            foreach (var buf in buffer)
                Console.WriteLine("{0} - {1}", buf.Key, buf.Value);
        }
    }
}
