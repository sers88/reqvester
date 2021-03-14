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
            var shower = new Show();

            while (true)
            {
                Console.WriteLine("Введите адрес сайта. В формате https://имя_сайта");
                var site = Console.ReadLine();

                if (site.ToUpper() == "EXIT") break;

                try
                {
                    var strSite = await loader.GetPage(site);
                    var listSite = textBody.GetBody(strSite);
                    var dicSite = countWords.wordsCount(listSite);
                    shower.ShowText(dicSite);

                }
                catch
                {
                    Console.WriteLine("Введите верное имя сайта!\n");
                }

            }
        }
        
    }
}
