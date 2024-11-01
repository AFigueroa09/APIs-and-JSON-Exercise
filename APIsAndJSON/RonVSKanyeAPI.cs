using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        private HttpClient _client;

        public RonVSKanyeAPI(HttpClient client)
        {
            _client = client;
        }

        public string GetRonQuote()
        {
            string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronUrl).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return ronQuote;
        }

        public string GetKanyeQuote()
        {
            string kanyeUrl = "https://api.kanye.rest/";
            var kanyeResponse = _client.GetStringAsync(kanyeUrl).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }

    }
}
