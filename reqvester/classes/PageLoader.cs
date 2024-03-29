﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Reqvester
{
    public class PageLoader
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<string> GetPage(string page)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(page);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }

    }
}
