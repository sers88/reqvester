using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Reqvester
{
    public class PageLoader
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<string> GetPage(string page)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(page);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }

    }
}
