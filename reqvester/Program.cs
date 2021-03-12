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

            Console.WriteLine("Введите адрес сайта. В формате https://имя_сайта");
            string site = Console.ReadLine();

            var v = await loader.GetPage(site);
            var listV = textBody.GetBody(v);
            countWords.wordsCount(listV);
        }
        
    }
}
