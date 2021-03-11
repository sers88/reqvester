using System;
using System.Threading.Tasks;

namespace Reqvester
{
    class Program
    {
        static async Task Main()
        {
            var loader = new PageLoader();
            var textBody = new Parser();
            var countWords = new Counter();

            var v = await loader.GetPage("https://sers88.github.io/");
            var listV = textBody.GetBody(v);
            countWords.wordsCount(listV);
        }
        
    }
}
