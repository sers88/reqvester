using System;
using System.Threading.Tasks;

namespace Reqvester
{
    class Program
    {
        static async Task Main()
        {
            IPageLoader loader = new PageLoader();
            IParser textBody = new Parser();
            ICounter countWords = new Counter();
            IShow shower = new Show();
            IWriter writeFile = new Writer();

            while (true)
            {
                Console.WriteLine("Введите адрес сайта. В формате https://имя_сайта");
                var site = Console.ReadLine();

                if (site.ToUpper() == "EXIT") break;

                try
                {
                    var strSite = await loader.GetPage(site);
                    var listSite = textBody.GetBody(strSite);
                    var dicSite = countWords.WordsCount(listSite);
                    shower.ShowText(dicSite);
                    await writeFile.WriteToFile(dicSite);

                }
                catch
                {
                    Console.WriteLine("Введите верное имя сайта!\n");
                }

            }
        }
        
    }
}
