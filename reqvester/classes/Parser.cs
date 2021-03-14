using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Reqvester
{
    public class Parser
    {
        public List<string> GetBody(string page)
        {
            var firstBody = page.IndexOf("<body>") + "<body>".Length;
            var lastBody = page.IndexOf("</body>");
            page = page.Substring(firstBody, lastBody - firstBody);
            
            page = Regex.Replace(page, "<.*?>", String.Empty);

            char[] delimiterChars = { ' ', ',','.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
            string[] phrase = page.Split(delimiterChars);

            List<string> pageList = new List<string>();

            foreach (var word in phrase)
                if (word != String.Empty) pageList.Add(word.ToUpper());

            return pageList;
        }
    }
}
