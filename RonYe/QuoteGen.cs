using System;
using Newtonsoft.Json.Linq;

namespace RonYe
{
	public class QuoteGen
	{
		private HttpClient _client;

		public QuoteGen(HttpClient client)
		{
			_client = client;
		}

		public string Kanye()
		{
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
			return kanyeQuote;
        }

		public string RonSwanson()
		{
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var swansonResponse = _client.GetStringAsync(swansonURL).Result;
            var ronQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
			return ronQuote;
        }
	}
}

